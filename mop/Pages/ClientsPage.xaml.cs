﻿using mop.DB;
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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public static List<Clients> clients {  get; set; }
        public ClientsPage()
        {
            InitializeComponent();
            clients = new List<Clients>(DBConnection.mop.Clients.ToList());
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
