using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrier
{
	public partial class Settings : Form
	{
		string lang_set;
		string win_set;

		string fullscreen, windowed;
		struct Lang_keys
		{
			public string about_name, about_name_2, apply, auto_help, auto_name, auto_text,
				carrier, copyright, curr_frame, github_link, label, lang_name, lose_text,
				manual_name, manual_text, mode_desc_name, mode_sel, OK, reset, restart,
				settings_name, start_text, ver, win_fullscreen, win_style, win_text, win_windowed;
		};

		public Settings(Form ParentForm)
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			Settings_Read();

			lang_set = Properties.Settings.Default.lang;
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

			this.Text = lang_Keys.settings_name;
			lang_box.Text = lang_Keys.lang_name;
			win_box.Text = lang_Keys.win_style;
			Reset.Text = lang_Keys.reset;
			Apply.Text = lang_Keys.apply;
			OK.Text = lang_Keys.OK;
			windowed = lang_Keys.win_windowed;
			fullscreen = lang_Keys.win_fullscreen;
        }

		private void Settings_Unlock (object sender, EventArgs e)
		{
			if (Convert.ToString(lang.SelectedItem) == lang_set && Convert.ToString(window.SelectedItem) == win_set)
			{
				Reset.Enabled = false;
				Apply.Enabled = false;
			}
			else
			{
				Reset.Enabled = true;
				Apply.Enabled = true;
			}
		}

		public void Settings_Read()
		{
			lang_set = Properties.Settings.Default.lang;
			win_set = Properties.Settings.Default.window_mode;
			if (lang_set == "ru-RU")
			{
				lang.SelectedItem = "Русский";
			}
			else if (lang_set == "en")
			{
				lang.SelectedItem = "English";
			}
			else
			{
				lang.SelectedItem = "Русский";
			}

			if (win_set == "windowed")
			{
				window.SelectedItem = windowed;
			}
			else if (win_set == "fullscreen")
			{
				window.SelectedItem = fullscreen;
			}
			else
			{
				window.SelectedItem = windowed;
			}

			lang_set = Convert.ToString(lang.SelectedItem);
			win_set = Convert.ToString(window.SelectedItem);
		}

		private void Settings_Read_Event(object sender, EventArgs e)
		{
			Settings_Read();
			Reset.Enabled = false;
			Apply.Enabled = false;
		}

		private void Settings_Write(object sender, EventArgs e)
		{
			lang_set = Convert.ToString(lang.SelectedItem);
			win_set = Convert.ToString(window.SelectedItem);

			if (lang.SelectedItem == "Русский")
			{
				lang_set = "ru-RU";
			}
			else if (lang.SelectedItem == "English")
			{
				lang_set = "en";
			}
			else
			{
				lang_set = "ru-RU";
			}

			if (window.SelectedItem == windowed)
			{
				win_set = "windowed";
			}
			else if (window.SelectedItem == fullscreen)
			{
				win_set = "fullscreen";
			}
			else
			{
				win_set = "windowed";
			}

			Properties.Settings.Default.lang = lang_set;
			Properties.Settings.Default.window_mode = win_set;
			Properties.Settings.Default.Save();

			Reset.Enabled = false;
			Apply.Enabled = false;

			MessageBox.Show("Изменения вступят в силу после перезапуска программы");
		}
	}
}