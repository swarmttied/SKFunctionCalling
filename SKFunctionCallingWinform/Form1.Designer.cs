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
            sendButton = new Button();
            promptTextBox = new TextBox();
            chatListBox = new ListBox();
            getUserButton = new Button();
            usersInRoleListBox = new ListBox();
            roleCombo = new ComboBox();
            remnoveUserRoleButton = new Button();
            addUserRoleButton = new Button();
            label6 = new Label();
            label5 = new Label();
            userRoleUsernameTextBox = new TextBox();
            userRoleRoleTextBox = new TextBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            usersListBox = new ListBox();
            removeUsersButton = new Button();
            addUsersButton = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(sendButton);
            tabPage1.Controls.Add(promptTextBox);
            tabPage1.Controls.Add(chatListBox);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1608, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Location = new Point(1485, 292);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(117, 84);
            sendButton.TabIndex = 20;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_ClickAsync;
            // 
            // promptTextBox
            // 
            promptTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            promptTextBox.Font = new Font("Segoe UI", 12F);
            promptTextBox.Location = new Point(897, 292);
            promptTextBox.Multiline = true;
            promptTextBox.Name = "promptTextBox";
            promptTextBox.Size = new Size(582, 84);
            promptTextBox.TabIndex = 19;
            // 
            // chatListBox
            // 
            chatListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatListBox.Font = new Font("Segoe UI", 12F);
            chatListBox.FormattingEnabled = true;
            chatListBox.ItemHeight = 21;
            chatListBox.Location = new Point(897, 21);
            chatListBox.Name = "chatListBox";
            chatListBox.Size = new Size(705, 256);
            chatListBox.TabIndex = 18;
            // 
            // getUserButton
            // 
            getUserButton.Location = new Point(22, 230);
            getUserButton.Name = "getUserButton";
            getUserButton.Size = new Size(75, 23);
            getUserButton.TabIndex = 1;
            getUserButton.Text = "Get User ";
            getUserButton.UseVisualStyleBackColor = true;
            getUserButton.Click += getUserButton_Click;
            // 
            // usersInRoleListBox
            // 
            usersInRoleListBox.FormattingEnabled = true;
            usersInRoleListBox.ItemHeight = 15;
            usersInRoleListBox.Location = new Point(708, 56);
            usersInRoleListBox.Name = "usersInRoleListBox";
            usersInRoleListBox.Size = new Size(155, 139);
            usersInRoleListBox.TabIndex = 16;
            // 
            // roleCombo
            // 
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(708, 24);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(155, 23);
            roleCombo.TabIndex = 15;
            roleCombo.SelectedIndexChanged += roleCombo_SelectedIndexChanged;
            // 
            // remnoveUserRoleButton
            // 
            remnoveUserRoleButton.Location = new Point(788, 201);
            remnoveUserRoleButton.Name = "remnoveUserRoleButton";
            remnoveUserRoleButton.Size = new Size(75, 23);
            remnoveUserRoleButton.TabIndex = 17;
            remnoveUserRoleButton.Text = "Remove";
            remnoveUserRoleButton.UseVisualStyleBackColor = true;
            remnoveUserRoleButton.Click += remnoveUserRoleButton_Click;
            // 
            // addUserRoleButton
            // 
            addUserRoleButton.Location = new Point(523, 85);
            addUserRoleButton.Name = "addUserRoleButton";
            addUserRoleButton.Size = new Size(75, 23);
            addUserRoleButton.TabIndex = 14;
            addUserRoleButton.Text = "Add";
            addUserRoleButton.UseVisualStyleBackColor = true;
            addUserRoleButton.Click += addUserRoleButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 59);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 32);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // userRoleUsernameTextBox
            // 
            userRoleUsernameTextBox.Location = new Point(523, 24);
            userRoleUsernameTextBox.Name = "userRoleUsernameTextBox";
            userRoleUsernameTextBox.Size = new Size(156, 23);
            userRoleUsernameTextBox.TabIndex = 11;
            // 
            // userRoleRoleTextBox
            // 
            userRoleRoleTextBox.Location = new Point(523, 56);
            userRoleRoleTextBox.Name = "userRoleRoleTextBox";
            userRoleRoleTextBox.Size = new Size(156, 23);
            userRoleRoleTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(255, 96);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(155, 23);
            emailTextBox.TabIndex = 8;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(255, 38);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(155, 23);
            usernameTextBox.TabIndex = 4;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(255, 67);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(155, 23);
            fullnameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 99);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 41);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 70);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Fullname";
            // 
            // usersListBox
            // 
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 15;
            usersListBox.Location = new Point(22, 40);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(157, 184);
            usersListBox.TabIndex = 0;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Location = new Point(104, 230);
            removeUsersButton.Name = "removeUsersButton";
            removeUsersButton.Size = new Size(75, 23);
            removeUsersButton.TabIndex = 2;
            removeUsersButton.Text = "Remove";
            removeUsersButton.UseVisualStyleBackColor = true;
            removeUsersButton.Click += removeUsersButton_Click;
            // 
            // addUsersButton
            // 
            addUsersButton.Location = new Point(255, 125);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(75, 23);
            addUsersButton.TabIndex = 9;
            addUsersButton.Text = "Add";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1616, 440);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1608, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 484);
            Controls.Add(tabControl1);
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
        private Button sendButton;
        private TextBox promptTextBox;
        private ListBox chatListBox;
    }
}
