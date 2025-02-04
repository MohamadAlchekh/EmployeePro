using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using EmployeePro.data.EF;
using EmployeePro.core;
using EmployeePro.Code.Models;
using System.Diagnostics.Eventing.Reader;
using EmployeePro.Code.Helper;
using EmployeePro.GUI.LoadingGui;

namespace EmployeePro.GUI.UsersGui
{
	public partial class UsersUserControl : UserControl
	{

		private static UsersUserControl? usersUserControl;
		private AddUserForm addUserForm;
		private static main _main;
		private IDataHelper<Users> dataHelper;
		private List<Users> data;

		public UsersUserControl()
		{
			InitializeComponent();
			dataHelper = new UsersEF();
			data = new List<Users>();
			LoadData();
		}

		public static UsersUserControl Instance(main main)
		{
			_main = main;
			return usersUserControl ?? (usersUserControl = new UsersUserControl());
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (addUserForm == null || addUserForm.IsDisposed)
			{
				addUserForm = new AddUserForm(_main);
				addUserForm.Show();
			}
			else
			{
				addUserForm.Focus();
				PlaySoundEffect();
			}
		}
		private void PlaySoundEffect()
		{
			string soundFilePath = @"C:\EmployeePro\Resources\Background_Sound_Effect.wav";
			System.Media.SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);
			soundPlayer.Play();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{

		}

		private void buttonExport_Click(object sender, EventArgs e)
		{

		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{

		}
		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{

		}


		// Methods 
		public async void LoadData()
		{
			// show loading
			LoadingForm.Instance(_main).Show();
			if (await Task.Run(() => dataHelper.Connected()))
			{
				// start loading data
				// check if admin or not 
				if (LocalUser.Role == "Admin")
				{
					// get all data
					data = await Task.Run(() => dataHelper.GetAllData());
				}
				else
				{
					// get data for user
					data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));
				}

				// Fill DataGridView
				dataGridView1.DataSource = data;

				// Set columns Title
				setcolumns();

				// Show Empty Data
				ShowEmptyDataState();
				
				// Clear Data
				data.Clear();

			}
			else
			{
				// No Connection
				LoadingForm.Instance(_main).Hide();
				ShowServerErrorState();
				MsgHelper.ShowServerError();
			}
			// Hide Loading
			LoadingForm.Instance(_main).Hide();

			
		}
		private void ShowEmptyDataState()
		{
			// Set Title and Description
			labelStateTitle.Text = Properties.Resources.EmptyDataStateTitle;
			labelStateDescription.Text = Properties.Resources.EmptyDataStateDescription;
			panelState.Visible = dgvHelper.IsEmpty(dataGridView1);
		}
		private void ShowServerErrorState()
		{
			// Set Title and Description
			labelStateTitle.Text = Properties.Resources.ServerErrorTitle;
			labelStateDescription.Text = Properties.Resources.ServerErrorDescription;
			panelState.Visible = true;
		}
		private void setcolumns()
		{
			dataGridView1.Columns[0].HeaderCell.Value = "Id";
			dataGridView1.Columns[1].HeaderCell.Value = "Full Name";
			dataGridView1.Columns[2].HeaderCell.Value = "User Name";
			dataGridView1.Columns[3].HeaderCell.Value = "Password";
			dataGridView1.Columns[4].HeaderCell.Value = "Role";
			dataGridView1.Columns[5].HeaderCell.Value = "Is A Secondary User";
			dataGridView1.Columns[6].HeaderCell.Value = "UserId";
			dataGridView1.Columns[7].HeaderCell.Value = "Phone";
			dataGridView1.Columns[8].HeaderCell.Value = "Email";
			dataGridView1.Columns[9].HeaderCell.Value = "Address";
			dataGridView1.Columns[10].HeaderCell.Value = "Created Date";
			dataGridView1.Columns[11].HeaderCell.Value = "Modified Date";

			// Visible columns
			dataGridView1.Columns[3].Visible = false;
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[6].Visible = false;
			//dataGridView1.Columns[12].Visible = false;
			//dataGridView1.Columns[13].Visible = false;

		}

		


	}
}

