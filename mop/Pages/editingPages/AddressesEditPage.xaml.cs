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

namespace mop.Pages.editingPages
{
    /// <summary>
    /// Логика взаимодействия для AddressesEditPage.xaml
    /// </summary>
    public partial class AddressesEditPage : Page
    {
        public static List<Clients> clients { get; set; }
        private Address address1;
        public AddressesEditPage(Address address)
        {
            InitializeComponent();
            address1 = address;
            clients = new List<Clients>(DBConnection.mop.Clients.ToList());
            streetTb.Text = address1.Street;
            houseTb.Text = address1.HouseNumber;
            roomTb.Text = address1.RoomNumber;
            this.DataContext = this;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var client = clientsCb.SelectedItem as Clients;
            if (roomTb.Text == "" || streetTb.Text == "" || houseTb.Text == "")
                MessageBox.Show("Заполните все данные!", "", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (client != null) 
                    address1.ClientID = client.ID;
                address1.Street = streetTb.Text;
                address1.HouseNumber = houseTb.Text;
                address1.RoomNumber = roomTb.Text;
                DBConnection.mop.SaveChanges();
                MessageBox.Show("Данные сохранены!");
                NavigationService.Navigate(new AddressesPage());
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddressesPage());

        }
    }
}
