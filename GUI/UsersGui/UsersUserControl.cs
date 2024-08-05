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

namespace EmployeePro.GUI.UsersGui
{
    public partial class UsersUserControl : UserControl
    {

        private static readonly UsersUserControl? usersUserControl;
        private AddUserForm addUserForm;
        private static main _main;

        public UsersUserControl()
        {
            InitializeComponent();
        }

        public static UsersUserControl Instance(main main)
        {
            _main = main;
            return usersUserControl ?? new UsersUserControl();
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

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
