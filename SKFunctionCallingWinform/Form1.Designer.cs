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
            richTextBox1 = new RichTextBox();
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
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(910, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(705, 536);
            richTextBox1.TabIndex = 43;
            richTextBox1.Text = "";
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sendButton.Location = new Point(1498, 581);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(117, 84);
            sendButton.TabIndex = 42;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_ClickAsync;
            // 
            // promptTextBox
            // 
            promptTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            promptTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            promptTextBox.Location = new Point(910, 580);
            promptTextBox.Multiline = true;
            promptTextBox.Name = "promptTextBox";
            promptTextBox.Size = new Size(582, 84);
            promptTextBox.TabIndex = 41;
            // 
            // chatListBox
            // 
            chatListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatListBox.Font = new Font("Segoe UI", 12F);
            chatListBox.FormattingEnabled = true;
            chatListBox.ItemHeight = 21;
            chatListBox.Location = new Point(652, 60);
            chatListBox.Name = "chatListBox";
            chatListBox.Size = new Size(200, 109);
            chatListBox.TabIndex = 40;
            // 
            // getUserButton
            // 
            getUserButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            getUserButton.Location = new Point(35, 250);
            getUserButton.Name = "getUserButton";
            getUserButton.Size = new Size(94, 34);
            getUserButton.TabIndex = 23;
            getUserButton.Text = "Get User ";
            getUserButton.UseVisualStyleBackColor = true;
            getUserButton.Click += getUserButton_Click;
            // 
            // usersInRoleListBox
            // 
            usersInRoleListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usersInRoleListBox.FormattingEnabled = true;
            usersInRoleListBox.ItemHeight = 21;
            usersInRoleListBox.Location = new Point(310, 444);
            usersInRoleListBox.Name = "usersInRoleListBox";
            usersInRoleListBox.Size = new Size(172, 130);
            usersInRoleListBox.TabIndex = 38;
            // 
            // roleCombo
            // 
            roleCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(310, 409);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(172, 29);
            roleCombo.TabIndex = 37;
            roleCombo.SelectedIndexChanged += roleCombo_SelectedIndexChanged;
            // 
            // remnoveUserRoleButton
            // 
            remnoveUserRoleButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            remnoveUserRoleButton.Location = new Point(388, 581);
            remnoveUserRoleButton.Name = "remnoveUserRoleButton";
            remnoveUserRoleButton.Size = new Size(94, 34);
            remnoveUserRoleButton.TabIndex = 39;
            remnoveUserRoleButton.Text = "Remove";
            remnoveUserRoleButton.UseVisualStyleBackColor = true;
            remnoveUserRoleButton.Click += remnoveUserRoleButton_Click;
            // 
            // addUserRoleButton
            // 
            addUserRoleButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addUserRoleButton.Location = new Point(125, 479);
            addUserRoleButton.Name = "addUserRoleButton";
            addUserRoleButton.Size = new Size(94, 34);
            addUserRoleButton.TabIndex = 36;
            addUserRoleButton.Text = "Add";
            addUserRoleButton.UseVisualStyleBackColor = true;
            addUserRoleButton.Click += addUserRoleButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(56, 439);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 34;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(26, 412);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 32;
            label5.Text = "Username";
            // 
            // userRoleUsernameTextBox
            // 
            userRoleUsernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userRoleUsernameTextBox.Location = new Point(125, 409);
            userRoleUsernameTextBox.Name = "userRoleUsernameTextBox";
            userRoleUsernameTextBox.Size = new Size(156, 29);
            userRoleUsernameTextBox.TabIndex = 33;
            // 
            // userRoleRoleTextBox
            // 
            userRoleRoleTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userRoleRoleTextBox.Location = new Point(125, 444);
            userRoleRoleTextBox.Name = "userRoleRoleTextBox";
            userRoleRoleTextBox.Size = new Size(156, 29);
            userRoleRoleTextBox.TabIndex = 35;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            emailTextBox.Location = new Point(330, 142);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(231, 29);
            emailTextBox.TabIndex = 30;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usernameTextBox.Location = new Point(330, 72);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(231, 29);
            usernameTextBox.TabIndex = 26;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            fullnameTextBox.Location = new Point(330, 107);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(231, 29);
            fullnameTextBox.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(276, 145);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(241, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 25;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(249, 110);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 27;
            label1.Text = "Fullname";
            // 
            // usersListBox
            // 
            usersListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 21;
            usersListBox.Location = new Point(35, 72);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(194, 172);
            usersListBox.TabIndex = 22;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            removeUsersButton.Location = new Point(135, 250);
            removeUsersButton.Name = "removeUsersButton";
            removeUsersButton.Size = new Size(94, 34);
            removeUsersButton.TabIndex = 24;
            removeUsersButton.Text = "Remove";
            removeUsersButton.UseVisualStyleBackColor = true;
            removeUsersButton.Click += removeUsersButton_Click;
            // 
            // addUsersButton
            // 
            addUsersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addUsersButton.Location = new Point(330, 177);
            addUsersButton.Name = "addUsersButton";
            addUsersButton.Size = new Size(94, 34);
            addUsersButton.TabIndex = 31;
            addUsersButton.Text = "Add";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 703);
            Controls.Add(richTextBox1);
            Controls.Add(sendButton);
            Controls.Add(promptTextBox);
            Controls.Add(chatListBox);
            Controls.Add(getUserButton);
            Controls.Add(usersInRoleListBox);
            Controls.Add(roleCombo);
            Controls.Add(remnoveUserRoleButton);
            Controls.Add(addUserRoleButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(userRoleUsernameTextBox);
            Controls.Add(userRoleRoleTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(fullnameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usersListBox);
            Controls.Add(removeUsersButton);
            Controls.Add(addUsersButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button sendButton;
        private TextBox promptTextBox;
        private ListBox chatListBox;
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
    }
}
