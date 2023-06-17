using DIPROJECT._0000;
using DIPROJECT._2Pages.OptionsCL;
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

namespace DIPROJECT
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            DGridClients.ItemsSource = APTYPEntities.GetContext().Клиенты.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.Navigate(new AddPage((sender as Button).DataContext as Клиенты));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (DGridClients.SelectedItem != null)
            {
                // Передача выбранного клиента на страницу редактирования
                AppFrame.MainFrame.Navigate(new EditPage(DGridClients.SelectedItem as Клиенты));
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var DeleteRow = DGridClients.SelectedItems.Cast<Клиенты>().ToList();
            APTYPEntities.GetContext().Клиенты.RemoveRange(DeleteRow);
            APTYPEntities.GetContext().SaveChanges();
            AppFrame.MainFrame.Navigate(new ClientsPage());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = txbSearch.Text; // Получение текста из текстового поля поиска
            int searchId;
            bool isIdSearch = int.TryParse(searchQuery, out searchId); // Проверка, является ли текст числом (ID)

            // Запрос к базе данных для поиска клиента по фамилии или ID
            var searchResult = APTYPEntities.GetContext().Клиенты.Where(client =>
            (isIdSearch && client.IDклиента1 == searchId) || (!isIdSearch && client.Фамилия.Contains(searchQuery)));

            // Обновление источника данных DataGrid с результатами поиска
            DGridClients.ItemsSource = searchResult.ToList();

            // Очистка текстового поля поиска
            txbSearch.Clear();
        }
    }
}
