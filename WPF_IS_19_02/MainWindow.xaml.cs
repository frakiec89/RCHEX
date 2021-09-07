﻿using System;
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

namespace WPF_IS_19_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
       
        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = Authentication.AuthenticationUser(tbName.Text, tbPass.Text);
                View.WindowMenu menu = new View.WindowMenu();
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Authentication
    {
        public  static DB.User AuthenticationUser (string login , string password)
        {
            try
            {
                DB.dEntities entities = new DB.dEntities();
                var user = entities.User.Single(x => x.Login == login && x.Password == password);
                if (user != null) return user;
                else throw new Exception($"пользователь не найден\r ");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка авторизации \r {ex.Message}");
            }
        }
    }
}