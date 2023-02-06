using System;
using System.Windows;
using System.Windows.Input;

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
        
        public static String Registro;
        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            mEjercicio.KeyDown += mEjercicio_KeyDown;
        }

        public void mEjercicio_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                Random random = new Random();
                int num = random.Next(3);
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
            Window1 w = new Window1();
            w.Show();
        }

        private void iniciar(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
        }

        private void agregar(object sender, RoutedEventArgs e)
        {

        }
    }
}
