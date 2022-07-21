namespace ParentalConrol.View
{
    partial class LoginWindow
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
            this._loginGroupBox = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this._textLabel = new System.Windows.Forms.Label();
            this._loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _loginGroupBox
            // 
            this._loginGroupBox.Controls.Add(this._textLabel);
            this._loginGroupBox.Controls.Add(this.messageLabel);
            this._loginGroupBox.Controls.Add(this.passwordTextBox);
            this._loginGroupBox.Controls.Add(this.cancelButton);
            this._loginGroupBox.Controls.Add(this.okButton);
            this._loginGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this._loginGroupBox.Location = new System.Drawing.Point(3, 3);
            this._loginGroupBox.Name = "_loginGroupBox";
            this._loginGroupBox.Size = new System.Drawing.Size(194, 194);
            this._loginGroupBox.TabIndex = 0;
            this._loginGroupBox.TabStop = false;
            this._loginGroupBox.Text = "Авторизация";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(6, 102);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 15);
            this.messageLabel.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 76);
            this.passwordTextBox.MaxLength = 4;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(182, 23);
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(6, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(182, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(6, 134);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(182, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK!";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // _textLabel
            // 
            this._textLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._textLabel.Location = new System.Drawing.Point(9, 19);
            this._textLabel.Name = "_textLabel";
            this._textLabel.Size = new System.Drawing.Size(176, 54);
            this._textLabel.TabIndex = 4;
            this._textLabel.Text = "Введите пароль";
            this._textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this._loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this._loginGroupBox.ResumeLayout(false);
            this._loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox _loginGroupBox;
        private TextBox passwordTextBox;
        private Button cancelButton;
        private Button okButton;
        private Label messageLabel;
        private Label _textLabel;
    }
}