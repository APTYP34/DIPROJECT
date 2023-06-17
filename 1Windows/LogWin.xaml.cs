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
using System.Windows.Shapes;

namespace DIPROJECT._1Windows
{
    /// <summary>
    /// Логика взаимодействия для LogWin.xaml
    /// </summary>
    public partial class LogWin : Window
    {
        public LogWin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            // Здесь проверь логин и пароль пользователя, например, сравнивая их с данными из базы данных
            var user = AppConn.modeldb.Аккаунт.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user != null)
            {

                // Если авторизация успешна, сохраняй данные пользователя в статическом классе UserSession
                UserSession.Login = user.Login;
                UserSession.Password = user.Password;
                UserSession.Name = user.Name;
                UserSession.idRole = user.idRole;

                // Закрой окно авторизации и открой главное окно приложения
                this.Hide();
                MainWindow mainAppWindow = new MainWindow();
                mainAppWindow.ShowDialog();
                this.Close();
            }
            else
            {
                // Отобразите сообщение об ошибке и очистите поля ввода
                label.Visibility = Visibility.Visible;
                txtLogin.Clear();
                txtPassword.Clear();
            }

        }
    }
}
