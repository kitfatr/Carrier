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
            lang.Enabled = false;
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
            window.Items.AddRange(new object[] { "В окне", "На весь экран" });
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