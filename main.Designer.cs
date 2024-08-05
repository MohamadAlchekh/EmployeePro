namespace EmployeePro
{
    partial class main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonSalaryScale = new Button();
            buttonEmployees = new Button();
            buttonUsers = new Button();
            buttonReports = new Button();
            buttonSettings = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            toolTip1 = new ToolTip(components);
            flowLayoutPanelNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonHome);
            flowLayoutPanelNavBar.Controls.Add(buttonSalaryScale);
            flowLayoutPanelNavBar.Controls.Add(buttonEmployees);
            flowLayoutPanelNavBar.Controls.Add(buttonUsers);
            flowLayoutPanelNavBar.Controls.Add(buttonReports);
            flowLayoutPanelNavBar.Controls.Add(buttonSettings);
            flowLayoutPanelNavBar.Controls.Add(buttonHelp);
            flowLayoutPanelNavBar.Controls.Add(buttonAbout);
            flowLayoutPanelNavBar.Dock = DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new Point(0, 434);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(3);
            flowLayoutPanelNavBar.Size = new Size(869, 61);
            flowLayoutPanelNavBar.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Image = Properties.Resources.Home_4;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(8, 8);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(131, 47);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "    Home";
            toolTip1.SetToolTip(buttonHome, "Main Page\r\n");
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonSalaryScale
            // 
            buttonSalaryScale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalaryScale.Image = Properties.Resources.Stack_of_Money;
            buttonSalaryScale.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalaryScale.Location = new Point(149, 8);
            buttonSalaryScale.Margin = new Padding(5);
            buttonSalaryScale.Name = "buttonSalaryScale";
            buttonSalaryScale.Size = new Size(131, 47);
            buttonSalaryScale.TabIndex = 2;
            buttonSalaryScale.Text = "      Salary Scale";
            buttonSalaryScale.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonSalaryScale, "View Salary Details");
            buttonSalaryScale.UseVisualStyleBackColor = true;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEmployees.Image = Properties.Resources.Collaborator_Male;
            buttonEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmployees.Location = new Point(290, 8);
            buttonEmployees.Margin = new Padding(5);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(131, 47);
            buttonEmployees.TabIndex = 3;
            buttonEmployees.Text = "  Employees";
            buttonEmployees.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonEmployees, "Manage Employees");
            buttonEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUsers.Image = Properties.Resources.Collaborator_Male_1;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(431, 8);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(131, 47);
            buttonUsers.TabIndex = 4;
            buttonUsers.Text = "      Users ";
            toolTip1.SetToolTip(buttonUsers, "Manage Users");
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonReports
            // 
            buttonReports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReports.Image = Properties.Resources.Graph_Report;
            buttonReports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReports.Location = new Point(572, 8);
            buttonReports.Margin = new Padding(5);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(131, 47);
            buttonReports.TabIndex = 5;
            buttonReports.Text = "     Reports";
            toolTip1.SetToolTip(buttonReports, "Generate And View Reports");
            buttonReports.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSettings.Image = Properties.Resources.Settings;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(713, 8);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(131, 47);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "     Settings";
            toolTip1.SetToolTip(buttonSettings, "View Settings");
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHelp.Image = Properties.Resources.Help;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(8, 65);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(131, 47);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "   Help";
            toolTip1.SetToolTip(buttonHelp, "Get Assistance");
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAbout.Image = Properties.Resources.About;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(149, 65);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(131, 47);
            buttonAbout.TabIndex = 8;
            buttonAbout.Text = "   About";
            toolTip1.SetToolTip(buttonAbout, "About This App And The Last Updates");
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelContainer.Location = new Point(0, 0);
            panelContainer.Margin = new Padding(5);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(869, 434);
            panelContainer.TabIndex = 1;
            panelContainer.Paint += panelContainer_Paint_1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 495);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePro";
            FormClosing += main_FormClosing;
            flowLayoutPanelNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonHome;
        private Button buttonSalaryScale;
        private Button buttonEmployees;
        private Button buttonUsers;
        private Button buttonReports;
        private Button buttonSettings;
        private Button buttonAbout;
        private Button buttonHelp;
        private ToolTip toolTip1;
        public Panel panelContainer;
    }
}
