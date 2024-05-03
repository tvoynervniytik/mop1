using mop.DB;
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
    public partial class EmployeeAddWindow : Window
    {
        public static List<Posts> posts { get; set; }
        public static List<Education> educations { get; set; }
        public EmployeeAddWindow()
        {
            InitializeComponent();
            posts = new List<Posts>(DBConnection.mop.Posts.ToList());
            educations = new List<Education>(DBConnection.mop.Education.ToList());
            this.DataContext = this;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show($"Сотрудник {surnameTb.Text} {nameTb.Text.First()}. {patronymicTb.Text.First()}. успешно добавлен");
        }
    }
}
