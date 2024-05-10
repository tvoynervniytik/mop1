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
        private string name;
        private string surname;
        private string patronymic;
        private string email;
        private string phone;
        private string passport;
        private string login;
        private string password;
        private int education;
        public EmployeeEditWindow()
        {
            InitializeComponent();
            posts = new List<Posts>(DBConnection.mop.Posts.ToList());
            educations = new List<Education>(DBConnection.mop.Education.ToList());
            Employees employee = AuthorizationFunc.loggedUser;
            nameTb.Text = employee.Name;
            name = employee.Name;
            //
            surnameTb.Text = employee.Surname;
            surname = employee.Surname;
            //
            emailTb.Text = employee.Email;
            email = employee.Email;
            //
            education = (int)employee.EducationID;
            //
            patronymicTb.Text = employee.Patronymic;
            patronymic = employee.Patronymic;
            //
            passportTb.Text = employee.Passport;
            passport = employee.Passport;
            //
            passwordTb.Text = employee.Password;
            password = employee.Password;
            //
            loginTb.Text = employee.Login;
            login = employee.Login;
            //
            phoneTb.Text = employee.Phone;
            phone = employee.Phone;
            this.DataContext = this;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show($"Сотрудник {surnameTb.Text} {nameTb.Text.First()}. {patronymicTb.Text.First()}. успешно изменён");
        }
    }
}
