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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label10 = new Label();
            queryGenRTB = new RichTextBox();
            queryGenSendButton = new Button();
            queryGenPromptTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            clearButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(774, 665);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += RichTextBox_TextChanged;
            // 
            // sendButton
            // 
            sendButton.Dock = DockStyle.Fill;
            sendButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sendButton.Location = new Point(654, 3);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(117, 88);
            sendButton.TabIndex = 25;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_ClickAsync;
            // 
            // promptTextBox
            // 
            promptTextBox.Dock = DockStyle.Fill;
            promptTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            promptTextBox.Location = new Point(3, 3);
            promptTextBox.Multiline = true;
            promptTextBox.Name = "promptTextBox";
            promptTextBox.Size = new Size(645, 88);
            promptTextBox.TabIndex = 24;
            promptTextBox.Enter += promptTextBox_Enter;
            // 
            // getUserButton
            // 
            getUserButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            getUserButton.Location = new Point(12, 188);
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
            usersInRoleListBox.Location = new Point(297, 334);
            usersInRoleListBox.Name = "usersInRoleListBox";
            usersInRoleListBox.Size = new Size(172, 130);
            usersInRoleListBox.TabIndex = 20;
            usersInRoleListBox.Enter += usersInRoleListBox_Enter;
            // 
            // roleCombo
            // 
            roleCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(297, 299);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(172, 29);
            roleCombo.TabIndex = 19;
            roleCombo.SelectedIndexChanged += roleCombo_SelectedIndexChanged;
            // 
            // remnoveUserRoleButton
            // 
            remnoveUserRoleButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            remnoveUserRoleButton.Location = new Point(375, 471);
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
            addUserRoleButton.Location = new Point(112, 334);
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
            label5.Location = new Point(13, 302);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 13;
            label5.Text = "Username";
            // 
            // userRoleUsernameTextBox
            // 
            userRoleUsernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userRoleUsernameTextBox.Location = new Point(112, 299);
            userRoleUsernameTextBox.Name = "userRoleUsernameTextBox";
            userRoleUsernameTextBox.Size = new Size(156, 29);
            userRoleUsernameTextBox.TabIndex = 14;
            userRoleUsernameTextBox.Enter += userRoleUsernameTextBox_Enter;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            emailTextBox.Location = new Point(307, 122);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(231, 29);
            emailTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            usernameTextBox.Location = new Point(307, 52);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(231, 29);
            usernameTextBox.TabIndex = 6;
            usernameTextBox.Enter += usernameTextBox_Enter;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            fullnameTextBox.Location = new Point(307, 87);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(231, 29);
            fullnameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(253, 125);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(218, 55);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(226, 90);
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
            usersListBox.Location = new Point(12, 52);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(194, 130);
            usersListBox.TabIndex = 1;
            usersListBox.Enter += usersListBox_Enter;
            // 
            // removeUsersButton
            // 
            removeUsersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            removeUsersButton.Location = new Point(112, 188);
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
            addUsersButton.Location = new Point(307, 157);
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
            listUsersButton.Location = new Point(12, 12);
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
            label4.Location = new Point(226, 16);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 4;
            label4.Text = "&Users";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 258);
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
            label8.Location = new Point(297, 258);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 18;
            label8.Text = "R&oles";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 671);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 23;
            label9.Text = "Pro&mpt";
            // 
            // calledFunctionsListBox
            // 
            calledFunctionsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            calledFunctionsListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            calledFunctionsListBox.FormattingEnabled = true;
            calledFunctionsListBox.ItemHeight = 21;
            calledFunctionsListBox.Location = new Point(12, 553);
            calledFunctionsListBox.Name = "calledFunctionsListBox";
            calledFunctionsListBox.Size = new Size(274, 235);
            calledFunctionsListBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 525);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 27;
            label6.Text = "Called Functions";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(783, 671);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 29;
            label10.Text = "Pro&mpt";
            // 
            // queryGenRTB
            // 
            queryGenRTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            queryGenRTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            queryGenRTB.Location = new Point(3, 3);
            queryGenRTB.Name = "queryGenRTB";
            queryGenRTB.Size = new Size(768, 469);
            queryGenRTB.TabIndex = 28;
            queryGenRTB.Text = "";
            queryGenRTB.TextChanged += RichTextBox_TextChanged;
            // 
            // queryGenSendButton
            // 
            queryGenSendButton.Dock = DockStyle.Fill;
            queryGenSendButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            queryGenSendButton.Location = new Point(654, 3);
            queryGenSendButton.Name = "queryGenSendButton";
            queryGenSendButton.Size = new Size(117, 88);
            queryGenSendButton.TabIndex = 31;
            queryGenSendButton.Text = "Send";
            queryGenSendButton.UseVisualStyleBackColor = true;
            queryGenSendButton.Click += queryGenSendButton_ClickAsync;
            // 
            // queryGenPromptTextBox
            // 
            queryGenPromptTextBox.Dock = DockStyle.Fill;
            queryGenPromptTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            queryGenPromptTextBox.Location = new Point(3, 3);
            queryGenPromptTextBox.Multiline = true;
            queryGenPromptTextBox.Name = "queryGenPromptTextBox";
            queryGenPromptTextBox.Size = new Size(645, 88);
            queryGenPromptTextBox.TabIndex = 30;
            queryGenPromptTextBox.Enter += queryGenPromptTextBox_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 478);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(768, 184);
            dataGridView1.TabIndex = 32;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            clearButton.Location = new Point(292, 553);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 34);
            clearButton.TabIndex = 33;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Location = new Point(561, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(1560, 792);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(sendButton, 1, 0);
            tableLayoutPanel2.Controls.Add(promptTextBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 695);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(774, 94);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(queryGenPromptTextBox, 0, 0);
            tableLayoutPanel3.Controls.Add(queryGenSendButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(783, 695);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(774, 94);
            tableLayoutPanel3.TabIndex = 30;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel4.Controls.Add(queryGenRTB, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(783, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel4.Size = new Size(774, 665);
            tableLayoutPanel4.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2124, 800);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(clearButton);
            Controls.Add(label6);
            Controls.Add(calledFunctionsListBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(listUsersButton);
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
            MinimumSize = new Size(2140, 839);
            Name = "Form1";
            Text = "Function Calling";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
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
        private Label label10;
        private RichTextBox queryGenRTB;
        private Button queryGenSendButton;
        private TextBox queryGenPromptTextBox;
        private DataGridView dataGridView1;
        private Button clearButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
