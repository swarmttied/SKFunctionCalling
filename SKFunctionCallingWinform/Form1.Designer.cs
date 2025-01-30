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
            tabPage1 = new TabPage();
            addUsersButton = new Button();
            removeUsersButton = new Button();
            fullnameTextBox = new TextBox();
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            usersListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userRoleRoleTextBox = new TextBox();
            userRoleUsernameTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            addUserRoleButton = new Button();
            remnoveUserRoleButton = new Button();
            roleCombo = new ComboBox();
            usersInRoleListBox = new ListBox();
            getUserButton = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(getUserButton);
            tabPage1.Controls.Add(usersInRoleListBox);
            tabPage1.Controls.Add(roleCombo);
            tabPage1.Controls.Add(remnoveUserRoleButton);
            tabPage1.Controls.Add(addUserRoleButton);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(userRoleUsernameTextBox);
            tabPage1.Controls.Add(userRoleRoleTextBox);
            tabPage1.Controls.Add(emailTextBox);
            tabPage1.Controls.Add(usernameTextBox);
            tabPage1.Controls.Add(fullnameTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(usersListBox);
            tabPage1.Controls.Add(removeUsersButton);
            tabPage1.Controls.Add(addUsersButton);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1261, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // addUsersButton
            // 
            addUsersButton.Location = new Point(364, 208);
            addUsersButton.Margin = new Padding(4, 5, 4, 5);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(107, 38);
            addUsersButton.TabIndex = 9;
            addUsersButton.Text = "Add";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Location = new Point(148, 383);
            removeUsersButton.Margin = new Padding(4, 5, 4, 5);
            removeUsersButton.Name = "removeUsersButton";
            removeUsersButton.Size = new Size(107, 38);
            removeUsersButton.TabIndex = 2;
            removeUsersButton.Text = "Remove";
            removeUsersButton.UseVisualStyleBackColor = true;
            removeUsersButton.Click += removeUsersButton_Click;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(364, 111);
            fullnameTextBox.Margin = new Padding(4, 5, 4, 5);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(220, 31);
            fullnameTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(364, 63);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(220, 31);
            usernameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(364, 160);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(220, 31);
            emailTextBox.TabIndex = 8;
            // 
            // usersListBox
            // 
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 25;
            usersListBox.Location = new Point(31, 66);
            usersListBox.Margin = new Padding(4, 5, 4, 5);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(223, 304);
            usersListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 5;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // userRoleRoleTextBox
            // 
            userRoleRoleTextBox.Location = new Point(734, 108);
            userRoleRoleTextBox.Margin = new Padding(4, 5, 4, 5);
            userRoleRoleTextBox.Name = "userRoleRoleTextBox";
            userRoleRoleTextBox.Size = new Size(221, 31);
            userRoleRoleTextBox.TabIndex = 13;
            // 
            // userRoleUsernameTextBox
            // 
            userRoleUsernameTextBox.Location = new Point(734, 55);
            userRoleUsernameTextBox.Margin = new Padding(4, 5, 4, 5);
            userRoleUsernameTextBox.Name = "userRoleUsernameTextBox";
            userRoleUsernameTextBox.Size = new Size(221, 31);
            userRoleUsernameTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 68);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(683, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // addUserRoleButton
            // 
            addUserRoleButton.Location = new Point(734, 156);
            addUserRoleButton.Margin = new Padding(4, 5, 4, 5);
            addUserRoleButton.Name = "addUserRoleButton";
            addUserRoleButton.Size = new Size(107, 38);
            addUserRoleButton.TabIndex = 14;
            addUserRoleButton.Text = "Add";
            addUserRoleButton.UseVisualStyleBackColor = true;
            addUserRoleButton.Click += addUserRoleButton_Click;
            // 
            // remnoveUserRoleButton
            // 
            remnoveUserRoleButton.Location = new Point(1113, 350);
            remnoveUserRoleButton.Margin = new Padding(4, 5, 4, 5);
            remnoveUserRoleButton.Name = "remnoveUserRoleButton";
            remnoveUserRoleButton.Size = new Size(107, 38);
            remnoveUserRoleButton.TabIndex = 17;
            remnoveUserRoleButton.Text = "Remove";
            remnoveUserRoleButton.UseVisualStyleBackColor = true;
            remnoveUserRoleButton.Click += remnoveUserRoleButton_Click;
            // 
            // roleCombo
            // 
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(998, 55);
            roleCombo.Margin = new Padding(4, 5, 4, 5);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(220, 33);
            roleCombo.TabIndex = 15;
            roleCombo.SelectedIndexChanged += roleCombo_SelectedIndexChanged;
            // 
            // usersInRoleListBox
            // 
            usersInRoleListBox.FormattingEnabled = true;
            usersInRoleListBox.ItemHeight = 25;
            usersInRoleListBox.Location = new Point(998, 108);
            usersInRoleListBox.Margin = new Padding(4, 5, 4, 5);
            usersInRoleListBox.Name = "usersInRoleListBox";
            usersInRoleListBox.Size = new Size(220, 229);
            usersInRoleListBox.TabIndex = 16;
            // 
            // getUserButton
            // 
            getUserButton.Location = new Point(31, 383);
            getUserButton.Margin = new Padding(4, 5, 4, 5);
            getUserButton.Name = "getUserButton";
            getUserButton.Size = new Size(107, 38);
            getUserButton.TabIndex = 1;
            getUserButton.Text = "Get User ";
            getUserButton.UseVisualStyleBackColor = true;
            getUserButton.Click += getUserButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(17, 40);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1269, 535);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1261, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 609);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private Button getUserButton;
        private ListBox usersInRoleListBox;
        private ComboBox roleCombo;
        private Button remnoveUserRoleButton;
        private Button addUserRoleButton;
        private Label label6;
        private Label label5;
        private TextBox userRoleUsernameTextBox;
        private TextBox userRoleRoleTextBox;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private TextBox fullnameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox usersListBox;
        private Button removeUsersButton;
        private Button addUsersButton;
        private TabControl tabControl1;
        private TabPage tabPage2;
    }
}
