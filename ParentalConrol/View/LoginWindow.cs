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

        public LoginWindow()
        {
            InitializeComponent();
            _okButton.Click += OkButton_Click;
            _cancelButton.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            this.Close();
            mainWindow.Close();
        }

        private void OkButton_Click(object? sender, EventArgs e)
        {
            if(_passwordTextBox.Text == "1111")
            {
                this.Close();
                mainWindow.Show();
            }
            else
            {
                _messageLabel.ForeColor = Color.FromArgb(237, 123, 126);
                _messageLabel.Text = "Неправильный пароль";
            }
        }
    }
}
