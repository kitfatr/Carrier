namespace Carrier
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            Auto = new Button();
            Manual = new Button();
            text = new Label();
            Auto_text = new Label();
            Manual_text = new Label();
            text_null = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Auto
            // 
            Auto.AutoSize = true;
            Auto.Cursor = Cursors.Hand;
            Auto.DialogResult = DialogResult.OK;
            Auto.Location = new Point(34, 49);
            Auto.Name = "Auto";
            Auto.Size = new Size(130, 32);
            Auto.TabIndex = 0;
            Auto.Text = "&Авто";
            Auto.UseCompatibleTextRendering = true;
            Auto.UseVisualStyleBackColor = true;
            Auto.Click += Auto_Click;
            Auto.MouseEnter += Auto_PreClick;
            Auto.PreviewKeyDown += Manual_PreviewKeyDown;
            // 
            // Manual
            // 
            Manual.AutoSize = true;
            Manual.Cursor = Cursors.Hand;
            Manual.DialogResult = DialogResult.Ignore;
            Manual.Location = new Point(34, 126);
            Manual.Name = "Manual";
            Manual.Size = new Size(130, 32);
            Manual.TabIndex = 1;
            Manual.Text = "&Ручной";
            Manual.UseCompatibleTextRendering = true;
            Manual.UseVisualStyleBackColor = true;
            Manual.Click += Manual_Click;
            Manual.MouseEnter += Manual_PreClick;
            Manual.PreviewKeyDown += Auto_PreviewKeyDown;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(201, 9);
            text.Name = "text";
            text.Size = new Size(82, 20);
            text.TabIndex = 5;
            text.Text = "Описание:";
            // 
            // Auto_text
            // 
            Auto_text.AutoSize = true;
            Auto_text.BackColor = SystemColors.ControlLight;
            Auto_text.BorderStyle = BorderStyle.Fixed3D;
            Auto_text.Location = new Point(201, 29);
            Auto_text.Name = "Auto_text";
            Auto_text.Size = new Size(351, 162);
            Auto_text.TabIndex = 6;
            Auto_text.Text = resources.GetString("Auto_text.Text");
            Auto_text.Click += Auto_text_Click;
            // 
            // Manual_text
            // 
            Manual_text.AutoSize = true;
            Manual_text.BackColor = SystemColors.ControlLight;
            Manual_text.BorderStyle = BorderStyle.Fixed3D;
            Manual_text.Location = new Point(201, 29);
            Manual_text.Name = "Manual_text";
            Manual_text.Size = new Size(352, 162);
            Manual_text.TabIndex = 7;
            Manual_text.Text = resources.GetString("Manual_text.Text");
            Manual_text.Click += Manual_text_Click;
            // 
            // text_null
            // 
            text_null.AutoSize = true;
            text_null.BackColor = SystemColors.ControlLight;
            text_null.BorderStyle = BorderStyle.Fixed3D;
            text_null.Location = new Point(201, 29);
            text_null.Name = "text_null";
            text_null.Size = new Size(351, 162);
            text_null.TabIndex = 8;
            text_null.Text = "\r\n\r\n\r\n                                                                                     \r\n\r\n\r\n\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 9;
            label1.Text = "Выберите режим";
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 206);
            Controls.Add(label1);
            Controls.Add(text_null);
            Controls.Add(Manual_text);
            Controls.Add(Auto_text);
            Controls.Add(text);
            Controls.Add(Manual);
            Controls.Add(Auto);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Choose";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выберите режим";
            FormClosing += IsClosing;
            Load += Choose_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Auto;
        private Button Manual;
        private Label text;
        private Label Auto_text;
        private Label Manual_text;
        private Label text_null;
        private Label label1;
    }
}