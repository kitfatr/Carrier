namespace Carrier
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            icon = new PictureBox();
            label1 = new Label();
            OK_button = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // icon
            // 
            icon.BackgroundImageLayout = ImageLayout.Zoom;
            icon.BorderStyle = BorderStyle.Fixed3D;
            icon.Image = (Image)resources.GetObject("icon.Image");
            icon.Location = new Point(12, 12);
            icon.Name = "icon";
            icon.Size = new Size(56, 53);
            icon.SizeMode = PictureBoxSizeMode.CenterImage;
            icon.TabIndex = 0;
            icon.TabStop = false;
            icon.MouseDoubleClick += secret;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 12);
            label1.Name = "label1";
            label1.Size = new Size(216, 60);
            label1.TabIndex = 1;
            label1.Text = "Перевозчик\r\nВерсия 2.3.0\r\n(С) Фатрахманов Никита 2024";
            // 
            // OK_button
            // 
            OK_button.Cursor = Cursors.Hand;
            OK_button.Location = new Point(259, 118);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(80, 30);
            OK_button.TabIndex = 2;
            OK_button.Text = "OK";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += OK_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(74, 81);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 3;
            label2.Text = "Исходный код на Github!";
            label2.Click += label2_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 160);
            Controls.Add(label2);
            Controls.Add(OK_button);
            Controls.Add(label1);
            Controls.Add(icon);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowInTaskbar = false;
            Text = "О программе Перевозчик";
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon;
        private Label label1;
        private Button OK_button;
        private Label label2;
    }
}