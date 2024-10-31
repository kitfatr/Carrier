using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrier
{
	public partial class Choose : Form
	{
		public bool ISAuto;
		Form form;
		public Choose(Form f)
		{
			InitializeComponent();
			form = f;
		}

		private void Auto_PreClick(object sender, EventArgs e)
		{
			Auto_text.Visible = true;
			Manual_text.Visible = false;
			text_null.Visible = false;
		}

		private void Auto_Click(object sender, EventArgs e)
		{
			ISAuto = true;

			this.Close();
		}

		private void Manual_PreClick(object sender, EventArgs e)
		{
			Manual_text.Visible = true;
			Auto_text.Visible = false;
			text_null.Visible = false;
		}

		private void Manual_Click(object sender, EventArgs e)
		{
			ISAuto = false;
			this.Close();
		}

		private void Auto_text_Click(object sender, EventArgs e)
		{

		}

		private void Manual_text_Click(object sender, EventArgs e)
		{

		}

		public void IsClosing(object sender, FormClosingEventArgs e)
		{
			form.Invalidate();
		}
		private void Choose_Load(object sender, EventArgs e)
		{

		}

		private void Auto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
            Auto_text.Visible = true;
            Manual_text.Visible = false;
            text_null.Visible = false;
        }

        private void Manual_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Manual_text.Visible = true;
            Auto_text.Visible = false;
            text_null.Visible = false;
        }
    }
}
