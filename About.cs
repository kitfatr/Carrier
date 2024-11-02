using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrier
{
	public partial class About : Form
	{
		int count = 0;
		public About()
		{
			InitializeComponent();
		}

		private void OK_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void secret(object sender, MouseEventArgs e)
		{
			if (count != 0)
			{
				if (count == 6)
				{ 
					MessageBox.Show("GET OUT!!11!");
					count = 0;
					this.Close();
				}
				else
				{ MessageBox.Show("Nothing here!"); }
			}
			count++;
			this.Invalidate();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/kitfatr/Carrier/") { UseShellExecute = true });
		}
	}
}
