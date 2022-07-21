using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalConrol.View
{
    public partial class LoginWindow : Form
    {
        public MainWindow mainWindow { get; set; }
        private int _password = 1111;
        public LoginWindow()
        {
            InitializeComponent();
            okButton.Click += OkButton_Click;
            cancelButton.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            this.Close();
            mainWindow.Close();
        }

        private void OkButton_Click(object? sender, EventArgs e)
        {
            if(passwordTextBox.Text == _password.ToString())
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Parent Control").SetValue("LoginKey", _password);
                this.Close();
                mainWindow.Show();
            }
            else
            {
                messageLabel.ForeColor = Color.FromArgb(237, 123, 126);
                messageLabel.Text = "Неправильный пароль";
            }
        }
    }
}
