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
using System.Windows.Shapes;

namespace mop.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditBrigade.xaml
    /// </summary>
    public partial class EditBrigade : Window
    {
        public static List<Employees> employees { get; set; }
        private static Brigades brigades;
        public EditBrigade(Brigades brigade)
        {
            InitializeComponent();
            brigades = brigade;
            employees = new List<Employees>(DBConnection.mop.Employees.Where(i => i.PostID == 1 & i.BrigadeID != null).ToList());
            this.DataContext = this;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
