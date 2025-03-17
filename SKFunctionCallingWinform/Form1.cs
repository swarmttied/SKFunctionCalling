using SKFunctionCalling;
using SKLib;
using SKLIb;
using System.Data;


namespace SKFunctionCallingWinform
{
    public partial class Form1 : Form
    {
        readonly UserService userService;
        readonly RoleService roleService;
        readonly UserRoleService userRoleService;
        readonly ISKClient _functionCaller;
        readonly ISKClient _queryGen;
        readonly IDbHelper _dbHelper;
        readonly string _chatBanner;
        readonly string _queryGenBanner;
        const string InitialPrompt = "Who are you and what can you do for me?";


        public Form1(ISKClient functionCaller, IFunctionCalled[] services, string chatBanner, ISKClient queryGen, IDbHelper dbHelper, string queryGenBanner)
        {
            InitializeComponent();
            _chatBanner = chatBanner;
            userService = new UserService();
            _functionCaller = functionCaller;
            _functionCaller.ResponseReceived += _functionCaller_ResponseReceived;
            _functionCaller.RateExceeded += _functionCaller_RateExceeded;

            foreach (IFunctionCalled svc in services)
            {
                svc.FunctionCalled += Svc_FunctionCalled;
            }
            userService.FunctionCalled += Form_FunctionCalled;
            roleService = new RoleService();
            roleService.FunctionCalled += Form_FunctionCalled;
            userRoleService = new UserRoleService();
            userRoleService.FunctionCalled += Form_FunctionCalled;

            _queryGen = queryGen;
            _queryGen.ResponseReceived += queryGen_ResponseReceived;

            _dbHelper = dbHelper;
            _queryGenBanner = queryGenBanner;
        }


        private void Form_FunctionCalled(object? sender, FunctionCallEventArgs e)
        {
            calledFunctionsListBox.Items.Add(e.FunctionName);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            PopulateRolesListBox();
            RefreshUserList();
            richTextBox1.AppendText(_chatBanner + Environment.NewLine);
            queryGenRTB.AppendText(_queryGenBanner + Environment.NewLine);
            await _functionCaller.RunAsync(InitialPrompt);
            await _queryGen.RunAsync(InitialPrompt);
            promptTextBox.Focus();
        }

        #region Manual Form

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            try
            {
                userService.AddUser(new User
                {
                    Username = usernameTextBox.Text,
                    Fullname = fullnameTextBox.Text,
                    Email = emailTextBox.Text,
                });
                usernameTextBox.Text = "";
                fullnameTextBox.Text = "";
                emailTextBox.Text = "";
                RefreshUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshUserList()
        {
            var users = userService.ListUsers();
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = "Username";
        }

        private void PopulateRolesListBox()
        {
            var roles = roleService.ListRoles();
            roleCombo.DataSource = roles;
            roleCombo.DisplayMember = "Name";
            roleCombo.SelectedIndex = 0;
        }

        private void listUsersButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void getUserButton_Click(object sender, EventArgs e)
        {
            var user = userService.GetUser(((User)usersListBox.SelectedItem).Username);
            if (user != null)
            {
                usernameTextBox.Text = user.Username;
                fullnameTextBox.Text = user.Fullname;
                emailTextBox.Text = user.Email;
            }
        }

        private void roleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUsersInRoleListBox();
        }

        private void RefreshUsersInRoleListBox()
        {
            var role = (Role)roleCombo.SelectedItem;
            var users = userRoleService.GetUsersInRole(role.Name);
            usersInRoleListBox.DataSource = users;
            usersInRoleListBox.DisplayMember = "Username";
        }

        private void addUserRoleButton_Click(object sender, EventArgs e)
        {
            try
            {
                userRoleService.AddUserToRole(
                    username: userRoleUsernameTextBox.Text,
                    roleName: roleCombo.Text
                );
                RefreshUsersInRoleListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user to role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeUsersButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUser = (User)usersListBox.SelectedItem;

                userService.RemoveUser(selectedUser.Username);
                RefreshUserList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void remnoveUserRoleButton_Click(object sender, EventArgs e)
        {
            try
            {
                var username = userRoleUsernameTextBox.Text;
                var roleName = roleCombo.Text;

                userRoleService.RemoveUserFromRole(username, roleName);

                RefreshUsersInRoleListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing user from role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listUsersButton_Click_1(object sender, EventArgs e)
        {
            RefreshUserList();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void usersListBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = getUserButton;
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = addUsersButton;
        }

        private void userRoleUsernameTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = addUserRoleButton;
        }

        private void usersInRoleListBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = remnoveUserRoleButton;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            calledFunctionsListBox.Items.Clear();
        }

        #endregion

        #region Function Calling

        private void Svc_FunctionCalled(object? sender, FunctionCallEventArgs e)
        {
            var chatEntry = $"Function: {e.FunctionName}";
            Invoke(() =>
            {
                AddTextToRichTextBox(richTextBox1, chatEntry);
                ChangeRichTextBoxColor(richTextBox1, chatEntry, Color.Blue);
            });

        }

        private async void sendButton_ClickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(promptTextBox.Text))
            {
                string input = promptTextBox.Text;

                var prompt = $"You > {input}";
                promptTextBox.Clear();

                AddTextToRichTextBox(richTextBox1, prompt);
                ChangeRichTextBoxColor(richTextBox1, prompt, Color.Black);

                await _functionCaller.RunAsync(input);

                promptTextBox.Clear();
                promptTextBox.Focus();
            }
        }

        private void _functionCaller_RateExceeded(object? sender, SKClient.RateExceededEventArgs e)
        {         
            var chatEntry = $"System > Rate limit exceeded. Retrying after {e.WaitTimeInSeconds} seconds.";
            AddTextToRichTextBox(richTextBox1, chatEntry);
            ChangeRichTextBoxColor(richTextBox1, chatEntry, Color.Purple);

        }

        private void _functionCaller_ResponseReceived(object? sender, SKClient.ResponseEventArgs e)
        {
            var chatEntry = $"Bot > {e.Response}";
            AddTextToRichTextBox(richTextBox1, chatEntry);
            ChangeRichTextBoxColor(richTextBox1, chatEntry, Color.Green);
        }

        private void promptTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = sendButton;
        }

        #endregion

        #region QueryGen

        private async void queryGenSendButton_ClickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(queryGenPromptTextBox.Text))
            {
                string input = queryGenPromptTextBox.Text;

                var prompt = $"You > {input}";
                queryGenPromptTextBox.Clear();

                AddTextToRichTextBox(queryGenRTB, prompt);
                ChangeRichTextBoxColor(queryGenRTB, prompt, Color.Black);

                await _queryGen.RunAsync(input);

                queryGenPromptTextBox.Clear();
                queryGenPromptTextBox.Focus();
            }
        }

        private void queryGen_ResponseReceived(object? sender, SKClient.ResponseEventArgs e)
        {
            dataGridView1.DataSource = null;

            var chatEntry = $"Bot > {e.Response}";
            AddTextToRichTextBox(queryGenRTB, chatEntry);
            ChangeRichTextBoxColor(queryGenRTB, chatEntry, Color.Green);

            if (e.SqlQueries.Any() == false)
                return;

            try
            {
                foreach (var qry in e.SqlQueries)
                {
                    DataTable tbl = _dbHelper.RunQuery(qry);
                    dataGridView1.DataSource = tbl;
                }

            }
            catch (Exception ex)
            {
                // Display only constraint errors
                var errorEntry = $"System > ERROR! {ex.Message}";
                AddTextToRichTextBox(queryGenRTB, errorEntry);
                ChangeRichTextBoxColor(queryGenRTB, errorEntry, Color.Red);

            }
        }

        private void queryGenPromptTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = queryGenSendButton;
        }

        #endregion

        #region Helpers and Common

        private void ChangeRichTextBoxColor(RichTextBox richTextBox, string text, Color color)
        {
            int startIndex = richTextBox.Text.IndexOf(text);
            if (startIndex != -1)
            {
                richTextBox.Select(startIndex, text.Length);
                richTextBox.SelectionColor = color;
                richTextBox.DeselectAll();
            }
        }

        private void AddTextToRichTextBox(RichTextBox richTextBox, string text)
        {
            richTextBox.AppendText(text + Environment.NewLine);
        }


        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            // Autoscroll to the bottom of the richTextBox1
            richTextBox.SelectionStart = richTextBox1.Text.Length;
            richTextBox.ScrollToCaret();
        }

        #endregion
       
    }
}
