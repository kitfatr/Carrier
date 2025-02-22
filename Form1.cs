using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;
using Windows.UI.Core;
using WinRT;

namespace Carrier
{
	using static Properties.Settings;
	using Resources;

	public partial class Carrier : Form
	{
		#region Variables
		private readonly Image boat = (Bitmap)new ImageConverter().ConvertFrom(img.boat),
		goat = (Bitmap)new ImageConverter().ConvertFrom(img.goat),
		cabg = (Bitmap)new ImageConverter().ConvertFrom(img.cabg),
		wolf = (Bitmap)new ImageConverter().ConvertFrom(img.wolf);
		public int frame = 0, time = 50;
		Font font = new("Segoe UI", 10, FontStyle.Bold);
		SolidBrush brush = new(Color.Black);
		public float ScHeight, ScWidth, ScAspect_Ratio;
		Choose newform;
		public string? cabg_st, wolf_st, goat_st, boat_st;
		public Point MousePos;
		Pen pen = new(Color.Red),
		debug_pen = new(Color.DarkRed, 5);
		Brush debug_brush = new SolidBrush(Color.White);
		public Point cbg_1, cbg_2, cbg_3, cbg_4, wlf_1, wlf_2, wlf_3, wlf_4, gt_1, gt_2, gt_3, gt_4;
		public bool Debug_Mode = false;
		public string currframe;
		public Point currframe_pos;

		string lang_set, win_set;
		#endregion

		struct Lang_keys
		{
			public string about_name, about_name_2, apply, auto_help, auto_name, auto_text,
				carrier, copyright, curr_frame, github_link, label, lang_name, lose_text,
				manual_name, manual_text, mode_desc_name, mode_sel, OK, reset, restart,
				settings_name, start_text, ver, win_fullscreen, win_style, win_text, win_windowed;
		};

		public Carrier()
		{
			InitializeComponent();

			debug_pen.DashStyle = DashStyle.Dash;

			lang_set = Default.lang;
			win_set = Default.window_mode;
			#region Lang-keys table
			Lang_keys lang_Keys = new Lang_keys();
			if (lang_set == "ru-RU")
			{
				lang_Keys.about_name = lang_RU.about_name;
				lang_Keys.about_name_2 = lang_RU.about_name_2;
				lang_Keys.apply = lang_RU.apply;
				lang_Keys.auto_help = lang_RU.auto_help;
				lang_Keys.auto_text = lang_RU.auto_text;
				lang_Keys.auto_name = lang_RU.auto_name;
				lang_Keys.carrier = lang_RU.carrier;
				lang_Keys.copyright = lang_RU.copyright;
				lang_Keys.curr_frame = lang_RU.curr_frame;
				lang_Keys.github_link = lang_RU.github_link;
				lang_Keys.label = lang_RU.label;
				lang_Keys.lang_name = lang_RU.lang_name;
				lang_Keys.lose_text = lang_RU.lose_text;
				lang_Keys.manual_name = lang_RU.manual_name;
				lang_Keys.manual_text = lang_RU.manual_text;
				lang_Keys.mode_desc_name = lang_RU.mode_desc_name;
				lang_Keys.mode_sel = lang_RU.mode_sel;
				lang_Keys.OK = lang_RU.OK;
				lang_Keys.reset = lang_RU.reset;
				lang_Keys.restart = lang_RU.restart;
				lang_Keys.settings_name = lang_RU.settings_name;
				lang_Keys.start_text = lang_RU.start_text;
				lang_Keys.ver = lang_RU.ver;
				lang_Keys.win_fullscreen = lang_RU.win_fullscreen;
				lang_Keys.win_style = lang_RU.win_style;
				lang_Keys.win_text = lang_RU.win_text;
				lang_Keys.win_windowed = lang_RU.win_windowed;
			}
			else if (lang_set == "en")
			{
				lang_Keys.about_name = lang_EN.about_name;
				lang_Keys.about_name_2 = lang_EN.about_name_2;
				lang_Keys.apply = lang_EN.apply;
				lang_Keys.auto_help = lang_EN.auto_help;
				lang_Keys.auto_text = lang_EN.auto_text;
				lang_Keys.auto_name = lang_EN.auto_name;
				lang_Keys.carrier = lang_EN.carrier;
				lang_Keys.copyright = lang_EN.copyright;
				lang_Keys.curr_frame = lang_EN.curr_frame;
				lang_Keys.github_link = lang_EN.github_link;
				lang_Keys.label = lang_EN.label;
				lang_Keys.lang_name = lang_EN.lang_name;
				lang_Keys.lose_text = lang_EN.lose_text;
				lang_Keys.manual_name = lang_EN.manual_name;
				lang_Keys.manual_text = lang_EN.manual_text;
				lang_Keys.mode_desc_name = lang_EN.mode_desc_name;
				lang_Keys.mode_sel = lang_EN.mode_sel;
				lang_Keys.OK = lang_EN.OK;
				lang_Keys.reset = lang_EN.reset;
				lang_Keys.restart = lang_EN.restart;
				lang_Keys.settings_name = lang_EN.settings_name;
				lang_Keys.start_text = lang_EN.start_text;
				lang_Keys.ver = lang_EN.ver;
				lang_Keys.win_fullscreen = lang_EN.win_fullscreen;
				lang_Keys.win_style = lang_EN.win_style;
				lang_Keys.win_text = lang_EN.win_text;
				lang_Keys.win_windowed = lang_EN.win_windowed;
			}
			#endregion

			Name1.Text = lang_Keys.label;
			Text1.Text = lang_Keys.start_text;
			lose_text.Text = lang_Keys.lose_text;
			label2.Text = lang_Keys.win_text;
			íàñòðîéêèToolStripMenuItem.Text = lang_Keys.settings_name;
			îÏðîãðàììåToolStripMenuItem.Text = lang_Keys.about_name;
			restart_button.Text = lang_Keys.restart;
			Text2.Text = lang_Keys.auto_help;
			Carrier_button.Text = lang_Keys.carrier;
			this.Text = lang_Keys.label;
			currframe = lang_Keys.curr_frame;

			if (lang_set == "en")
			{
				Text1.Size = new Size(MousePos);
			}

			if (lang_set == "ru-RU")
			{
				currframe_pos = new Point(240, 2);
			}
			else if (lang_set == "en")
			{
				currframe_pos = new Point(160, 2);
			}

			newform = new Choose(this, lang_set);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (win_set == "fullscreen")
			{
				this.WindowState = FormWindowState.Normal;
				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;
			}

			newform.ShowDialog();
		}

		private void Name1_Click(object sender, EventArgs e)
		{

		}

		private void Text1_Click(object sender, EventArgs e)
		{

		}

		private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About newForm = new About(lang_set);
			newForm.ShowDialog();
		}

		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings newSettings = new Settings(this);
			newSettings.ShowDialog();
		}

		private void IsSizeChanged(object sender, EventArgs e)
		{
			ScHeight = Convert.ToSingle(this.Height) / 1038;
			ScWidth = Convert.ToSingle(this.Width) / 1938;
			ScAspect_Ratio = ScHeight / ScWidth;
			Text1.Size = new Size(Convert.ToInt32(349 * ScWidth), Convert.ToInt32(270 * ScHeight));
			Text1.Font = new Font("Arial", 15 * ScHeight);
			Text1.Location = new Point(Convert.ToInt32(1500 * ScWidth), Convert.ToInt32(27 * ScHeight));
			Name1.Size = new Size(Convert.ToInt32(349 * ScWidth), Convert.ToInt32(79 * ScHeight));
			Name1.Font = new Font("Arial", 35 * ScWidth);
			Name1.Location = new Point(Convert.ToInt32(this.Width / 2 - (80 / ScWidth)), Convert.ToInt32(27 * ScHeight));
			label2.Size = new Size(Convert.ToInt32(349 * ScWidth), Convert.ToInt32(152 * ScHeight));
			label2.Location = new Point(Convert.ToInt32(1500 * ScWidth), Convert.ToInt32(27 * ScHeight));
			//if (ScAspect_Ratio < 0.5f)
			//{
			//	ScAspect_Ratio = 0.5f;
			//}
			//if (ScAspect_Ratio > 2f)
			//{
			//	ScAspect_Ratio = 2f;
			//}
			this.Invalidate();
		}

		protected void DebugMode(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F5)
			{
				if (Debug_Mode == false)
				{
					Debug_Mode = true;
				}
				else
				{
					Debug_Mode = false;
				}
			}
			this.Invalidate();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			#region Auto Mode
			if (newform.ISAuto == true)
			{
				if (frame == 0)
				{
					Name1.Visible = true;
					Text1.Visible = true;
					label2.Visible = false;
					Text2.Visible = true;
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, -50 * ScWidth, 600 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, -10 * ScWidth, 670 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 300 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 1)
				{
					Name1.Visible = false;
					Text1.Visible = false;
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, -50 * ScWidth, 600 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 470 * ScWidth, 660 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 300 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 2)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, -50 * ScWidth, 600 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1240 * ScWidth, 660 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 3)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, -50 * ScWidth, 600 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1520 * ScWidth, 625 * ScHeight, -450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 4)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, -50 * ScWidth, 600 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 750 * ScWidth, 625 * ScHeight, -450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 5)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 380 * ScWidth, 660 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 300 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 6)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1150 * ScWidth, 660 * ScHeight, 375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 7)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1370 * ScWidth, 660 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1520 * ScWidth, 625 * ScHeight, -450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 8)
				{
					e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 600 * ScWidth, 660 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 750 * ScWidth, 625 * ScHeight, -450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 9)
				{
					e.Graphics.DrawImage(cabg, 500 * ScWidth, 680 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, -10 * ScWidth, 670 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 300 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 10)
				{
					e.Graphics.DrawImage(cabg, 1270 * ScWidth, 680 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, -10 * ScWidth, 670 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 11)
				{
					e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, -10 * ScWidth, 670 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1520 * ScWidth, 625 * ScHeight, -450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 12)
				{
					e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, -10 * ScWidth, 670 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 750 * ScWidth, 625 * ScHeight, -450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 13)
				{
					e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 470 * ScWidth, 660 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 300 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 14)
				{
					label2.Visible = false;
					e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1240 * ScWidth, 660 * ScHeight, 330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 15)
				{
					label2.Visible = true;
					e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
				}
				else if (frame == 16)
				{
					e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight);
					e.Graphics.DrawImage(wolf, 1825 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight);
					e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight);
					e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight);
					e.Graphics.DrawString(time.ToString(), font, brush, 300, 2);
					Timer();
				}
			}
			#endregion
			#region Manual Mode
			if (newform.ISAuto == false)
			{
				if (cabg_st == "lf")
				{
					cbg_1 = new Point(Convert.ToInt32(315 * ScWidth), Convert.ToInt32(590 * ScHeight));
					cbg_2 = new Point(Convert.ToInt32(490 * ScWidth), Convert.ToInt32(590 * ScHeight));
					cbg_3 = new Point(Convert.ToInt32(490 * ScWidth), Convert.ToInt32(760 * ScHeight));
					cbg_4 = new Point(Convert.ToInt32(315 * ScWidth), Convert.ToInt32(760 * ScHeight));
				}
				else if (cabg_st == "lt")
				{
					cbg_1 = new Point(Convert.ToInt32(510 * ScWidth), Convert.ToInt32(695 * ScHeight));
					cbg_2 = new Point(Convert.ToInt32(675 * ScWidth), Convert.ToInt32(695 * ScHeight));
					cbg_3 = new Point(Convert.ToInt32(675 * ScWidth), Convert.ToInt32(855 * ScHeight));
					cbg_4 = new Point(Convert.ToInt32(510 * ScWidth), Convert.ToInt32(855 * ScHeight));
				}
				else if (cabg_st == "rt")
				{
					cbg_1 = new Point(Convert.ToInt32(1280 * ScWidth), Convert.ToInt32(695 * ScHeight));
					cbg_2 = new Point(Convert.ToInt32(1445 * ScWidth), Convert.ToInt32(695 * ScHeight));
					cbg_3 = new Point(Convert.ToInt32(1445 * ScWidth), Convert.ToInt32(855 * ScHeight));
					cbg_4 = new Point(Convert.ToInt32(1280 * ScWidth), Convert.ToInt32(855 * ScHeight));
				}
				else if (cabg_st == "rf")
				{
					cbg_1 = new Point(Convert.ToInt32(1385 * ScWidth), Convert.ToInt32(590 * ScHeight));
					cbg_2 = new Point(Convert.ToInt32(1560 * ScWidth), Convert.ToInt32(590 * ScHeight));
					cbg_3 = new Point(Convert.ToInt32(1560 * ScWidth), Convert.ToInt32(760 * ScHeight));
					cbg_4 = new Point(Convert.ToInt32(1385 * ScWidth), Convert.ToInt32(760 * ScHeight));
				}
				if (wolf_st == "lf")
				{
					wlf_1 = new Point(Convert.ToInt32(5 * ScWidth), Convert.ToInt32(600 * ScHeight));
					wlf_2 = new Point(Convert.ToInt32(315 * ScWidth), Convert.ToInt32(600 * ScHeight));
					wlf_3 = new Point(Convert.ToInt32(315 * ScWidth), Convert.ToInt32(670 * ScHeight));
					wlf_4 = new Point(Convert.ToInt32(5 * ScWidth), Convert.ToInt32(730 * ScHeight));
				}
				else if (wolf_st == "lt")
				{
					wlf_1 = new Point(Convert.ToInt32(470 * ScWidth), Convert.ToInt32(675 * ScHeight));
					wlf_2 = new Point(Convert.ToInt32(740 * ScWidth), Convert.ToInt32(675 * ScHeight));
					wlf_3 = new Point(Convert.ToInt32(740 * ScWidth), Convert.ToInt32(875 * ScHeight));
					wlf_4 = new Point(Convert.ToInt32(470 * ScWidth), Convert.ToInt32(875 * ScHeight));
				}
				else if (wolf_st == "rt")
				{
					wlf_1 = new Point(Convert.ToInt32(1240 * ScWidth), Convert.ToInt32(675 * ScHeight));
					wlf_2 = new Point(Convert.ToInt32(1510 * ScWidth), Convert.ToInt32(675 * ScHeight));
					wlf_3 = new Point(Convert.ToInt32(1510 * ScWidth), Convert.ToInt32(875 * ScHeight));
					wlf_4 = new Point(Convert.ToInt32(1240 * ScWidth), Convert.ToInt32(875 * ScHeight));
				}
				else if (wolf_st == "rf")
				{
					wlf_1 = new Point(Convert.ToInt32(1455 * ScWidth), Convert.ToInt32(600 * ScHeight));
					wlf_2 = new Point(Convert.ToInt32(1755 * ScWidth), Convert.ToInt32(600 * ScHeight));
					wlf_3 = new Point(Convert.ToInt32(1755 * ScWidth), Convert.ToInt32(730 * ScHeight));
					wlf_4 = new Point(Convert.ToInt32(1455 * ScWidth), Convert.ToInt32(670 * ScHeight));
				}
				if (goat_st == "lf")
				{
					gt_1 = new Point(Convert.ToInt32(0 * ScWidth), Convert.ToInt32(720 * ScHeight));
					gt_2 = new Point(Convert.ToInt32(315 * ScWidth), Convert.ToInt32(720 * ScHeight));
					gt_3 = new Point(Convert.ToInt32(240 * ScWidth), Convert.ToInt32(905 * ScHeight));
					gt_4 = new Point(Convert.ToInt32(0 * ScWidth), Convert.ToInt32(905 * ScHeight));
				}
				else if (goat_st == "lt")
				{
					gt_1 = new Point(Convert.ToInt32(490 * ScWidth), Convert.ToInt32(675 * ScHeight));
					gt_2 = new Point(Convert.ToInt32(780 * ScWidth), Convert.ToInt32(675 * ScHeight));
					gt_3 = new Point(Convert.ToInt32(780 * ScWidth), Convert.ToInt32(875 * ScHeight));
					gt_4 = new Point(Convert.ToInt32(490 * ScWidth), Convert.ToInt32(875 * ScHeight));
				}
				else if (goat_st == "rt")
				{
					gt_1 = new Point(Convert.ToInt32(1260 * ScWidth), Convert.ToInt32(675 * ScHeight));
					gt_2 = new Point(Convert.ToInt32(1550 * ScWidth), Convert.ToInt32(675 * ScHeight));
					gt_3 = new Point(Convert.ToInt32(1550 * ScWidth), Convert.ToInt32(875 * ScHeight));
					gt_4 = new Point(Convert.ToInt32(1260 * ScWidth), Convert.ToInt32(875 * ScHeight));
				}
				else if (goat_st == "rf")
				{
					gt_1 = new Point(Convert.ToInt32(1555 * ScWidth), Convert.ToInt32(710 * ScHeight));
					gt_2 = new Point(Convert.ToInt32(1870 * ScWidth), Convert.ToInt32(710 * ScHeight));
					gt_3 = new Point(Convert.ToInt32(1870 * ScWidth), Convert.ToInt32(905 * ScHeight));
					gt_4 = new Point(Convert.ToInt32(1555 * ScWidth), Convert.ToInt32(905 * ScHeight));
				}
				if (frame == 0)
				{
					Name1.Visible = true;
					Text1.Visible = true;
					label2.Visible = false;
					cabg_st = "lf";
					wolf_st = "lf";
					goat_st = "lf";
					boat_st = "ln";
				}
				else
				{
					Name1.Visible = false;
					Text1.Visible = false;
					Carrier_button.Visible = true;
					Carrier_button.Enabled = true;
				}
				if (cabg_st == "lf")
				{ e.Graphics.DrawImage(cabg, 300 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight); }
				if (cabg_st == "lt")
				{ e.Graphics.DrawImage(cabg, 500 * ScWidth, 680 * ScHeight, 200 * ScWidth, 200 * ScHeight); }
				if (cabg_st == "rf")
				{ e.Graphics.DrawImage(cabg, 1370 * ScWidth, 575 * ScHeight, 200 * ScWidth, 200 * ScHeight); }
				if (cabg_st == "rt")
				{ e.Graphics.DrawImage(cabg, 1270 * ScWidth, 680 * ScHeight, 200 * ScWidth, 200 * ScHeight); }
				if (wolf_st == "lf")
				{ e.Graphics.DrawImage(wolf, -50 * ScWidth, 600 * ScHeight, 375 * ScWidth, 225 * ScHeight); }
				if (wolf_st == "lt")
				{ e.Graphics.DrawImage(wolf, 380 * ScWidth, 660 * ScHeight, 375 * ScWidth, 225 * ScHeight); }
				if (wolf_st == "rf")
				{ e.Graphics.DrawImage(wolf, 1820 * ScWidth, 600 * ScHeight, -375 * ScWidth, 225 * ScHeight); }
				if (wolf_st == "rt")
				{ e.Graphics.DrawImage(wolf, 1150 * ScWidth, 660 * ScHeight, 375 * ScWidth, 225 * ScHeight); }
				if (goat_st == "lf")
				{ e.Graphics.DrawImage(goat, -10 * ScWidth, 670 * ScHeight, 330 * ScWidth, 248 * ScHeight); }
				if (goat_st == "lt")
				{ e.Graphics.DrawImage(goat, 470 * ScWidth, 660 * ScHeight, 330 * ScWidth, 248 * ScHeight); }
				if (goat_st == "rf")
				{ e.Graphics.DrawImage(goat, 1870 * ScWidth, 670 * ScHeight, -330 * ScWidth, 248 * ScHeight); }
				if (goat_st == "rt")
				{ e.Graphics.DrawImage(goat, 1240 * ScWidth, 660 * ScHeight, 330 * ScWidth, 248 * ScHeight); }
				if (boat_st == "ln" || boat_st == "lc" || boat_st == "lw" || boat_st == "lg")
				{ e.Graphics.DrawImage(boat, 300 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight); }
				if (boat_st == "rn" || boat_st == "rc" || boat_st == "rw" || boat_st == "rg")
				{ e.Graphics.DrawImage(boat, 1070 * ScWidth, 625 * ScHeight, 450 * ScWidth, 300 * ScHeight); }
			}
			#endregion
			#region Debug Mode
			if (Debug_Mode == true)
			{
				Point[] deb_window = { new Point(0, 25), new Point(600, 25), new Point(600, 385), new Point(0, 385) };
				e.Graphics.DrawPolygon(debug_pen, deb_window);
				e.Graphics.FillPolygon(debug_brush, deb_window);
				e.Graphics.DrawString(
					"IS DEBUGGING:  " + Debug_Mode + "\n" +
					"CLICK POS:  " + MousePos + "\n" +
					"SCREEN SCALING:  HEIGHT:  " + ScHeight + "  " + "WIDTH:  " + ScWidth + "\n" +
					"	ASPECT RATIO:" + ScAspect_Ratio + "\n" +
					"LANGUAGE: " + lang_set + "\n" +
					"STATES (ONLY IN MANUAL MODE):  \n" +
					"	BOAT: " + boat_st + "\n" +
					"	GOAT: " + goat_st + "\n" +
					"	WOLF: " + wolf_st + "\n" +
					"	CABG: " + cabg_st + "\n\n" +
					"ADDITIONAL INFORMATION\nFirst letter: 'l' - left, 'r' - right;\n " +
					"Second letter: 'f' - not on the boat/nobody in the boat, 't' - on the boat\n " +
					"'g' - goat in the boat, 'w' - wolf in the boat, 'c' - cabbage in the boat.\n" +
					"Red polygons display borders of click triggers",
					font, brush, 5, 30);
				Point[] cbg_trig = { cbg_1, cbg_2, cbg_3, cbg_4 };
				Point[] wlf_trig = { wlf_1, wlf_2, wlf_3, wlf_4 };
				Point[] gt_trig = { gt_1, gt_2, gt_3, gt_4 };
				e.Graphics.DrawPolygon(pen, cbg_trig);
				e.Graphics.DrawPolygon(pen, wlf_trig);
				e.Graphics.DrawPolygon(pen, gt_trig);

			}
			#endregion
			e.Graphics.DrawString(currframe + " " + frame, font, brush, currframe_pos);
		}

		private void Frame_Plus(object sender, MouseEventArgs e)
		{
			#region Auto Mode
			if (newform.ISAuto == true)
			{
				if (e.Button == MouseButtons.Left && frame != 16)
				{
					frame++;
				}
				if (e.Button == MouseButtons.Right && frame != 0 && frame != 16)
				{
					frame--;
				}
				MousePos = e.Location;
				this.Invalidate();
			}
			#endregion
			#region Manual Mode
			if (newform.ISAuto == false)
			{
				if (e.Button == MouseButtons.Left)
				{
					frame++;
					MousePos = e.Location;
					if ((MousePos.X >= cbg_1.X && MousePos.Y >= cbg_1.Y) && (MousePos.X <= cbg_3.X && MousePos.Y <= cbg_3.Y))
					{
						if (cabg_st == "lf" && boat_st == "ln")
						{
							cabg_st = "lt";
							boat_st = "lc";
						}
						else if (cabg_st == "lt" && boat_st == "lc")
						{
							cabg_st = "lf";
							boat_st = "ln";
						}
						else if (cabg_st == "rf" && boat_st == "rn")
						{
							cabg_st = "rt";
							boat_st = "rc";
						}
						else if (cabg_st == "rt" && boat_st == "rc")
						{
							cabg_st = "rf";
							boat_st = "rn";
						}
					}
					if ((MousePos.X >= wlf_1.X && MousePos.Y >= wlf_1.Y) && (MousePos.X <= wlf_3.X && MousePos.Y <= wlf_3.Y))
					{
						if (wolf_st == "lf" && boat_st == "ln")
						{
							wolf_st = "lt";
							boat_st = "lw";
						}
						else if (wolf_st == "lt" && boat_st == "lw")
						{
							wolf_st = "lf";
							boat_st = "ln";
						}
						else if (wolf_st == "rf" && boat_st == "rn")
						{
							wolf_st = "rt";
							boat_st = "rw";
						}
						else if (wolf_st == "rt" && boat_st == "rw")
						{
							wolf_st = "rf";
							boat_st = "rn";
						}
					}
					if ((MousePos.X >= gt_1.X && MousePos.Y >= gt_1.Y) && (MousePos.X <= gt_3.X && MousePos.Y <= gt_3.Y))
					{
						if (goat_st == "lf" && boat_st == "ln")
						{
							goat_st = "lt";
							boat_st = "lg";
						}
						else if (goat_st == "lt" && boat_st == "lg")
						{
							goat_st = "lf";
							boat_st = "ln";
						}
						else if (goat_st == "rf" && boat_st == "rn")
						{
							goat_st = "rt";
							boat_st = "rg";
						}
						else if (goat_st == "rt" && boat_st == "rg")
						{
							goat_st = "rf";
							boat_st = "rn";
						}
					}
					this.Invalidate();
				}
			}
			#endregion
		}

		public void Timer()
		{
			if (time > 8)
			{
				time--;
			}
			else
			{
				this.Close();
			}
			this.Invalidate();
		}

		public void Carrier_button_Click(object sender, EventArgs e)
		{
			if (boat_st == "ln")
			{
				boat_st = "rn";
			}
			else if (boat_st == "lc")
			{
				boat_st = "rc";
				cabg_st = "rt";
			}
			else if (boat_st == "lw")
			{
				boat_st = "rw";
				wolf_st = "rt";
			}
			else if (boat_st == "lg")
			{
				boat_st = "rg";
				goat_st = "rt";
			}
			else if (boat_st == "rn")
			{
				boat_st = "ln";
			}
			else if (boat_st == "rc")
			{
				boat_st = "lc";
				cabg_st = "lt";
			}
			else if (boat_st == "rw")
			{
				boat_st = "lw";
				wolf_st = "lt";
			}
			else if (boat_st == "rg")
			{
				boat_st = "lg";
				goat_st = "lt";
			}
			frame++;
			if ((((cabg_st == "lf" && goat_st == "lf") && (boat_st != "ln" || boat_st != "lw")) || ((cabg_st == "rf" && goat_st == "rf") && (boat_st != "rn" || boat_st != "rw"))) || (((wolf_st == "lf" && goat_st == "lf") && (boat_st != "ln" || boat_st != "lg")) || (wolf_st == "rf" && goat_st == "rf" && (boat_st != "rn" || boat_st != "rg"))))
			{
				lose_text.Visible = true;
				Carrier_button.Visible = false;
				Carrier_button.Enabled = false;
				Carrier_button.Size = new Size(0, 0);
				restart_button.Visible = true;
				restart_button.Enabled = true;
			}
			if (cabg_st == "rf" && goat_st == "rf" && wolf_st == "rf" && boat_st == "rn")
			{
				label2.Visible = true;
				Carrier_button.Visible = false;
				Carrier_button.Enabled = false;
				Carrier_button.Size = new Size(0, 0);
				Timer();
			}
			this.Invalidate();
		}

		public void restart_button_Click(object sender, EventArgs e)
		{
			frame = 0;
			restart_button.Enabled = false;
			restart_button.Visible = false;
			Carrier_button.Visible = true;
			Carrier_button.Enabled = true;
			Carrier_button.Size = new Size(140, 30);
			lose_text.Visible = false;
			this.Invalidate();
		}
	}
}
