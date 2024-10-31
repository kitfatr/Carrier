namespace Carrier
{
    partial class Carrier
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrier));
            Name1 = new Label();
            Text1 = new Label();
            Text2 = new Label();
            menuStrip1 = new MenuStrip();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            Carrier_button = new Button();
            lose_text = new Label();
            restart_button = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Name1
            // 
            Name1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Name1.AutoSize = true;
            Name1.BackColor = SystemColors.MenuHighlight;
            Name1.BorderStyle = BorderStyle.FixedSingle;
            Name1.FlatStyle = FlatStyle.Popup;
            Name1.Font = new Font("Arial", 35F);
            Name1.Location = new Point(389, 27);
            Name1.Name = "Name1";
            Name1.Size = new Size(349, 79);
            Name1.TabIndex = 0;
            Name1.Text = "Перевозчик";
            Name1.TextAlign = ContentAlignment.MiddleCenter;
            Name1.UseCompatibleTextRendering = true;
            Name1.Click += Name1_Click;
            // 
            // Text1
            // 
            Text1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Text1.BorderStyle = BorderStyle.Fixed3D;
            Text1.Font = new Font("Arial", 15F);
            Text1.Location = new Point(781, 27);
            Text1.Name = "Text1";
            Text1.Size = new Size(349, 270);
            Text1.TabIndex = 1;
            Text1.Text = "Условия: нужно перевезти человека, козу, волка и капусту на другой берег; в лодке помещаются только двое;\r\nлодка может плыть только с человеком; козу нельзя оставлять наидине с капустой или волком.";
            Text1.UseCompatibleTextRendering = true;
            Text1.Visible = false;
            Text1.Click += Text1_Click;
            // 
            // Text2
            // 
            Text2.Anchor = AnchorStyles.Bottom;
            Text2.AutoSize = true;
            Text2.Font = new Font("Arial", 10F);
            Text2.Location = new Point(467, 625);
            Text2.Name = "Text2";
            Text2.Size = new Size(271, 19);
            Text2.TabIndex = 2;
            Text2.Text = "*Для продолжения нажмите ЛКМ*";
            Text2.TextAlign = ContentAlignment.MiddleCenter;
            Text2.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(-1, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(135, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.AutoToolTip = true;
            оПрограммеToolStripMenuItem.CheckOnClick = true;
            оПрограммеToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            оПрограммеToolStripMenuItem.ImageTransparentColor = Color.White;
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.ShortcutKeyDisplayString = "";
            оПрограммеToolStripMenuItem.Size = new Size(127, 24);
            оПрограммеToolStripMenuItem.Text = "О &программе...";
            оПрограммеToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
            оПрограммеToolStripMenuItem.ToolTipText = "Показать информацию о программе\r\n";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(781, 27);
            label2.Name = "label2";
            label2.Size = new Size(349, 152);
            label2.TabIndex = 5;
            label2.Text = "Цель выполнена!\r\nНажмите ЛКМ, чтобы закрыть программу\r\nПрограмма будет закрыта через 5 секунд!";
            label2.UseCompatibleTextRendering = true;
            label2.Visible = false;
            // 
            // Carrier_button
            // 
            Carrier_button.Anchor = AnchorStyles.Bottom;
            Carrier_button.Cursor = Cursors.Hand;
            Carrier_button.Enabled = false;
            Carrier_button.Location = new Point(530, 592);
            Carrier_button.Name = "Carrier_button";
            Carrier_button.Size = new Size(140, 30);
            Carrier_button.TabIndex = 8;
            Carrier_button.Text = "&Перевезти!";
            Carrier_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Carrier_button.UseVisualStyleBackColor = true;
            Carrier_button.Visible = false;
            Carrier_button.Click += Carrier_button_Click;
            // 
            // lose_text
            // 
            lose_text.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lose_text.BorderStyle = BorderStyle.Fixed3D;
            lose_text.Font = new Font("Arial", 15F);
            lose_text.Location = new Point(781, 27);
            lose_text.Name = "lose_text";
            lose_text.Size = new Size(349, 152);
            lose_text.TabIndex = 7;
            lose_text.Text = "Задача не решена!\r\nБыли нарушены условия!\r\n\r\nЧтобы начать занаво нажите кнопку \"Заново\"";
            lose_text.UseCompatibleTextRendering = true;
            lose_text.Visible = false;
            // 
            // restart_button
            // 
            restart_button.Anchor = AnchorStyles.Bottom;
            restart_button.Cursor = Cursors.Hand;
            restart_button.Enabled = false;
            restart_button.Location = new Point(530, 592);
            restart_button.Name = "restart_button";
            restart_button.Size = new Size(140, 30);
            restart_button.TabIndex = 6;
            restart_button.Text = "&Заново";
            restart_button.TextImageRelation = TextImageRelation.TextBeforeImage;
            restart_button.UseVisualStyleBackColor = true;
            restart_button.Visible = false;
            restart_button.Click += restart_button_Click;
            // 
            // Carrier
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 653);
            Controls.Add(restart_button);
            Controls.Add(lose_text);
            Controls.Add(Carrier_button);
            Controls.Add(label2);
            Controls.Add(Text2);
            Controls.Add(Text1);
            Controls.Add(Name1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(500, 300);
            Name = "Carrier";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "Auto";
            Text = "Перевозчик";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            MouseClick += Frame_Plus;
            Resize += IsSizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name1;
        private Label Text1;
        private Label Text2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label label2;
        private Label lose_text;
        private Button restart_button;
        private Button Carrier_button;
    }
}
