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
            var itemssource = new List<Requests>(DBConnection.mop.Requests.ToList());

            //условие
            if (surnameTb.Text == "") { }
            else
                itemssource = itemssource.Where(i => i.Employees.Surname.ToLower().StartsWith(surnameTb.Text.Trim().ToLower())).ToList();
            if (dateDp.SelectedDate == null) { }
            else //dateDp
                itemssource = itemssource.Where(i => i.Date == (DateTime)dateDp.SelectedDate).ToList();
            if (checkingCb.SelectedItem == null || checkingCb.SelectedIndex == 0) { }
            else //checkingCb
                if (checkingCb.SelectedIndex == 1)
                    itemssource = itemssource.Where(i => i.Checking == true).ToList();
                else
                    itemssource = itemssource.Where(i => i.Checking == false).ToList();
            if (doneCb.SelectedItem == null || doneCb.SelectedIndex == 0) { }
            else //doneCb
                if (doneCb.SelectedIndex == 1)
                    itemssource = itemssource.Where(i => i.Done == true).ToList();
                else
                    itemssource = itemssource.Where(i => i.Done == false).ToList();

            requestsLv.ItemsSource = itemssource;
         }

        private void checkedBtn_Click(object sender, RoutedEventArgs e)
        {
            var a = requestsLv.SelectedItem as Requests;
            DBConnection.mop.Requests.Where(i => i.ID == a.ID).FirstOrDefault().Checking = true;
            Refresh();
        }
        private void requestsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorizationFunc.loggedUser.PostID == 3)
            { 
                var a = requestsLv.SelectedItem as Requests;
                if (a.Checking == true)
                {
                    if (a.Done == true) MessageBox.Show
                        ("Запрос уже исполнен!", "done error", MessageBoxButton.OK, MessageBoxImage.Error);
                    else
                    {
                        EmployeeEditWindow employeeEditWindow = new EmployeeEditWindow(a);
                        employeeEditWindow.Show();
                    }
                    
                }
                else MessageBox.Show
                        ("Проверка данного запроса не проведена, проверьте документы!", "checking error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void doneCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void checkingCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void surnameTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void dateDp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
