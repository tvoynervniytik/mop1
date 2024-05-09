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
    /// Логика взаимодействия для RequestsPage.xaml
    /// </summary>
    public partial class RequestsPage : Page
    {
        public static List<Requests> requests { get; set; }
        public RequestsPage()
        {
            InitializeComponent();
            if (AuthorizationFunc.loggedUser.PostID == 3)
                requests = new List<Requests>(DBConnection.mop.Requests.ToList());
            else
                requests = new List<Requests>(DBConnection.mop.Requests.
                    Where(i => i.EmployeeID == AuthorizationFunc.loggedUser.ID).ToList());
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuSecondPage());
        }

    }
}
