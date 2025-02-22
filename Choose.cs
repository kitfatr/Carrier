using Carrier.Resources;
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
        struct Lang_keys
        {
            public string about_name, about_name_2, apply, auto_help, auto_name, auto_text,
                carrier, copyright, curr_frame, github_link, label, lang_name, lose_text,
                manual_name, manual_text, mode_desc_name, mode_sel, OK, reset, restart,
                settings_name, start_text, ver, win_fullscreen, win_style, win_text, win_windowed;
        };

        public Choose(Form f, string lang_set)
		{
			InitializeComponent();
			form = f;

            #region Lang-keys table
            Lang_keys lang_Keys = new Lang_keys();
            if (lang_set == "ru-RU")
            {
                lang_Keys.about_name = Resources.lang_RU.about_name;
                lang_Keys.about_name_2 = Resources.lang_RU.about_name_2;
                lang_Keys.apply = Resources.lang_RU.apply;
                lang_Keys.auto_help = Resources.lang_RU.auto_help;
                lang_Keys.auto_text = Resources.lang_RU.auto_text;
                lang_Keys.auto_name = Resources.lang_RU.auto_name;
                lang_Keys.carrier = Resources.lang_RU.carrier;
                lang_Keys.copyright = Resources.lang_RU.copyright;
                lang_Keys.curr_frame = Resources.lang_RU.curr_frame;
                lang_Keys.github_link = Resources.lang_RU.github_link;
                lang_Keys.label = Resources.lang_RU.label;
                lang_Keys.lang_name = Resources.lang_RU.lang_name;
                lang_Keys.lose_text = Resources.lang_RU.lose_text;
                lang_Keys.manual_name = Resources.lang_RU.manual_name;
                lang_Keys.manual_text = Resources.lang_RU.manual_text;
                lang_Keys.mode_desc_name = Resources.lang_RU.mode_desc_name;
                lang_Keys.mode_sel = Resources.lang_RU.mode_sel;
                lang_Keys.OK = Resources.lang_RU.OK;
                lang_Keys.reset = Resources.lang_RU.reset;
                lang_Keys.restart = Resources.lang_RU.restart;
                lang_Keys.settings_name = Resources.lang_RU.settings_name;
                lang_Keys.start_text = Resources.lang_RU.start_text;
                lang_Keys.ver = Resources.lang_RU.ver;
                lang_Keys.win_fullscreen = Resources.lang_RU.win_fullscreen;
                lang_Keys.win_style = Resources.lang_RU.win_style;
                lang_Keys.win_text = Resources.lang_RU.win_text;
                lang_Keys.win_windowed = Resources.lang_RU.win_windowed;
            }
            else if (lang_set == "en")
            {
                lang_Keys.about_name = Resources.lang_EN.about_name;
                lang_Keys.about_name_2 = Resources.lang_EN.about_name_2;
                lang_Keys.apply = Resources.lang_EN.apply;
                lang_Keys.auto_help = Resources.lang_EN.auto_help;
                lang_Keys.auto_text = Resources.lang_EN.auto_text;
                lang_Keys.auto_name = Resources.lang_EN.auto_name;
                lang_Keys.carrier = Resources.lang_EN.carrier;
                lang_Keys.copyright = Resources.lang_EN.copyright;
                lang_Keys.curr_frame = Resources.lang_EN.curr_frame;
                lang_Keys.github_link = Resources.lang_EN.github_link;
                lang_Keys.label = Resources.lang_EN.label;
                lang_Keys.lang_name = Resources.lang_EN.lang_name;
                lang_Keys.lose_text = Resources.lang_EN.lose_text;
                lang_Keys.manual_name = Resources.lang_EN.manual_name;
                lang_Keys.manual_text = Resources.lang_EN.manual_text;
                lang_Keys.mode_desc_name = Resources.lang_EN.mode_desc_name;
                lang_Keys.mode_sel = Resources.lang_EN.mode_sel;
                lang_Keys.OK = Resources.lang_EN.OK;
                lang_Keys.reset = Resources.lang_EN.reset;
                lang_Keys.restart = Resources.lang_EN.restart;
                lang_Keys.settings_name = Resources.lang_EN.settings_name;
                lang_Keys.start_text = Resources.lang_EN.start_text;
                lang_Keys.ver = Resources.lang_EN.ver;
                lang_Keys.win_fullscreen = Resources.lang_EN.win_fullscreen;
                lang_Keys.win_style = Resources.lang_EN.win_style;
                lang_Keys.win_text = Resources.lang_EN.win_text;
                lang_Keys.win_windowed = Resources.lang_EN.win_windowed;
            }
            #endregion

            label1.Text = lang_Keys.mode_sel;
            Auto.Text = lang_Keys.auto_name;
            Manual.Text = lang_Keys.manual_name;
            text.Text = lang_Keys.mode_desc_name;
            Auto_text.Text = lang_Keys.auto_text;
            Manual_text.Text = lang_Keys.manual_text;
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
