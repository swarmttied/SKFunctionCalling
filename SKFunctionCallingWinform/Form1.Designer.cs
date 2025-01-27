namespace SKFunctionCallingWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            getUserButton = new Button();
            listUsersButton = new Button();
            usersInRoleListBox = new ListBox();
            roleCombo = new ComboBox();
            remnoveUserRoleButton = new Button();
            addUserRoleButton = new Button();
            label6 = new Label();
            label5 = new Label();
            userRoleUsernameTextBox = new TextBox();
            userRoleRoleTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxRoles = new ListBox();
            usersListBox = new ListBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            removeUsersButton = new Button();
            addUsersButton = new Button();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1465, 663);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(getUserButton);
            tabPage1.Controls.Add(listUsersButton);
            tabPage1.Controls.Add(usersInRoleListBox);
            tabPage1.Controls.Add(roleCombo);
            tabPage1.Controls.Add(remnoveUserRoleButton);
            tabPage1.Controls.Add(addUserRoleButton);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(userRoleUsernameTextBox);
            tabPage1.Controls.Add(userRoleRoleTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBoxRoles);
            tabPage1.Controls.Add(usersListBox);
            tabPage1.Controls.Add(emailTextBox);
            tabPage1.Controls.Add(usernameTextBox);
            tabPage1.Controls.Add(fullnameTextBox);
            tabPage1.Controls.Add(removeUsersButton);
            tabPage1.Controls.Add(addUsersButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1457, 635);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // getUserButton
            // 
            getUserButton.Location = new Point(17, 249);
            getUserButton.Name = "getUserButton";
            getUserButton.Size = new Size(75, 23);
            getUserButton.TabIndex = 22;
            getUserButton.Text = "Get User ";
            getUserButton.UseVisualStyleBackColor = true;
            getUserButton.Click += getUserButton_Click;
            // 
            // listUsersButton
            // 
            listUsersButton.Location = new Point(17, 34);
            listUsersButton.Name = "listUsersButton";
            listUsersButton.Size = new Size(75, 23);
            listUsersButton.TabIndex = 21;
            listUsersButton.Text = "List";
            listUsersButton.UseVisualStyleBackColor = true;
            listUsersButton.Click += listUsersButton_Click;
            // 
            // usersInRoleListBox
            // 
            usersInRoleListBox.FormattingEnabled = true;
            usersInRoleListBox.ItemHeight = 15;
            usersInRoleListBox.Location = new Point(694, 84);
            usersInRoleListBox.Name = "usersInRoleListBox";
            usersInRoleListBox.Size = new Size(155, 139);
            usersInRoleListBox.TabIndex = 20;
            // 
            // roleCombo
            // 
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(694, 52);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(155, 23);
            roleCombo.TabIndex = 19;
            roleCombo.SelectedIndexChanged += roleCombo_SelectedIndexChanged;
            // 
            // remnoveUserRoleButton
            // 
            remnoveUserRoleButton.Location = new Point(774, 229);
            remnoveUserRoleButton.Name = "remnoveUserRoleButton";
            remnoveUserRoleButton.Size = new Size(75, 23);
            remnoveUserRoleButton.TabIndex = 18;
            remnoveUserRoleButton.Text = "Remove";
            remnoveUserRoleButton.UseVisualStyleBackColor = true;
            remnoveUserRoleButton.Click += remnoveUserRoleButton_Click;
            // 
            // addUserRoleButton
            // 
            addUserRoleButton.Location = new Point(509, 113);
            addUserRoleButton.Name = "addUserRoleButton";
            addUserRoleButton.Size = new Size(75, 23);
            addUserRoleButton.TabIndex = 17;
            addUserRoleButton.Text = "Add";
            addUserRoleButton.UseVisualStyleBackColor = true;
            addUserRoleButton.Click += addUserRoleButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 87);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 15;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 60);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "Username";
            // 
            // userRoleUsernameTextBox
            // 
            userRoleUsernameTextBox.Location = new Point(509, 52);
            userRoleUsernameTextBox.Name = "userRoleUsernameTextBox";
            userRoleUsernameTextBox.Size = new Size(156, 23);
            userRoleUsernameTextBox.TabIndex = 13;
            // 
            // userRoleRoleTextBox
            // 
            userRoleRoleTextBox.Location = new Point(509, 84);
            userRoleRoleTextBox.Name = "userRoleRoleTextBox";
            userRoleRoleTextBox.Size = new Size(156, 23);
            userRoleRoleTextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 118);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 7;
            label1.Text = "Fullname";
            // 
            // listBoxRoles
            // 
            listBoxRoles.FormattingEnabled = true;
            listBoxRoles.ItemHeight = 15;
            listBoxRoles.Location = new Point(943, 56);
            listBoxRoles.Name = "listBoxRoles";
            listBoxRoles.Size = new Size(155, 94);
            listBoxRoles.TabIndex = 6;
            // 
            // usersListBox
            // 
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 15;
            usersListBox.Location = new Point(17, 59);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(157, 184);
            usersListBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(250, 115);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(155, 23);
            emailTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(250, 57);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(155, 23);
            usernameTextBox.TabIndex = 3;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(250, 86);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(155, 23);
            fullnameTextBox.TabIndex = 2;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Location = new Point(99, 249);
            removeUsersButton.Name = "removeUsersButton";
            removeUsersButton.Size = new Size(75, 23);
            removeUsersButton.TabIndex = 1;
            removeUsersButton.Text = "Remove";
            removeUsersButton.UseVisualStyleBackColor = true;
            removeUsersButton.Click += removeUsersButton_Click;
            // 
            // addUsersButton
            // 
            addUsersButton.Location = new Point(250, 144);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(75, 23);
            addUsersButton.TabIndex = 0;
            addUsersButton.Text = "Add";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1457, 635);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1690, 756);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private TextBox fullnameTextBox;
        private Button removeUsersButton;
        private Button addUsersButton;
        private TabPage tabPage2;
        private ListBox usersListBox;
        private ListBox listBoxRoles;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox userRoleUsernameTextBox;
        private ListBox usersInRoleListBox;
        private ComboBox roleCombo;
        private Button remnoveUserRoleButton;
        private Button listUsersButton;
        private Button getUserButton;
        private Button addUserRoleButton;
        private TextBox userRoleRoleTextBox;
    }
}
