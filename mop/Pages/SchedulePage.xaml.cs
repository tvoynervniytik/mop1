using mop.DB;
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
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public static List<Orders> orders { get; set; }
        public SchedulePage()
        {
            InitializeComponent();
            if (AuthorizationFunc.loggedUser.PostID == 1)
                orders = new List<Orders>(DBConnection.mop.Orders.Where(i=>i.BrigadeID == AuthorizationFunc.loggedUser.BrigadeID).ToList());
            else
                orders = new List<Orders>(DBConnection.mop.Orders.ToList());
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuFirstPage());
        }
    }
}
