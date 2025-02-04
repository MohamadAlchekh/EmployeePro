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
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			flowLayoutPanelNavBar = new FlowLayoutPanel();
			buttonAdd = new Button();
			buttonEdit = new Button();
			buttonDelete = new Button();
			buttonExport = new Button();
			panel1 = new Panel();
			textBoxSearch = new TextBox();
			buttonSearch = new Button();
			dataGridView1 = new DataGridView();
			label1 = new Label();
			labelStateTitle = new Label();
			panelState = new Panel();
			labelStateDescription = new Label();
			buttonRefresh = new Button();
			toolTip1 = new ToolTip(components);
			flowLayoutPanelNavBar.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panelState.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanelNavBar
			// 
			flowLayoutPanelNavBar.AutoScroll = true;
			flowLayoutPanelNavBar.Controls.Add(buttonAdd);
			flowLayoutPanelNavBar.Controls.Add(buttonEdit);
			flowLayoutPanelNavBar.Controls.Add(buttonDelete);
			flowLayoutPanelNavBar.Controls.Add(buttonExport);
			flowLayoutPanelNavBar.Controls.Add(panel1);
			flowLayoutPanelNavBar.Dock = DockStyle.Top;
			flowLayoutPanelNavBar.Location = new Point(0, 0);
			flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
			flowLayoutPanelNavBar.Padding = new Padding(3);
			flowLayoutPanelNavBar.RightToLeft = RightToLeft.No;
			flowLayoutPanelNavBar.Size = new Size(885, 61);
			flowLayoutPanelNavBar.TabIndex = 1;
			toolTip1.SetToolTip(flowLayoutPanelNavBar, "Refrash Data");
			// 
			// buttonAdd
			// 
			buttonAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAdd.Image = Properties.Resources.Plus_1;
			buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
			buttonAdd.Location = new Point(6, 6);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(105, 47);
			buttonAdd.TabIndex = 1;
			buttonAdd.Text = "      Add";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonEdit.Image = Properties.Resources.Edit_1;
			buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
			buttonEdit.Location = new Point(117, 6);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(111, 47);
			buttonEdit.TabIndex = 2;
			buttonEdit.Text = "       Modify";
			buttonEdit.UseVisualStyleBackColor = true;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDelete.Image = Properties.Resources.Delete_1;
			buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
			buttonDelete.Location = new Point(234, 6);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(105, 47);
			buttonDelete.TabIndex = 3;
			buttonDelete.Text = "       Delete";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonExport
			// 
			buttonExport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonExport.Image = Properties.Resources.Microsoft_Excel_2019_1;
			buttonExport.ImageAlign = ContentAlignment.MiddleLeft;
			buttonExport.Location = new Point(345, 6);
			buttonExport.Name = "buttonExport";
			buttonExport.Size = new Size(105, 47);
			buttonExport.TabIndex = 4;
			buttonExport.Text = "       Export";
			buttonExport.UseVisualStyleBackColor = true;
			buttonExport.Click += buttonExport_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(textBoxSearch);
			panel1.Controls.Add(buttonSearch);
			panel1.Location = new Point(456, 6);
			panel1.Name = "panel1";
			panel1.Size = new Size(256, 47);
			panel1.TabIndex = 5;
			// 
			// textBoxSearch
			// 
			textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
			textBoxSearch.Dock = DockStyle.Left;
			textBoxSearch.Location = new Point(0, 0);
			textBoxSearch.Multiline = true;
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.Size = new Size(210, 47);
			textBoxSearch.TabIndex = 7;
			textBoxSearch.TextAlign = HorizontalAlignment.Center;
			textBoxSearch.TextChanged += textBoxSearch_TextChanged;
			textBoxSearch.KeyPress += textBoxSearch_KeyPress;
			// 
			// buttonSearch
			// 
			buttonSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonSearch.Image = Properties.Resources.Search_2;
			buttonSearch.Location = new Point(210, 0);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(46, 47);
			buttonSearch.TabIndex = 6;
			buttonSearch.UseVisualStyleBackColor = true;
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(598, 273);
			label1.Name = "label1";
			label1.Size = new Size(48, 20);
			label1.TabIndex = 6;
			label1.Text = "label1";
			// 
			// labelStateTitle
			// 
			labelStateTitle.BackColor = Color.White;
			labelStateTitle.Dock = DockStyle.Top;
			labelStateTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
			labelStateTitle.ForeColor = Color.DimGray;
			labelStateTitle.Location = new Point(0, 0);
			labelStateTitle.Name = "labelStateTitle";
			labelStateTitle.Size = new Size(416, 26);
			labelStateTitle.TabIndex = 6;
			labelStateTitle.Text = "No Available Data";
			labelStateTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelState
			// 
			panelState.Anchor = AnchorStyles.None;
			panelState.BackColor = Color.White;
			panelState.Controls.Add(labelStateDescription);
			panelState.Controls.Add(labelStateTitle);
			panelState.Location = new Point(230, 246);
			panelState.Name = "panelState";
			panelState.Size = new Size(416, 100);
			panelState.TabIndex = 7;
			panelState.Visible = false;
			// 
			// labelStateDescription
			// 
			labelStateDescription.BackColor = Color.White;
			labelStateDescription.Dock = DockStyle.Top;
			labelStateDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			labelStateDescription.ForeColor = Color.DarkGray;
			labelStateDescription.Location = new Point(0, 26);
			labelStateDescription.Name = "labelStateDescription";
			labelStateDescription.Size = new Size(416, 26);
			labelStateDescription.TabIndex = 7;
			labelStateDescription.Text = "No Available Data";
			labelStateDescription.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonRefresh
			// 
			buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonRefresh.Image = Properties.Resources.Update_Left_Rotation;
			buttonRefresh.Location = new Point(807, 468);
			buttonRefresh.Name = "buttonRefresh";
			buttonRefresh.Size = new Size(65, 47);
			buttonRefresh.TabIndex = 6;
			toolTip1.SetToolTip(buttonRefresh, "Refresh");
			buttonRefresh.UseVisualStyleBackColor = true;
			buttonRefresh.Click += buttonRefresh_Click;
			// 
			// UsersUserControl
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(buttonRefresh);
			Controls.Add(panelState);
			Controls.Add(dataGridView1);
			Controls.Add(flowLayoutPanelNavBar);
			Controls.Add(label1);
			Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			Margin = new Padding(4);
			Name = "UsersUserControl";
			Size = new Size(885, 534);
			flowLayoutPanelNavBar.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panelState.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonExport;
        private Panel panel1;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridView1;
		private Label label1;
		private Label labelStateTitle;
		private Panel panelState;
		private Label labelStateDescription;
		private Button buttonRefresh;
		private ToolTip toolTip1;
	}
}
