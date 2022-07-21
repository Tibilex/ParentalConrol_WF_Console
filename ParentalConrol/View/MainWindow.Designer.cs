namespace ParentalConrol
{
    partial class MainWindow
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
            this.freeSectionGB = new System.Windows.Forms.GroupBox();
            this.accessTimeComboBox = new System.Windows.Forms.ComboBox();
            this.timeLaunchBtn = new System.Windows.Forms.Button();
            this._messageLabel = new System.Windows.Forms.Label();
            this.enableLaunchBtn = new System.Windows.Forms.Button();
            this.disableLaunchBtn = new System.Windows.Forms.Button();
            this.premiumSectionGB = new System.Windows.Forms.GroupBox();
            this.getRunTimeBtn = new System.Windows.Forms.Button();
            this.saveOpenAppBtn = new System.Windows.Forms.Button();
            this.getOpenAppStatBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appListGB = new System.Windows.Forms.GroupBox();
            this.applicationListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyFieldTextBox = new System.Windows.Forms.TextBox();
            this.getPremiumBtn = new System.Windows.Forms.Button();
            this.freeSectionGB.SuspendLayout();
            this.premiumSectionGB.SuspendLayout();
            this.appListGB.SuspendLayout();
            this.statisticGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // freeSectionGB
            // 
            this.freeSectionGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.freeSectionGB.Controls.Add(this.accessTimeComboBox);
            this.freeSectionGB.Controls.Add(this.timeLaunchBtn);
            this.freeSectionGB.Controls.Add(this._messageLabel);
            this.freeSectionGB.Controls.Add(this.enableLaunchBtn);
            this.freeSectionGB.Controls.Add(this.disableLaunchBtn);
            this.freeSectionGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.freeSectionGB.Location = new System.Drawing.Point(293, 12);
            this.freeSectionGB.Name = "freeSectionGB";
            this.freeSectionGB.Size = new System.Drawing.Size(194, 150);
            this.freeSectionGB.TabIndex = 1;
            this.freeSectionGB.TabStop = false;
            this.freeSectionGB.Text = "FREE - секция";
            // 
            // accessTimeComboBox
            // 
            this.accessTimeComboBox.FormattingEnabled = true;
            this.accessTimeComboBox.Items.AddRange(new object[] {
            "5 мин. ",
            "10 мин",
            "30 мин.",
            "60 мин.",
            "120 мин.",
            "240 мин."});
            this.accessTimeComboBox.Location = new System.Drawing.Point(6, 80);
            this.accessTimeComboBox.Name = "accessTimeComboBox";
            this.accessTimeComboBox.Size = new System.Drawing.Size(182, 23);
            this.accessTimeComboBox.TabIndex = 5;
            // 
            // timeLaunchBtn
            // 
            this.timeLaunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.timeLaunchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeLaunchBtn.ForeColor = System.Drawing.Color.Black;
            this.timeLaunchBtn.Location = new System.Drawing.Point(6, 109);
            this.timeLaunchBtn.Name = "timeLaunchBtn";
            this.timeLaunchBtn.Size = new System.Drawing.Size(182, 23);
            this.timeLaunchBtn.TabIndex = 4;
            this.timeLaunchBtn.Text = "Запуск на время";
            this.timeLaunchBtn.UseVisualStyleBackColor = false;
            // 
            // _messageLabel
            // 
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(6, 102);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(0, 15);
            this._messageLabel.TabIndex = 3;
            // 
            // enableLaunchBtn
            // 
            this.enableLaunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.enableLaunchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enableLaunchBtn.ForeColor = System.Drawing.Color.Black;
            this.enableLaunchBtn.Location = new System.Drawing.Point(6, 51);
            this.enableLaunchBtn.Name = "enableLaunchBtn";
            this.enableLaunchBtn.Size = new System.Drawing.Size(182, 23);
            this.enableLaunchBtn.TabIndex = 1;
            this.enableLaunchBtn.Text = "Разрешить запуск";
            this.enableLaunchBtn.UseVisualStyleBackColor = false;
            // 
            // disableLaunchBtn
            // 
            this.disableLaunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.disableLaunchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.disableLaunchBtn.ForeColor = System.Drawing.Color.Black;
            this.disableLaunchBtn.Location = new System.Drawing.Point(6, 22);
            this.disableLaunchBtn.Name = "disableLaunchBtn";
            this.disableLaunchBtn.Size = new System.Drawing.Size(182, 23);
            this.disableLaunchBtn.TabIndex = 0;
            this.disableLaunchBtn.Text = "Запретить запуск";
            this.disableLaunchBtn.UseVisualStyleBackColor = false;
            // 
            // premiumSectionGB
            // 
            this.premiumSectionGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.premiumSectionGB.Controls.Add(this.getRunTimeBtn);
            this.premiumSectionGB.Controls.Add(this.saveOpenAppBtn);
            this.premiumSectionGB.Controls.Add(this.getOpenAppStatBtn);
            this.premiumSectionGB.Controls.Add(this.label2);
            this.premiumSectionGB.Enabled = false;
            this.premiumSectionGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.premiumSectionGB.Location = new System.Drawing.Point(293, 173);
            this.premiumSectionGB.Name = "premiumSectionGB";
            this.premiumSectionGB.Size = new System.Drawing.Size(194, 121);
            this.premiumSectionGB.TabIndex = 5;
            this.premiumSectionGB.TabStop = false;
            this.premiumSectionGB.Text = "PREMIUM - секция";
            // 
            // getRunTimeBtn
            // 
            this.getRunTimeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.getRunTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getRunTimeBtn.ForeColor = System.Drawing.Color.Black;
            this.getRunTimeBtn.Location = new System.Drawing.Point(6, 51);
            this.getRunTimeBtn.Name = "getRunTimeBtn";
            this.getRunTimeBtn.Size = new System.Drawing.Size(182, 23);
            this.getRunTimeBtn.TabIndex = 6;
            this.getRunTimeBtn.Text = "Просмотреть время работы";
            this.getRunTimeBtn.UseVisualStyleBackColor = false;
            // 
            // saveOpenAppBtn
            // 
            this.saveOpenAppBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.saveOpenAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveOpenAppBtn.ForeColor = System.Drawing.Color.Black;
            this.saveOpenAppBtn.Location = new System.Drawing.Point(6, 80);
            this.saveOpenAppBtn.Name = "saveOpenAppBtn";
            this.saveOpenAppBtn.Size = new System.Drawing.Size(182, 23);
            this.saveOpenAppBtn.TabIndex = 5;
            this.saveOpenAppBtn.Text = "Сохранить список прог.";
            this.saveOpenAppBtn.UseVisualStyleBackColor = false;
            // 
            // getOpenAppStatBtn
            // 
            this.getOpenAppStatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.getOpenAppStatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getOpenAppStatBtn.ForeColor = System.Drawing.Color.Black;
            this.getOpenAppStatBtn.Location = new System.Drawing.Point(6, 22);
            this.getOpenAppStatBtn.Name = "getOpenAppStatBtn";
            this.getOpenAppStatBtn.Size = new System.Drawing.Size(182, 23);
            this.getOpenAppStatBtn.TabIndex = 4;
            this.getOpenAppStatBtn.Text = "Просмотреть открытые";
            this.getOpenAppStatBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // appListGB
            // 
            this.appListGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appListGB.Controls.Add(this.applicationListBox);
            this.appListGB.Controls.Add(this.label1);
            this.appListGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.appListGB.Location = new System.Drawing.Point(12, 12);
            this.appListGB.Name = "appListGB";
            this.appListGB.Size = new System.Drawing.Size(275, 337);
            this.appListGB.TabIndex = 6;
            this.appListGB.TabStop = false;
            this.appListGB.Text = "Все приложения";
            // 
            // applicationListBox
            // 
            this.applicationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.applicationListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applicationListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.applicationListBox.FormattingEnabled = true;
            this.applicationListBox.ItemHeight = 15;
            this.applicationListBox.Location = new System.Drawing.Point(6, 22);
            this.applicationListBox.Name = "applicationListBox";
            this.applicationListBox.Size = new System.Drawing.Size(263, 300);
            this.applicationListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // statisticGB
            // 
            this.statisticGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticGB.Controls.Add(this.label3);
            this.statisticGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.statisticGB.Location = new System.Drawing.Point(494, 12);
            this.statisticGB.Name = "statisticGB";
            this.statisticGB.Size = new System.Drawing.Size(294, 337);
            this.statisticGB.TabIndex = 7;
            this.statisticGB.TabStop = false;
            this.statisticGB.Text = "Статистика запусков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // keyFieldTextBox
            // 
            this.keyFieldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyFieldTextBox.Location = new System.Drawing.Point(299, 300);
            this.keyFieldTextBox.MaxLength = 24;
            this.keyFieldTextBox.Name = "keyFieldTextBox";
            this.keyFieldTextBox.Size = new System.Drawing.Size(182, 23);
            this.keyFieldTextBox.TabIndex = 7;
            this.keyFieldTextBox.Text = "I love C++";
            this.keyFieldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getPremiumBtn
            // 
            this.getPremiumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getPremiumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.getPremiumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getPremiumBtn.ForeColor = System.Drawing.Color.Black;
            this.getPremiumBtn.Location = new System.Drawing.Point(299, 326);
            this.getPremiumBtn.Name = "getPremiumBtn";
            this.getPremiumBtn.Size = new System.Drawing.Size(182, 23);
            this.getPremiumBtn.TabIndex = 7;
            this.getPremiumBtn.Text = "Активировать премиум";
            this.getPremiumBtn.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.getPremiumBtn);
            this.Controls.Add(this.keyFieldTextBox);
            this.Controls.Add(this.statisticGB);
            this.Controls.Add(this.appListGB);
            this.Controls.Add(this.premiumSectionGB);
            this.Controls.Add(this.freeSectionGB);
            this.MinimumSize = new System.Drawing.Size(816, 400);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Родительский Контроль";
            this.freeSectionGB.ResumeLayout(false);
            this.freeSectionGB.PerformLayout();
            this.premiumSectionGB.ResumeLayout(false);
            this.premiumSectionGB.PerformLayout();
            this.appListGB.ResumeLayout(false);
            this.appListGB.PerformLayout();
            this.statisticGB.ResumeLayout(false);
            this.statisticGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox freeSectionGB;
        private ComboBox accessTimeComboBox;
        private Button timeLaunchBtn;
        private Label _messageLabel;
        private Button enableLaunchBtn;
        private Button disableLaunchBtn;
        private GroupBox premiumSectionGB;
        private Label label2;
        private GroupBox appListGB;
        private Label label1;
        private GroupBox statisticGB;
        private Label label3;
        private Button getRunTimeBtn;
        private Button saveOpenAppBtn;
        private Button getOpenAppStatBtn;
        private TextBox keyFieldTextBox;
        private Button getPremiumBtn;
        private ListBox applicationListBox;
    }
}