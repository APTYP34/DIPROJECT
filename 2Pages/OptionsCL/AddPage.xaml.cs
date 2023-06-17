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

namespace DIPROJECT._2Pages.OptionsCL
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        private Клиенты _currentClient = new Клиенты();
        public AddPage(Клиенты _selectedClient)
        {
            InitializeComponent();
            if (_selectedClient != null)
                _currentClient = _selectedClient;

            DataContext = _currentClient;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Клиенты newClient = new Клиенты
            {
                // Заполнение полей нового клиента (пример)
                Имя = txbName.Text,
                Фамилия = txbSur.Text,
                Отчество = txbPar.Text,
                Адрес = txbAdres.Text,
                Телефон = txbTel.Text,
                Email = txbEmail.Text
            };

            // Добавление нового клиента в контекст
            APTYPEntities.GetContext().Клиенты.Add(newClient);

            // Сохранение изменений в базе данных
            APTYPEntities.GetContext().SaveChanges();

            // Обновление страницы (или переход на другую страницу, если необходимо)
            AppFrame.MainFrame.Navigate(new ClientsPage());
        }
    }
}
