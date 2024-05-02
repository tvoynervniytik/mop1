using mop.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mop.Functions
{
    internal class AuthorizationFunc
    {
        private static string login;
        private static string password;
        public static Employees loggedUser;

        public static void Authorization(string login, string password)
        {
            if (login == ""|| password == "") 
            { 
                if (login == "") 
                {
                    MessageBox.Show("Введите логин!", "login error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (password == "") 
                {
                    MessageBox.Show("Введите пароль!", "password error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                loggedUser = DBConnection.mop.Employees.FirstOrDefault(x => x.Login == login & x.Password == password);
                if (loggedUser == null)
                {
                    MessageBox.Show("Пользователь не найден!", "user error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show($"Здравствуйте, {loggedUser.Name.First()}. {loggedUser.Patronymic.First()}. {loggedUser.Surname}");
                }
            }
        }
    }
}
