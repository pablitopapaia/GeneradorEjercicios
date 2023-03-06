using System.Windows;
using System.Configuration;
using System.Windows.Media;
using System.Reflection;

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
       public MainWindow Inicio;
       public Color colorselecionado;
       public bool seHaSeleccionado = false;
       public Window3(MainWindow ventanaInicio)
        {
            InitializeComponent();
            Inicio = ventanaInicio;
            string miClave = ConfigurationManager.AppSettings["BackgroundColor"];
            string miClave2 = ConfigurationManager.AppSettings["ButtonColor"];
            // editFile.Text = miClave;
            Ccolor.ItemsSource = typeof(Colors).GetProperties();
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

        private void Ccolor_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            colorselecionado = (Color)(Ccolor.SelectedItem as PropertyInfo).GetValue(Ccolor, null);
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["BackgroundColor"].Value = colorselecionado+"";
            config.Save();
            seHaSeleccionado = true;
            this.Close();
        }
    }
}
