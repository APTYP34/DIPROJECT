using DIPROJECT._0000;
using DIPROJECT._2Pages;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.MainFrame = MainFrame;
        }

        private void btnCli(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsPage());
            label1.Visibility = Visibility.Collapsed;
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Сброс цвета для всех кнопок
                OrdersOne.Background = Brushes.Transparent;
                HisOrdersOne.Background = Brushes.Transparent;
                SettingsOne.Background = Brushes.Transparent;

                string hexColor = "#FF3C3C5B"; // здесь указываете нужный HEX-код цвета
                SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(hexColor);
                clickedButton.Background = brush;
            }
        }

        
        private void btnOrd_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
            label1.Visibility = Visibility.Collapsed;
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Сброс цвета для всех кнопок
                ClientsOne.Background = Brushes.Transparent;
                HisOrdersOne.Background = Brushes.Transparent;
                SettingsOne.Background = Brushes.Transparent;

                string hexColor = "#FF3C3C5B"; // здесь указываете нужный HEX-код цвета
                SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(hexColor);
                clickedButton.Background = brush;
            }
        }

        private void btnHisOrd(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HisOrdersPage());
            label1.Visibility = Visibility.Collapsed;
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Сброс цвета для всех кнопок
                OrdersOne.Background = Brushes.Transparent;
                ClientsOne.Background = Brushes.Transparent;
                SettingsOne.Background = Brushes.Transparent;

                string hexColor = "#FF3C3C5B"; // здесь указываете нужный HEX-код цвета
                SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(hexColor);
                clickedButton.Background = brush;
            }
        }

        private void btnSett(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SettingsPage());
            label1.Visibility = Visibility.Collapsed;
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Сброс цвета для всех кнопок
                OrdersOne.Background = Brushes.Transparent;
                HisOrdersOne.Background = Brushes.Transparent;
                ClientsOne.Background = Brushes.Transparent;

                string hexColor = "#FF3C3C5B"; // здесь указываете нужный HEX-код цвета
                SolidColorBrush brush = (SolidColorBrush)new BrushConverter().ConvertFromString(hexColor);
                clickedButton.Background = brush;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
