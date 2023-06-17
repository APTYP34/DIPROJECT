using DIPROJECT._0000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DIPROJECT._2Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Используй данные из UserSession для отображения информации о пользователе
            txbLog.Text = UserSession.Login;
            txbPass.Text = UserSession.Password;
            txbRole.Text = UserSession.idRole;

            lblName.Content = UserSession.Name;
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            string newLogin = txtNewLogin.Text;
            string newPassword = txtNewPassword.Password;

            // Проверьте введенные новые данные (например, на пустоту или соответствие требованиям безопасности)
            if (string.IsNullOrEmpty(newLogin) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Пожалуйста, введите новый логин и пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
        }

        public void UpdateUser(Аккаунт user)
        {
            var existingUser = AppConn.modeldb.Аккаунт.FirstOrDefault(u => u.Login == user.Login & u.Password == user.Password);
            if (existingUser != null)
            {
                existingUser.Login = user.Login;
                existingUser.Password = user.Password;
                existingUser.Name = user.Name;
                existingUser.idRole = user.idRole;

                APTYPEntities.GetContext().SaveChanges();
            }
        }
    }
}
