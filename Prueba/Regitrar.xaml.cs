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

namespace Prueba
{
    /// <summary>
    /// Interaction logic for Regitrar.xaml
    /// </summary>
    public partial class Regitrar : Window
    {
        public Regitrar()
        {
            InitializeComponent();
        }

        private async void Entrar_Click(object sender, RoutedEventArgs e)
        {
            
            db_aa0609_usuariosEntities db = new db_aa0609_usuariosEntities();
            List<string> result = new List<string>();


            result = db.sp_users_register(boxUsuario.Text,passwordBox.Password).ToList();

           await Mensajes(result[0].ToString());

            if (result[0].ToString() == "Registro Exitoso!")
            {
               await Task.Delay(700);
                this.Close();
            }

        }

        public async Task Mensajes(string mensaje)
        {
            menssage.Content = mensaje;
            
        }








        public bool check_pass(string pass,string confpass)
        {
            return true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = passwordTxtBox.Text;
            passwordTxtBox.Visibility = Visibility.Collapsed;
            passwordBox.Visibility = Visibility.Visible;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = passwordBox.Password;
            passwordBox.Visibility = Visibility.Collapsed;
            passwordTxtBox.Visibility = Visibility.Visible;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Login access = new Login();
            access.Show();
        }
    }
}
