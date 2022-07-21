using ParentalConrol.View;

namespace ParentalConrol
{
    public partial class MainWindow : Form
    {
        LoginWindow login;
        public MainWindow()
        {
            InitializeComponent();
            this.Load += MainWindow_Load;
        }

        private void MainWindow_Load(object? sender, EventArgs e)
        {
            login = new LoginWindow();
            login.mainWindow = this;
            login.ShowDialog();
        }
    }
}