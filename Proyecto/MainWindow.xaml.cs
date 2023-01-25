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
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void generar(object sender, EventArgs e) {
            if (btnPecho.IsChecked == true) 
            {
                mEjercicio.Content = "Press Banca";
                mSeries.Content = "4";
                mRepes.Content = "12";
            }
            else if (btnPierna.IsChecked == true) {
                mEjercicio.Content = "Extension de cuadriceps";
                mSeries.Content = "3";
                mRepes.Content = "20";

            } else if(btnEspalda.IsChecked == true)
            {
                mEjercicio.Content = "Jalon al pecho";
                mSeries.Content = "5";
                mRepes.Content = "15";
            }
            else if (btnBrazo.IsChecked == true)
            {
                mEjercicio.Content = "Martillo";
                mSeries.Content = "5";
                mRepes.Content = "10";
            }
            else if (btnHombro.IsChecked == true)
            {
                mEjercicio.Content = "Elevaciones laterales";
                mSeries.Content = "4";
                mRepes.Content = "12";
            }
        }
    }
}
