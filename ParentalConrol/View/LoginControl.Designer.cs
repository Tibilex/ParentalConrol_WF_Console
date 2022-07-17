namespace ParentalConrol.View
{
    partial class LoginControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._loginGroupBox = new System.Windows.Forms.GroupBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._messageLabel = new System.Windows.Forms.Label();
            this._loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _loginGroupBox
            // 
            this._loginGroupBox.Controls.Add(this._messageLabel);
            this._loginGroupBox.Controls.Add(this._passwordTextBox);
            this._loginGroupBox.Controls.Add(this._cancelButton);
            this._loginGroupBox.Controls.Add(this._okButton);
            this._loginGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this._loginGroupBox.Location = new System.Drawing.Point(3, 3);
            this._loginGroupBox.Name = "_loginGroupBox";
            this._loginGroupBox.Size = new System.Drawing.Size(194, 194);
            this._loginGroupBox.TabIndex = 0;
            this._loginGroupBox.TabStop = false;
            this._loginGroupBox.Text = "Авторизация";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(6, 76);
            this._passwordTextBox.MaxLength = 4;
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(182, 23);
            this._passwordTextBox.TabIndex = 2;
            // 
            // _cancelButton
            // 
            this._cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.ForeColor = System.Drawing.Color.Black;
            this._cancelButton.Location = new System.Drawing.Point(6, 163);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(182, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = false;
            this._cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.ForeColor = System.Drawing.Color.Black;
            this._okButton.Location = new System.Drawing.Point(6, 134);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(182, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "OK!";
            this._okButton.UseVisualStyleBackColor = false;
            this._okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // _messageLabel
            // 
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(6, 102);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(38, 15);
            this._messageLabel.TabIndex = 3;
            this._messageLabel.Text = "messageLabel";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Controls.Add(this._loginGroupBox);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(200, 200);
            this._loginGroupBox.ResumeLayout(false);
            this._loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox _loginGroupBox;
        private TextBox _passwordTextBox;
        private Button _cancelButton;
        private Button _okButton;
        private Label _messageLabel;
    }
}
