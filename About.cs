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
		bool stop;
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
			int x = 1, y = 1;
			while (stop == false)
			{
				icon.Location = new Point(12 + x, 12 + y);
				Thread.Sleep(300);
				x++;
				y++;
				this.Invalidate();
			}
		}

		public void Mouse_Hover(object sender, EventArgs e)
		{
			stop = true;
		}

		public void Mouse_Leave(object sender, EventArgs e)
		{
			stop = false;
		}
	}
}
