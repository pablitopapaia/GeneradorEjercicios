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
        private bool loginBien;
        public MainWindow Inicio;
        public Window2(MainWindow ventana)
        {
            InitializeComponent();
            Inicio = ventana;
        }

        private void Enviar(object sender, RoutedEventArgs e)
        {
            String rutaFichero = "usuarios.txt";
            foreach (string line in File.ReadLines(rutaFichero))
            {
                if (line.Split(':')[0].Equals(usu.Text.ToString()) && line.Split(':')[1].Equals(pass.Password.ToString()))
                {
                    loginBien = true;
                    Close();
                }
            }
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

        public bool getLoginBien() {
            return loginBien;
        }
        public void setLoginBien(bool loginBien) {
            this.loginBien = loginBien;
        }
    }
}
