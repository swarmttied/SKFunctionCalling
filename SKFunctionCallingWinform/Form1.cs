using SKFunctionCalling;
using static SKFunctionCalling.DbHelper;
using static SKFunctionCalling.RoleService;

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

        private void button1_Click(object sender, EventArgs e)
        {
            userService.AddUser(new User
            {
                Username = textBox1.Text,
                Fullname = textBox2.Text,
                Email = textBox3.Text,
            });
            RefreshList();
        }

        private void RefreshList()
        {
            var users = userService.ListUsers();
            listBox1.DataSource = users;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDbIfNotExist();
            //AddRole("Admin");
            //AddRole("Investigator");
            //AddRole("Auditor");
            //AddRole("Audit Manager");
            //AddRole("Dev");
            //AddRole("Tester");

            PopulateRolesListBox();
        }

        private void PopulateRolesListBox()
        {
            RoleService roleService = new RoleService();
            var roles = roleService.ListRoles();
            listBoxRoles.DataSource = roles;
            listBoxRoles.DisplayMember = "Name"; // Assuming Role has a property called Name
        }
    }
}
