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
    /// Логика взаимодействия для HisOrdersPage.xaml
    /// </summary>
    public partial class HisOrdersPage : Page
    {
        public HisOrdersPage()
        {
            InitializeComponent();
            DGridHisOrders.ItemsSource = APTYPEntities.GetContext().Историязаказов.ToList();
        }
    }
}
