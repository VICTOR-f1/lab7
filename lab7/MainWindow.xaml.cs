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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(20, 50);
            TranslateTransform trans = new TranslateTransform();
            b1.RenderTransform = trans;
            DoubleAnimation daX = new DoubleAnimation(0, b1.ActualWidth + x, TimeSpan.FromSeconds(1));
            trans.BeginAnimation(TranslateTransform.XProperty, daX);
            DoubleAnimation daY = new DoubleAnimation(0, b1.ActualHeight + x, TimeSpan.FromSeconds(1));
            trans.BeginAnimation(TranslateTransform.YProperty, daY);
        }
    }
}
