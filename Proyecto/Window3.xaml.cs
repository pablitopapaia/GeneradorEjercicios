using System.Windows;
using System.IO;
using System.Configuration;
using System;


namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            string miClave = ConfigurationManager.AppSettings["BackgroundColor"];
            string miClave2 = ConfigurationManager.AppSettings["ButtonColor"];
            editFile.Text = miClave;

        }

        private void guardar(object sender, RoutedEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["BackgroundColor"].Value = editFile.Text;
            config.Save();
            Close();
        }
    }
}
