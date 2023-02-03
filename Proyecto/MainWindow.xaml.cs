using System;
using System.Windows;


namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
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
        private Boolean registro = false;
        private Boolean iniciarSesion = false;
        public MainWindow()
        {
            InitializeComponent();
           
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
            cajaLogin.Visibility = Visibility.Visible;
            t1.Visibility = Visibility.Visible;
            t2.Visibility = Visibility.Visible;
            usu.Visibility = Visibility.Visible;
            pass.Visibility = Visibility.Visible;
            botonLog.Visibility = Visibility.Visible;
            registro = true;
        }

        private void iniciar(object sender, RoutedEventArgs e)
        {
            cajaLogin.Visibility = Visibility.Visible;
            t1.Visibility = Visibility.Visible;
            t2.Visibility = Visibility.Visible;
            usu.Visibility = Visibility.Visible;
            pass.Visibility = Visibility.Visible;
            botonLog.Visibility = Visibility.Visible;
            iniciarSesion = true;
        }

        private void Enviar(object sender, RoutedEventArgs e)
        {
            cajaLogin.Visibility = Visibility.Hidden;
            t1.Visibility = Visibility.Hidden;
            t2.Visibility = Visibility.Hidden;
            usu.Visibility = Visibility.Hidden;
            pass.Visibility = Visibility.Hidden;
            botonLog.Visibility = Visibility.Hidden;
            
        }

    }
}
