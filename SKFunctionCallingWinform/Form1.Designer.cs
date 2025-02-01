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
            getUserButton = new Button();
            usersInRoleListBox = new ListBox();
            roleCombo = new ComboBox();
            remnoveUserRoleButton = new Button();
            addUserRoleButton = new Button();
            label5 = new Label();
            userRoleUsernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            usersListBox = new ListBox();
            removeUsersButton = new Button();
            addUsersButton = new Button();
            listUsersButton = new Button();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            calledFunctionsListBox = new ListBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(703, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(711, 602);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sendButton.Location = new Point(1297, 668);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(117, 84);
            sendButton.TabIndex = 25;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_ClickAsync;
            // 
            // promptTextBox
            // 
            promptTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            promptTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            promptTextBox.Location = new Point(703, 667);
            promptTextBox.Multiline = true;
            promptTextBox.Name = "promptTextBox";
            promptTextBox.Size = new Size(588, 84);
            promptTextBox.TabIndex = 24;
            promptTextBox.Enter += promptTextBox_Enter;
            // 
            // getUserButton
            // 
            getUserButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            getUserButton.Location = new Point(35, 208);
            getUserButton.Name = "getUserButton";
            getUserButton.Size = new Size(94, 34);
            getUserButton.TabIndex = 2;
            getUserButton.Text = "Get User ";
            getUserButton.UseVisualStyleBackColor = true;
            getUserButton.Click += getUserButton_Click;
            // 
            // usersInRoleListBox
            // 
            usersInRoleListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usersInRoleListBox.FormattingEnabled = true;
            usersInRoleListBox.ItemHeight = 21;
            usersInRoleListBox.Location = new Point(320, 354);
            usersInRoleListBox.Name = "usersInRoleListBox";
            usersInRoleListBox.Size = new Size(172, 130);
            usersInRoleListBox.TabIndex = 20;
            usersInRoleListBox.Enter += usersInRoleListBox_Enter;
            // 
            // roleCombo
            // 
            roleCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(320, 319);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(172, 29);
            roleCombo.TabIndex = 19;
            roleCombo.SelectedIndexChanged += roleCombo_SelectedIndexChanged;
            // 
            // remnoveUserRoleButton
            // 
            remnoveUserRoleButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            remnoveUserRoleButton.Location = new Point(398, 491);
            remnoveUserRoleButton.Name = "remnoveUserRoleButton";
            remnoveUserRoleButton.Size = new Size(94, 34);
            remnoveUserRoleButton.TabIndex = 21;
            remnoveUserRoleButton.Text = "Remove";
            remnoveUserRoleButton.UseVisualStyleBackColor = true;
            remnoveUserRoleButton.Click += remnoveUserRoleButton_Click;
            // 
            // addUserRoleButton
            // 
            addUserRoleButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addUserRoleButton.Location = new Point(135, 354);
            addUserRoleButton.Name = "addUserRoleButton";
            addUserRoleButton.Size = new Size(94, 34);
            addUserRoleButton.TabIndex = 17;
            addUserRoleButton.Text = "Add";
            addUserRoleButton.UseVisualStyleBackColor = true;
            addUserRoleButton.Click += addUserRoleButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(36, 322);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 13;
            label5.Text = "Username";
            // 
            // userRoleUsernameTextBox
            // 
            userRoleUsernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userRoleUsernameTextBox.Location = new Point(135, 319);
            userRoleUsernameTextBox.Name = "userRoleUsernameTextBox";
            userRoleUsernameTextBox.Size = new Size(156, 29);
            userRoleUsernameTextBox.TabIndex = 14;
            userRoleUsernameTextBox.Enter += userRoleUsernameTextBox_Enter;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            emailTextBox.Location = new Point(330, 142);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(231, 29);
            emailTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usernameTextBox.Location = new Point(330, 72);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(231, 29);
            usernameTextBox.TabIndex = 6;
            usernameTextBox.Enter += usernameTextBox_Enter;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            fullnameTextBox.Location = new Point(330, 107);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(231, 29);
            fullnameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(276, 145);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(241, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(249, 110);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 7;
            label1.Text = "Fullname";
            // 
            // usersListBox
            // 
            usersListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 21;
            usersListBox.Location = new Point(35, 72);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(194, 130);
            usersListBox.TabIndex = 1;
            usersListBox.Enter += usersListBox_Enter;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            removeUsersButton.Location = new Point(135, 208);
            removeUsersButton.Name = "removeUsersButton";
            removeUsersButton.Size = new Size(94, 34);
            removeUsersButton.TabIndex = 3;
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
            addUsersButton.TabIndex = 11;
            addUsersButton.Text = "Add";
            addUsersButton.UseVisualStyleBackColor = true;
            addUsersButton.Click += addUsersButton_Click;
            // 
            // listUsersButton
            // 
            listUsersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            listUsersButton.Location = new Point(35, 32);
            listUsersButton.Name = "listUsersButton";
            listUsersButton.Size = new Size(94, 34);
            listUsersButton.TabIndex = 0;
            listUsersButton.Text = "&List";
            listUsersButton.UseVisualStyleBackColor = true;
            listUsersButton.Click += listUsersButton_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(249, 36);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 4;
            label4.Text = "&Users";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 278);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 12;
            label7.Text = "Users &Roles";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(320, 278);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 18;
            label8.Text = "R&oles";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(703, 643);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 23;
            label9.Text = "Pro&mpt";
            // 
            // calledFunctionsListBox
            // 
            calledFunctionsListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            calledFunctionsListBox.FormattingEnabled = true;
            calledFunctionsListBox.ItemHeight = 21;
            calledFunctionsListBox.Location = new Point(35, 579);
            calledFunctionsListBox.Name = "calledFunctionsListBox";
            calledFunctionsListBox.Size = new Size(274, 172);
            calledFunctionsListBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 551);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 27;
            label6.Text = "Called Functions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 790);
            Controls.Add(label6);
            Controls.Add(calledFunctionsListBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(listUsersButton);
            Controls.Add(richTextBox1);
            Controls.Add(sendButton);
            Controls.Add(promptTextBox);
            Controls.Add(getUserButton);
            Controls.Add(usersInRoleListBox);
            Controls.Add(roleCombo);
            Controls.Add(remnoveUserRoleButton);
            Controls.Add(addUserRoleButton);
            Controls.Add(label5);
            Controls.Add(userRoleUsernameTextBox);
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
            Text = "Function Calling";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button sendButton;
        private TextBox promptTextBox;
        private Button getUserButton;
        private ListBox usersInRoleListBox;
        private ComboBox roleCombo;
        private Button remnoveUserRoleButton;
        private Button addUserRoleButton;
        private Label label5;
        private TextBox userRoleUsernameTextBox;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private TextBox fullnameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox usersListBox;
        private Button removeUsersButton;
        private Button addUsersButton;
        private Button listUsersButton;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox calledFunctionsListBox;
        private Label label6;
    }
}
