using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePro.GUI.UsersGui
{
    public partial class UsersUserControl : UserControl
    {

        private static readonly UsersUserControl? usersUserControl;

        public UsersUserControl()
        {
            InitializeComponent();
        }

        public static UsersUserControl Instance()
        {
            return usersUserControl ?? new UsersUserControl();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

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
