using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using System.Xml;

namespace Prueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        

        public MainWindow(string nombre)
        {
            InitializeComponent();

            Usuario1.Content = "Usuario: " +nombre;
        }

         

      

        private void Button1Scra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string hoy = DateTime.Today.ToString("dd/MM/yyyy");
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(@"https://www.banxico.org.mx/tipcamb/tipCamMIAction.do");


                var nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("renglonNon"));
                foreach (var renglon in nodes.Where(n => n.Name == "tr").Take(1))
                {
                    var celdas = renglon.Elements("td").ToArray();





                    FechaScra1.Content = celdas[0].InnerText.Replace("\r\n", "").Trim();
                    FIXScra1.Content = celdas[1].InnerText.Replace("\r\n", "").Trim();
                    DOFScra1.Content = celdas[2].InnerText.Replace("\r\n", "").Trim();
                    Para_Pagos1.Content = celdas[3].InnerText.Replace("\r\n", "").Trim();





                }

            }
            catch (Exception r)
            {
                string tem = r.Message;
            }

        }


        private void Button1API_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.currencylayer.com/live?access_key=445773ed3f7c77a8b1a7e45fc25b6cc4&currencies=MXN");
             
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
             
            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                var aux = response.Content.ReadAsStringAsync();
                 var result = JsonConvert.DeserializeObject<classappiresult>(aux.Result);
                ValorApi1.Content = result.quotes.USDMXN.ToString();                  
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase.ToString());
            }          


            client.Dispose();
        }



     




    }
}
