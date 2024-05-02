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

        public void Authorization(string login, string password)
        {
            if (login == null || password == null) 
            { 
                if (login == null) 
                {
                    MessageBox.Show("Введите логин!", "login error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (password == null) 
                {
                    MessageBox.Show("Введите пароль!", "password error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                
            }
        }
    }
}
