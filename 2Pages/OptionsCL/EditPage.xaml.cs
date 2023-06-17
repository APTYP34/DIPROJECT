using DIPROJECT._0000;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Клиенты _selectedClient;
        public EditPage(Клиенты selectedClient)
        {
            InitializeComponent();
            _selectedClient = selectedClient;

            // Заполнение TextBox'ов данными выбранного клиента
            txbName.Text = _selectedClient.Имя;
            txbSur.Text = _selectedClient.Фамилия;
            txbPar.Text = _selectedClient.Отчество;
            txbAdres.Text = _selectedClient.Адрес;
            txbTel.Text = _selectedClient.Телефон;
            txbEmail.Text = _selectedClient.Email;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _selectedClient.Имя = txbName.Text;
            _selectedClient.Фамилия = txbSur.Text;
            _selectedClient.Отчество = txbPar.Text;
            _selectedClient.Адрес = txbAdres.Text;
            _selectedClient.Email = txbEmail.Text;
            _selectedClient.Телефон = txbTel.Text;

            // Сохранение изменений в базе данных
            APTYPEntities.GetContext().Entry(_selectedClient).State = EntityState.Modified;
            APTYPEntities.GetContext().SaveChanges();

            // Возвращение на страницу с клиентами
            AppFrame.MainFrame.Navigate(new ClientsPage());
        }
    }
}
