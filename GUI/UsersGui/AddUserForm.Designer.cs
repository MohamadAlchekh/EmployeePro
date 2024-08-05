namespace EmployeePro.GUI.UsersGui
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBoxPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFullName = new TextBox();
            label2 = new Label();
            textBoxPhoneNo = new TextBox();
            label11 = new Label();
            label1 = new Label();
            label12 = new Label();
            comboBoxRole = new ComboBox();
            label7 = new Label();
            label13 = new Label();
            checkBoxSecondaryUser = new CheckBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            label10 = new Label();
            textBoxAdress = new TextBox();
            label8 = new Label();
            textBoxEmailAdress = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxPhoneNo);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login information";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(13, 209);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(244, 29);
            textBoxPassword.TabIndex = 3;
            // 
            // label5
            // 
            label5.ForeColor = Color.Red;
            label5.Location = new Point(95, 175);
            label5.Name = "label5";
            label5.Size = new Size(14, 17);
            label5.TabIndex = 7;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 185);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 6;
            label6.Text = "Password :";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(13, 133);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(244, 29);
            textBoxUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.ForeColor = Color.Red;
            label3.Location = new Point(95, 99);
            label3.Name = "label3";
            label3.Size = new Size(14, 17);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 109);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 3;
            label4.Text = "Username :";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(13, 62);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(244, 29);
            textBoxFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.Red;
            label2.Location = new Point(95, 28);
            label2.Name = "label2";
            label2.Size = new Size(14, 17);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.Location = new Point(13, 281);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new Size(244, 29);
            textBoxPhoneNo.TabIndex = 4;
            // 
            // label11
            // 
            label11.ForeColor = Color.Red;
            label11.Location = new Point(133, 247);
            label11.Name = "label11";
            label11.Size = new Size(14, 17);
            label11.TabIndex = 1;
            label11.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 257);
            label12.Name = "label12";
            label12.Size = new Size(128, 21);
            label12.TabIndex = 0;
            label12.Text = "Phone Number :";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Enabled = false;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Manager", "User", "Reader" });
            comboBoxRole.Location = new Point(9, 62);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(244, 29);
            comboBoxRole.TabIndex = 5;
            // 
            // label7
            // 
            label7.ForeColor = Color.Red;
            label7.Location = new Point(88, 28);
            label7.Name = "label7";
            label7.Size = new Size(14, 17);
            label7.TabIndex = 10;
            label7.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 38);
            label13.Name = "label13";
            label13.Size = new Size(87, 21);
            label13.TabIndex = 9;
            label13.Text = "Authority :";
            // 
            // checkBoxSecondaryUser
            // 
            checkBoxSecondaryUser.AutoSize = true;
            checkBoxSecondaryUser.Location = new Point(12, 250);
            checkBoxSecondaryUser.Name = "checkBoxSecondaryUser";
            checkBoxSecondaryUser.Size = new Size(191, 25);
            checkBoxSecondaryUser.TabIndex = 8;
            checkBoxSecondaryUser.Text = "Is the user secondary?";
            checkBoxSecondaryUser.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 29);
            comboBox1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxRole);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(checkBoxSecondaryUser);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBoxAdress);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxEmailAdress);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(310, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 371);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other information";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(12, 319);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(241, 47);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "     Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 109);
            label10.Name = "label10";
            label10.Size = new Size(120, 21);
            label10.TabIndex = 11;
            label10.Text = "Email Address :";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(9, 209);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(244, 29);
            textBoxAdress.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 185);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 6;
            label8.Text = "Address :";
            // 
            // textBoxEmailAdress
            // 
            textBoxEmailAdress.Location = new Point(9, 133);
            textBoxEmailAdress.Name = "textBoxEmailAdress";
            textBoxEmailAdress.Size = new Size(244, 29);
            textBoxEmailAdress.TabIndex = 6;
            // 
            // label9
            // 
            label9.ForeColor = Color.Red;
            label9.Location = new Point(123, 99);
            label9.Name = "label9";
            label9.Size = new Size(14, 17);
            label9.TabIndex = 4;
            label9.Text = "*";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(642, 116);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Authorizations";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Controls.Add(checkBox3);
            flowLayoutPanel1.Controls.Add(checkBox4);
            flowLayoutPanel1.Controls.Add(checkBox5);
            flowLayoutPanel1.Controls.Add(checkBox6);
            flowLayoutPanel1.Controls.Add(checkBox7);
            flowLayoutPanel1.Controls.Add(checkBox8);
            flowLayoutPanel1.Controls.Add(checkBox11);
            flowLayoutPanel1.Controls.Add(checkBox9);
            flowLayoutPanel1.Controls.Add(checkBox10);
            flowLayoutPanel1.Controls.Add(checkBox12);
            flowLayoutPanel1.Controls.Add(checkBox13);
            flowLayoutPanel1.Controls.Add(checkBox14);
            flowLayoutPanel1.Controls.Add(checkBox15);
            flowLayoutPanel1.Controls.Add(checkBox16);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(636, 88);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Add";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 11.25F);
            checkBox3.Location = new Point(65, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 24);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Delete";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 11.25F);
            checkBox4.Location = new Point(143, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(54, 24);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Edit";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 11.25F);
            checkBox5.Location = new Point(203, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(71, 24);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "Export";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 11.25F);
            checkBox6.Location = new Point(280, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(58, 24);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "Print";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 11.25F);
            checkBox7.Location = new Point(344, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(72, 24);
            checkBox7.TabIndex = 15;
            checkBox7.Text = "Search";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 11.25F);
            checkBox8.Location = new Point(422, 3);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(157, 24);
            checkBox8.TabIndex = 16;
            checkBox8.Text = "Home page search ";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Font = new Font("Segoe UI", 11.25F);
            checkBox11.Location = new Point(3, 33);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(61, 24);
            checkBox11.TabIndex = 17;
            checkBox11.Text = "Main";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Segoe UI", 11.25F);
            checkBox9.Location = new Point(70, 33);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(105, 24);
            checkBox9.TabIndex = 18;
            checkBox9.Text = "Salary scale";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Font = new Font("Segoe UI", 11.25F);
            checkBox10.Location = new Point(181, 33);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(100, 24);
            checkBox10.TabIndex = 19;
            checkBox10.Text = "Employees";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Font = new Font("Segoe UI", 11.25F);
            checkBox12.Location = new Point(287, 33);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(63, 24);
            checkBox12.TabIndex = 20;
            checkBox12.Text = "Users";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Font = new Font("Segoe UI", 11.25F);
            checkBox13.Location = new Point(356, 33);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(79, 24);
            checkBox13.TabIndex = 21;
            checkBox13.Text = "Reports";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Font = new Font("Segoe UI", 11.25F);
            checkBox14.Location = new Point(441, 33);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(81, 24);
            checkBox14.TabIndex = 22;
            checkBox14.Text = "Settings";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Font = new Font("Segoe UI", 11.25F);
            checkBox15.Location = new Point(3, 63);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(118, 24);
            checkBox15.TabIndex = 23;
            checkBox15.Text = "About system";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Font = new Font("Segoe UI", 11.25F);
            checkBox16.Location = new Point(127, 63);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(60, 24);
            checkBox16.TabIndex = 24;
            checkBox16.Text = "Help";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 509);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit USER";
            Load += AddUserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxFullName;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label6;
        private CheckBox checkBoxSecondaryUser;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private TextBox textBoxAdress;
        private Label label8;
        private TextBox textBoxEmailAdress;
        private Label label9;
        private TextBox textBoxPhoneNo;
        private Label label11;
        private Label label12;
        private Label label10;
        private GroupBox groupBox3;
        private Button buttonSave;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private Label label7;
        private Label label13;
        private ComboBox comboBoxRole;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
    }
}