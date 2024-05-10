using mop.DB;
using mop.Functions;
using mop.Windows;
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
            if (AuthorizationFunc.loggedUser.PostID == 3) //meneger employees
                requests = new List<Requests>(DBConnection.mop.Requests.ToList());
            else
            {
                requests = new List<Requests>(DBConnection.mop.Requests.
                    Where(i => i.EmployeeID == AuthorizationFunc.loggedUser.ID).ToList());
                mngSp.Visibility = Visibility.Hidden;
            }
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationFunc.loggedUser.PostID == 3) //meneger employees
                NavigationService.Navigate(new MenuSecondPage());
            else
                NavigationService.Navigate(new ProfilePage());
        }
         public void Refresh()
         {
            requestsLv.ItemsSource = new List<Requests>(DBConnection.mop.Requests.ToList());
         }

        private void checkedBtn_Click(object sender, RoutedEventArgs e)
        {
            var a = requestsLv.SelectedItem as Requests;
            DBConnection.mop.Requests.Where(i => i.ID == a.ID).FirstOrDefault().Checking = true;
            Refresh();
        }


        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            var a = requestsLv.SelectedItem as Requests;
            DBConnection.mop.Requests.Where(i => i.ID == a.ID).FirstOrDefault().Done = true;
            DBConnection.mop.SaveChanges();
            Refresh();
        }

        private void requestsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorizationFunc.loggedUser.PostID == 3)
            {
                EmployeeEditWindow employeeEditWindow = new EmployeeEditWindow(requestsLv.SelectedItem as Requests);
                employeeEditWindow.Show();
            }



        }


    }
}
