using System;
using System.IO;
using System.Windows;


namespace Proyecto
{
    /// <summary>
    /// Ventana de registro de usuarios
    /// </summary>
    public partial class Window1 : Window
    {
        public MainWindow Inicio;
        public Window1(MainWindow ventana)
        {
            InitializeComponent();
            Inicio = ventana;
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

        private void Enviar(object sender, RoutedEventArgs e)
        {
            String texto = usu.Text.ToString() + ":" + pass.Password.ToString();
            String rutaFichero = "usuarios.txt";

            using (StreamWriter streamWriter = File.AppendText(rutaFichero)) {
                streamWriter.WriteLine(texto);
            }
            Close();
        }

    }
}
