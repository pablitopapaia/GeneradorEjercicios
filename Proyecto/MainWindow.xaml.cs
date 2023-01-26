using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
