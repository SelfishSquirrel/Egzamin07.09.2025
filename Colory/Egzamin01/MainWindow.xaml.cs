using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Egzamin01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            UpdateSecondRect();
        }

        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(RValue == null || RValueRect == null)
                return; 
            RValue.Text = ((int)sliderR.Value).ToString();
            RValueRect.Text = ((int)sliderR.Value).ToString();
            UpdateMainRectagleColor();
        }

        private void sliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(GValue == null || GValueRect == null)
                return; 
            GValue.Text = ((int)sliderG.Value).ToString();
            GValueRect.Text = ((int)sliderG.Value).ToString();
            UpdateMainRectagleColor();
        }

        private void sliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(BValue == null || BValueRect == null)
                return; 
            BValue.Text = ((int)sliderB.Value).ToString();
            BValueRect.Text = ((int)sliderB.Value).ToString();
            UpdateMainRectagleColor();
        }

        private void UpdateMainRectagleColor()
        {
            if(mainRect == null)
                return;
            mainRect.Fill = new SolidColorBrush(Color.FromRgb((byte)sliderR.Value, (byte)sliderG.Value, (byte)sliderB.Value));
        }

        private void UpdateSecondRect()
        {
            if(secondRect == null)
                return; 
            secondRect.Fill = new SolidColorBrush(Color.FromRgb((byte)sliderR.Value, (byte)sliderG.Value, (byte)sliderB.Value));
        }
    }
}