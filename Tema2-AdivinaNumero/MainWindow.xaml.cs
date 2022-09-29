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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero;
        Random semilla;
        public MainWindow()
        {
            InitializeComponent();
            this.semilla = new Random();
            this.numero = semilla.Next(101);
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(textBox.Text)==numero)
            {
                respuestaTextBlock.Text = "Has acertado, Enhorabuena";
            }
            else if(int.Parse(textBox.Text) < numero)
            {
                respuestaTextBlock.Text = "Te has quedado corto, prueba otra vez";
                textBox.Text = "";
            }
            else
            {
                respuestaTextBlock.Text = "Te has pasado, prueba otra vez";
                textBox.Text = "";
            }
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numero = semilla.Next(101);
            respuestaTextBlock.Text = "";
            textBox.Text = "";
        }
    }
}
