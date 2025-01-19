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
		
		public Settings(Form ParentForm)
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			Settings_Read();
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
				window.SelectedItem = "В окне";
			}
			else if (win_set == "fullscreen")
			{
				window.SelectedItem = "На весь экран";
			}
			else
			{
				window.SelectedItem = "В окне";
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

			if (window.SelectedItem == "В окне")
			{
				win_set = "windowed";
			}
			else if (window.SelectedItem == "На весь экран")
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