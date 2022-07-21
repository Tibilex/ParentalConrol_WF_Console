using Microsoft.Win32;
using ParentalConrol.View;
using System.Diagnostics;
using System.Management;
using System.Text.RegularExpressions;

namespace ParentalConrol
{
    public partial class MainWindow : Form
    {
        LoginWindow login;
        private string _licenceKey = "I love C++";
        List<string> list_names = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            this.Load += MainWindow_Load;
            getPremiumBtn.Click += GetPremiumBtn_Click;
            keyFieldTextBox.Click += KeyFieldTextBox_Click;
        }

        #region Events
        private void KeyFieldTextBox_Click(object? sender, EventArgs e)
        {
            keyFieldTextBox.Text = "";
        }

        private void GetPremiumBtn_Click(object? sender, EventArgs e)
        {
            if(keyFieldTextBox.Text == _licenceKey)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Parent Control").SetValue("LicenceKey", _licenceKey);
                LicenceCheck();
            }
            else
            {
                keyFieldTextBox.Text = "Неверный ключ";
            }
        }

        private void MainWindow_Load(object? sender, EventArgs e)
        {
            login = new LoginWindow();
            login.mainWindow = this;
            login.ShowDialog();
            LicenceCheck();
            GetAllInstalledApp();
        }

        #endregion

        private void LicenceCheck()
        {
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Parent Control"))
            {
                var licenceKey = registryKey?.GetValue("LicenceKey")?.ToString();
                if(licenceKey != null)
                {
                    premiumSectionGB.Enabled = true;
                    keyFieldTextBox.Text = "Активировано";
                    getPremiumBtn.Enabled = false;
                    keyFieldTextBox.Enabled = false;
                }
            }
        }

        private async void GetAllInstalledApp()
        {
            //string displayName;
            //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store"))
            //{
            //    foreach (var programmPath in key.GetValueNames())
            //    {
            //        displayName = Regex.Match(programmPath, @".*\\(.*)\.exe").Groups[1].Value;
            //        applicationListBox.Items.Add(displayName);
            //    }
            //}
            await Task.Run(async () => {
                //using (RegistryKey reg_key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
                using (RegistryKey reg_key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
                {
                    string[] arr_app_names = reg_key.GetSubKeyNames();
                    foreach (var item_app_name in arr_app_names)
                    {
                        using (RegistryKey app_key = reg_key.OpenSubKey(item_app_name))
                        {
                            string display_name = app_key?.GetValue("DisplayName")?.ToString();
                            string app_name = app_key?.GetValue("DisplayIcon")?.ToString();
                            if (app_name != null && display_name != null && app_name.Contains(".exe"))
                            {
                                string process_name = Regex.Match(app_name, @".*\\(.*)\.exe").Groups[1].Value;
                                foreach (var item in Process.GetProcessesByName(process_name))
                                {
                                    if (!list_names.Contains(display_name))
                                    {
                                        list_names.Add(display_name);
                                    }
                                }
                            }
                        }
                    }
                    list_names.ForEach(Console.WriteLine);

                    applicationListBox.Items.AddRange(list_names.ToArray());
                }
                await Task.Delay(1);
            });

        }
    }
}