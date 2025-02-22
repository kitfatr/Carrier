namespace Carrier
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            fullscreen = lang_Keys.win_fullscreen;
            windowed = lang_Keys.win_windowed;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            lang = new ComboBox();
            lang_box = new GroupBox();
            win_box = new GroupBox();
            window = new ComboBox();
            OK = new Button();
            Apply = new Button();
            Reset = new Button();
            lang_box.SuspendLayout();
            win_box.SuspendLayout();
            SuspendLayout();
            // 
            // lang
            // 
            lang.Dock = DockStyle.Fill;
            lang.DropDownStyle = ComboBoxStyle.DropDownList;
            lang.FormattingEnabled = true;
            lang.Items.AddRange(new object[] { "Русский", "English" });
            lang.Location = new Point(3, 23);
            lang.Name = "lang";
            lang.Size = new Size(271, 28);
            lang.Sorted = true;
            lang.TabIndex = 0;
            lang.Tag = "Русский";
            lang.SelectionChangeCommitted += Settings_Unlock;
            // 
            // lang_box
            // 
            lang_box.Controls.Add(lang);
            lang_box.Location = new Point(12, 12);
            lang_box.Name = "lang_box";
            lang_box.Size = new Size(277, 69);
            lang_box.TabIndex = 1;
            lang_box.TabStop = false;
            lang_box.Text = "Язык";
            // 
            // win_box
            // 
            win_box.Controls.Add(window);
            win_box.Location = new Point(12, 87);
            win_box.Name = "win_box";
            win_box.Size = new Size(277, 69);
            win_box.TabIndex = 2;
            win_box.TabStop = false;
            win_box.Text = "Стиль окна";
            // 
            // window
            // 
            window.DisplayMember = "В окне";
            window.Dock = DockStyle.Fill;
            window.DropDownStyle = ComboBoxStyle.DropDownList;
            window.FormattingEnabled = true;
            window.Items.AddRange(new object[] { windowed, fullscreen });
            window.Location = new Point(3, 23);
            window.Name = "window";
            window.Size = new Size(271, 28);
            window.Sorted = true;
            window.TabIndex = 0;
            window.Tag = "";
            window.SelectionChangeCommitted += Settings_Unlock;
            // 
            // OK
            // 
            OK.Location = new Point(212, 168);
            OK.Name = "OK";
            OK.Size = new Size(77, 30);
            OK.TabIndex = 3;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            Apply.Enabled = false;
            Apply.Location = new Point(107, 168);
            Apply.Name = "Apply";
            Apply.Size = new Size(97, 30);
            Apply.TabIndex = 4;
            Apply.Text = "Применить";
            Apply.UseVisualStyleBackColor = true;
            Apply.Click += Settings_Write;
            // 
            // Reset
            // 
            Reset.Enabled = false;
            Reset.Location = new Point(12, 168);
            Reset.Name = "Reset";
            Reset.Size = new Size(87, 30);
            Reset.TabIndex = 5;
            Reset.Text = "Сбросить";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Settings_Read_Event;
            // 
            // Settings
            // 
            AcceptButton = OK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = OK;
            ClientSize = new Size(301, 210);
            Controls.Add(Reset);
            Controls.Add(Apply);
            Controls.Add(OK);
            Controls.Add(win_box);
            Controls.Add(lang_box);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки";
            Load += Settings_Load;
            lang_box.ResumeLayout(false);
            win_box.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox lang;
        private GroupBox lang_box;
        private GroupBox win_box;
        private ComboBox window;
        private Button OK;
        private Button Apply;
        private Button Reset;
    }
}