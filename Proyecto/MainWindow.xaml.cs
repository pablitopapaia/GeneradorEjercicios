using System;
using System.Windows;
using System.Configuration;
using System.Windows.Input;
//using System.Linq;
//using System.Xml.Linq;
using System.Windows.Media;

namespace Proyecto
{
    /// <summary>
    /// Esta ventana se encarga de hacer la función principal del programa.
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private String[] ejerciciosPecho = { "Press de Banca", "Press con mancuerna", "Flexiones" };
        private String[] ejerciciosPierna = { "Extension de cuadriceps", "Zancadas", "Peso muerto" };
        private String[] ejerciciosBrazo = { "Martillo", "Press frances", "Concentrado" };
        private String[] ejerciciosHombro = { "Press de hombro", "Laterales", "Remo al mentón" };
        private String[] ejerciciosEspalda = { "Jalón al pecho", "Remo con mancuerna", "Dominadas" };
        private String[] series = { "3", "4", "5" };
        private String[] repes = { "10", "15", "20" };
        public Window3 ventana3;
        public Window1 ventana1;
        public Window2 ventana2;
        public MainWindow()
        {
            InitializeComponent();
            ventana1 = new Window1(this);
            ventana2 = new Window2(this);
            ventana3 = new Window3(this);
            mEjercicio.KeyDown += mEjercicio_KeyDown;
        }


        private void activa(object sender, EventArgs e)
        {
            if (ventana3.seHaSeleccionado)
            {
                miVentana.Background = new SolidColorBrush(ventana3.colorselecionado);
            }
            else {
                string backgroundColorString = ConfigurationManager.AppSettings["BackgroundColor"];
                string colorBoton = ConfigurationManager.AppSettings["ButtonColor"];
                Color backgroundColor = (Color)ColorConverter.ConvertFromString(backgroundColorString);
                Color backBoton = (Color)ColorConverter.ConvertFromString(colorBoton);
                miVentana.Background = new SolidColorBrush(backgroundColor);
                btnAgregar.Background = new SolidColorBrush(backBoton);
                btnGenerar.Background = new SolidColorBrush(backBoton);
            }
            
        }

        public void mEjercicio_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                Random random = new Random();
                int num = random.Next(ejerciciosPecho.Length);
                if (btnPecho.IsChecked == true)
                {
                    mEjercicio.Content = ejerciciosPecho[num];
                    mSeries.Content = series[num];
                    mRepes.Content = repes[num];
                }
                else if (btnPierna.IsChecked == true)
                {
                    mEjercicio.Content = ejerciciosPierna[num];
                    mSeries.Content = series[num];
                    mRepes.Content = repes[num];
                }
                else if (btnEspalda.IsChecked == true)
                {
                    mEjercicio.Content = ejerciciosEspalda[num];
                    mSeries.Content = series[num];
                    mRepes.Content = repes[num];
                   
                }
                else if (btnBrazo.IsChecked == true)
                {
                    mEjercicio.Content = ejerciciosBrazo[num];
                    mSeries.Content = series[num];
                    mRepes.Content = repes[num];
                }
                else if (btnHombro.IsChecked == true)
                {
                    mEjercicio.Content = ejerciciosHombro[num];
                    mSeries.Content = series[num];
                    mRepes.Content = repes[num];
                }
            }
        }

        public void generar(object sender, EventArgs e) {
            Random random = new Random();
            int num = random.Next(3);
            if (btnPecho.IsChecked == true) 
            {
                mEjercicio.Content = ejerciciosPecho[num];
                mSeries.Content = series[num];
                mRepes.Content = repes[num];
            }
            else if (btnPierna.IsChecked == true) {
                mEjercicio.Content = ejerciciosPierna[num];
                mSeries.Content = series[num];
                mRepes.Content = repes[num];

            } else if(btnEspalda.IsChecked == true)
            {
                mEjercicio.Content = ejerciciosEspalda[num];
                mSeries.Content = series[num];
                mRepes.Content = repes[num];
            }
            else if (btnBrazo.IsChecked == true)
            {
                mEjercicio.Content = ejerciciosBrazo[num];
                mSeries.Content = series[num];
                mRepes.Content = repes[num];
            }
            else if (btnHombro.IsChecked == true)
            {
                mEjercicio.Content = ejerciciosHombro[num];
                mSeries.Content = series[num];
                mRepes.Content = repes[num];
            }
        }

        private void registrarse(object sender, RoutedEventArgs e)
        {
            ventana1.Show();
            this.Hide();
        }

        private void iniciar(object sender, RoutedEventArgs e)
        {
            ventana2.Show();
            this.Hide();
        }
        private void abrirConfig(object sender, RoutedEventArgs e)
        {
            ventana3.Show();
            this.Hide();
        }

        private void cerrar(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Application.Current.Shutdown();
        }


        //No funciona
        private void agregar(object sender, RoutedEventArgs e)
        {
            /*XDocument doc = XDocument.Load(@"../../../Proyecto/ejercicios/ejercicios.xml");

            var ejercicios = from ejercicio in doc.Descendants("ejercicio")
                             select new
                             {
                                 Nombre = ejercicio.Value,
                                 Musculo = ejercicio.Parent.Name.LocalName
                             };

            foreach (var ejercicio in ejercicios)
            {
                switch (ejercicio.Musculo)
                {
                    case "pecho":
                        ejerciciosPecho = ejerciciosPecho.Concat(new String[] { ejercicio.Nombre }).ToArray();
                        break;
                    case "pierna":
                        ejerciciosPierna = ejerciciosPierna.Concat(new String[] { ejercicio.Nombre }).ToArray();
                        break;
                    case "brazo":
                        ejerciciosBrazo = ejerciciosBrazo.Concat(new String[] { ejercicio.Nombre }).ToArray();
                        break;
                    case "hombro":
                        ejerciciosHombro = ejerciciosHombro.Concat(new String[] { ejercicio.Nombre }).ToArray();
                        break;
                    case "espalda":
                        ejerciciosEspalda = ejerciciosEspalda.Concat(new String[] { ejercicio.Nombre }).ToArray();
                        break;
                }
            }*/
        }
    }
}
