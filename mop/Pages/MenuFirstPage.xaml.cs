using mop.Functions;
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

namespace mop.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuFirstPage.xaml
    /// </summary>
    public partial class MenuFirstPage : Page
    {
        public MenuFirstPage()
        {
            InitializeComponent();
            if (AuthorizationFunc.loggedUser.PostID == 2)
            {
                OrderBtn.Content = "оформление заказа";
            }
            if (AuthorizationFunc.loggedUser.PostID == 3)
            {
                OrderBtn.Content = "формирование бригады";
            }
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationFunc.loggedUser.PostID == 2)
            {
                NavigationService.Navigate(new OrdersPage());
            }
            if (AuthorizationFunc.loggedUser.PostID == 3)
            {
                NavigationService.Navigate(new AddBrigadesPage());
            }
        }

        private void InfBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuSecondPage());
        }

        private void ScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SchedulePage());
        }
    }
}
