using SKFunctionCalling;

namespace SKFunctionCallingWinform
{
    public partial class Form1 : Form
    {
        private UserService userService;


        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRolesListBox();
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
    }
}
