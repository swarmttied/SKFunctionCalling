using SKFunctionCalling;

namespace SKFunctionCallingWinform
{
    public partial class Form1 : Form
    {
        private UserService userService;
        private FunctionCaller _functionCaller;


        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
            _functionCaller = new FunctionCaller("https://bci-ai-ppe-openai.openai.azure.com/", "bci-gpt4o");
            _functionCaller.ResponseReceived += _functionCaller_ResponseReceived;
            _functionCaller.RateExceeded += _functionCaller_RateExceeded;
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            PopulateRolesListBox();
            RefreshUserList();
            await _functionCaller.Run("Hello. What is your name?");
        }

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
            RoleService roleService = new RoleService();
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
            var users = new UserRoleService().GetUsersInRole(role.Name);
            usersInRoleListBox.DataSource = users;
            usersInRoleListBox.DisplayMember = "Username";
        }

        private void addUserRoleButton_Click(object sender, EventArgs e)
        {
            try
            {
                new UserRoleService().AddUserToRole(
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

                new UserRoleService().RemoveUserFromRole(username, roleName);

                RefreshUsersInRoleListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing user from role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void sendButton_ClickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(promptTextBox.Text))
            {
                var prompt = $"You > {promptTextBox.Text}";
              

                chatListBox.Items.Add(prompt);
                AddTextToRichTextBox(richTextBox1, prompt);
                ChangeRichTextBoxColor(richTextBox1, prompt, Color.Black);

                await _functionCaller.Run(promptTextBox.Text);

                promptTextBox.Clear();
            }
        }

        private void _functionCaller_RateExceeded(object? sender, FunctionCaller.RateExceededEventArgs e)
        {
            var chatEntry = $"Bot > Rate limit exceeded. Retrying after {e.WaitTimeInSeconds} seconds.";
            chatListBox.Items.Add(chatEntry);
          
        }

        private void _functionCaller_ResponseReceived(object? sender, FunctionCaller.ResponseEventArgs e)
        {
            var chatEntry = $"Bot > {e.Response}";
            chatListBox.Items.Add(chatEntry);
            AddTextToRichTextBox(richTextBox1, chatEntry);
            ChangeRichTextBoxColor(richTextBox1, chatEntry, Color.Green);
        }
       

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


    }
}
