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
            listBoxRoles = new ListBox();
            usersListBox = new ListBox();
            emailTextBox = new TextBox();
            aliasTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button4 = new Button();
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
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBoxRoles);
            tabPage1.Controls.Add(usersListBox);
            tabPage1.Controls.Add(emailTextBox);
            tabPage1.Controls.Add(aliasTextBox);
            tabPage1.Controls.Add(fullnameTextBox);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1457, 635);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
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
            // aliasTextBox
            // 
            aliasTextBox.Location = new Point(250, 57);
            aliasTextBox.Name = "aliasTextBox";
            aliasTextBox.Size = new Size(155, 23);
            aliasTextBox.TabIndex = 3;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(250, 86);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(155, 23);
            fullnameTextBox.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(331, 144);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(250, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(685, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 89);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 60);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Alias";
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
            // textBox1
            // 
            textBox1.Location = new Point(507, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(507, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 32);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Alias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 59);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 15;
            label6.Text = "Role";
            // 
            // button3
            // 
            button3.Location = new Point(588, 85);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(507, 85);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(726, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(692, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(155, 139);
            listBox1.TabIndex = 20;
            // 
            // button4
            // 
            button4.Location = new Point(17, 34);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "List";
            button4.UseVisualStyleBackColor = true;
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
        private TextBox aliasTextBox;
        private TextBox fullnameTextBox;
        private Button button2;
        private Button button1;
        private TabPage tabPage2;
        private ListBox usersListBox;
        private ListBox listBoxRoles;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button5;
        private Button button4;
    }
}
