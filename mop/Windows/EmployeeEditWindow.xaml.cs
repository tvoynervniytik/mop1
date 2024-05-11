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

namespace mop.Windows
{
    /// <summary>
    /// Логика взаимодействия для EmployeeAddWindow.xaml
    /// </summary>
    public partial class EmployeeEditWindow : Window
    {
        public static List<Posts> posts { get; set; }
        public static List<Education> educations { get; set; }
        private Employees empl = AuthorizationFunc.loggedUser;
        private Requests req;
        public EmployeeEditWindow(Requests request)
        {
            InitializeComponent();
            attrTb.Text = request.AtributeName;
            itemTb.Text = request.ItemEditted;
            req = request;
            this.DataContext = this;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Employees employee = AuthorizationFunc.loggedUser;
            if (req.AtributeName == "имя") 
            {
                employee.Name = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            if (req.AtributeName == "фамилия") 
            {
                employee.Surname = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            if (req.AtributeName == "отчество") 
            {
                employee.Patronymic = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            if (req.AtributeName == "почта") 
            {
                employee.Email = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            if (req.AtributeName == "телефон") 
            {
                employee.Phone = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            if (req.AtributeName == "логин") 
            {
                employee.Login = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            if (req.AtributeName == "пароль")
            {
                employee.Password = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }

            if (req.AtributeName == "паспорт") 
            {
                employee.Passport = req.ItemEditted;
                DBConnection.mop.SaveChanges();
            }
            this.Close();
            MessageBox.Show($"Сотрудник {empl.Surname} {empl.Surname.First()}. {empl.Patronymic.First()}. успешно изменён");
            
        }
    }
}
