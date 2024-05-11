using mop.DB;
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
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public static List<Employees> employees {  get; set; }
        public EmployeesPage()
        {
            InitializeComponent();
            employees = new List<Employees>(DBConnection.mop.Employees.ToList());
            this.DataContext = this;
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAddWindow employeeAddWindow = new EmployeeAddWindow();
            employeeAddWindow.Show();
        }
        private void delBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
