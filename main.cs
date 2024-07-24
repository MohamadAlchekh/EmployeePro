using EmployeePro.Code.Helper;

namespace EmployeePro
{
    public partial class main : Form
    {
        private PageHelper pageHelper;
        public main()
        {
            InitializeComponent();
            pageHelper = new PageHelper(this);
            
            // Set Home Page
            pageHelper.SetPage(GUI.HomeGui.HomeUserControl.Instance());
            // Get and Wet Window State
            SetScreenState(Properties.Settings.Default.isMaxScreen);
        }
        private void SetScreenState(bool isMax)
        {
            if (isMax)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowStateSettings();
        }
        private void SaveWindowStateSettings()
        {
            // Save Screen State
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.isMaxScreen = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.isMaxScreen = false;
                Properties.Settings.Default.Save();
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(GUI.HomeGui.HomeUserControl.Instance());
        }
    }
}