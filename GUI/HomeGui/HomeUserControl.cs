using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePro.GUI.HomeGui
{
    public partial class HomeUserControl : UserControl
    {
        private static readonly HomeUserControl? homeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            
        public static HomeUserControl Instance()
        {
            return homeUserControl?? new HomeUserControl();
        }
    }
}
