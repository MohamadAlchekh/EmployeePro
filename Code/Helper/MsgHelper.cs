using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePro.Code.Helper
{
	public static class MsgHelper
	{
		public static void ShowServerError()
		{
			MessageBox.Show("There is a connection error with the server. Please try again", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
