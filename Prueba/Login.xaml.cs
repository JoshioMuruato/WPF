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
using Prueba;

namespace Prueba
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            menssage.Visibility = Visibility.Hidden;
        }
        public string nameusuario { get; set; }

        private void Entrar_Click(object sender, RoutedEventArgs e)
        {
            menssage.Visibility = Visibility.Hidden;
            try
            {
                List<string> result = new List<string>();

                  db_aa0609_usuariosEntities db = new db_aa0609_usuariosEntities();
                  result = db.sp_users_app(boxUser.Text, boxPass.Password).ToList();



                if (result[0].ToString() != "Success")
                {
                    menssage.Content = result[0].ToString();
                    menssage.Visibility = Visibility.Visible;
                    
                }
                else
                {
                    nameusuario = boxUser.Text;
                    MainWindow tiposdecambio = new MainWindow(nameusuario);
                    tiposdecambio.Show();
                    this.Close();

                }






            }
            catch(Exception a)
            {
                string ar = a.Message;
            }
             
        }

        private void Registro_Click(object sender, RoutedEventArgs e)
        {
            Regitrar win = new Regitrar();
            win.Show();
            this.Close();
        }




    }
}
