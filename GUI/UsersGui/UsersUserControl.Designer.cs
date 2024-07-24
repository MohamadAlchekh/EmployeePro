namespace EmployeePro.GUI.UsersGui
{
    partial class UsersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonHome = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanelNavBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonHome);
            flowLayoutPanelNavBar.Controls.Add(button1);
            flowLayoutPanelNavBar.Controls.Add(button2);
            flowLayoutPanelNavBar.Controls.Add(button3);
            flowLayoutPanelNavBar.Controls.Add(panel1);
            flowLayoutPanelNavBar.Dock = DockStyle.Top;
            flowLayoutPanelNavBar.Location = new Point(0, 0);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(3);
            flowLayoutPanelNavBar.RightToLeft = RightToLeft.No;
            flowLayoutPanelNavBar.Size = new Size(885, 61);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Image = Properties.Resources.Plus_1;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(6, 6);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(105, 47);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "      Add";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Edit_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(117, 6);
            button1.Name = "button1";
            button1.Size = new Size(111, 47);
            button1.TabIndex = 2;
            button1.Text = "       Modify";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.Delete_1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(234, 6);
            button2.Name = "button2";
            button2.Size = new Size(105, 47);
            button2.TabIndex = 3;
            button2.Text = "       Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.Microsoft_Excel_2019_1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(345, 6);
            button3.Name = "button3";
            button3.Size = new Size(105, 47);
            button3.TabIndex = 4;
            button3.Text = "       Export";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(456, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 47);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 47);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources.Search_2;
            button4.Location = new Point(210, 0);
            button4.Name = "button4";
            button4.Size = new Size(46, 47);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(885, 473);
            dataGridView1.TabIndex = 2;
            // 
            // UsersUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "UsersUserControl";
            Size = new Size(885, 534);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonHome;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
