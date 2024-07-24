using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePro.Code.Helper
{
    internal class PageHelper
    {
        private readonly main main;

        public PageHelper(main main)
        {
            this.main = main;
        }
        // Set New Page
        
        public void SetPage(UserControl pageUserControl)
        {
            // Get The Current Page
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();

            // Remove The Old Page
            if (oldPage != null && oldPage != pageUserControl)
            {
             main.panelContainer.Controls.Remove(oldPage);
            }

            // Add New Page
            if(oldPage != pageUserControl)
            {
                pageUserControl.Dock = DockStyle.Fill;
                main.panelContainer.Controls.Add(pageUserControl);

            }
        }
    }
}
