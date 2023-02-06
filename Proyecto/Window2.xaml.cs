using System;
using System.IO;
using System.Windows;


namespace Proyecto
{
    /// <summary>
    /// Esta ventana se encarga del login
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void Enviar(object sender, RoutedEventArgs e)
        {
            String rutaFichero = @"../../../Proyecto/usuarios/usuarios.txt";
            foreach (string line in File.ReadLines(rutaFichero))
            {
                if (line.Split(':')[0].Equals(usu.Text.ToString()) && line.Split(':')[1].Equals(pass.Password.ToString()))
                {
                    Close();
                }
            }
        }
    }
}
