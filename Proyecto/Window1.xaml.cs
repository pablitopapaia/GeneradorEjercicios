﻿using System;
using System.IO;
using System.Windows;


namespace Proyecto
{
    /// <summary>
    /// Ventana de registro de usuarios
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
           
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
