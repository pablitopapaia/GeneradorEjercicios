using System.Windows;
using System.Configuration;



namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
       public MainWindow Inicio;
       public Window3(MainWindow ventanaInicio)
        {
            InitializeComponent();
            Inicio = ventanaInicio;
            string miClave = ConfigurationManager.AppSettings["BackgroundColor"];
            string miClave2 = ConfigurationManager.AppSettings["ButtonColor"];
            editFile.Text = miClave;

        }

        private void guardar(object sender, RoutedEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["BackgroundColor"].Value = editFile.Text;
            config.Save();
            this.Close();
            
        }
        private void cerrada(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                e.Cancel = true;
                Inicio.Show();
                this.Hide();
            }
        }
    }
}
