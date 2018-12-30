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

namespace JohnMartinHW3
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sliderX.IsSelected)
            {
                slider1.IsEnabled = true;
                slider2.IsEnabled = false;
                slider3.IsEnabled = false;
            } else if (sliderY.IsSelected)
            {
                slider1.IsEnabled = false;
                slider2.IsEnabled = true;
                slider3.IsEnabled = false;
            } else if (sliderZ.IsSelected)
            {
                slider1.IsEnabled = false;
                slider2.IsEnabled = false;
                slider3.IsEnabled = true;
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (progress.IsEnabled)
            {
                pb.IsEnabled = true;
                tb.IsEnabled = false;
            } else if (text.IsEnabled)
            {
                pb.IsEnabled = false;
                tb.IsEnabled = true;
            }
        }

        private void pb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider1.IsEnabled)
                pb.Value = slider1.Value;
            else if (slider2.IsEnabled)
                pb.Value = slider2.Value;
            else if (slider3.IsEnabled)
                pb.Value = slider3.Value;
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb.IsEnabled == true)
            {
                if (slider1.IsEnabled)
                    tb.Text = slider1.Value.ToString();
                else if (slider2.IsEnabled)
                    tb.Text = slider2.Value.ToString();
                else if (slider3.IsEnabled)
                    tb.Text = slider3.Value.ToString();
            }
            
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progress.IsSelected)
                pb.Value = slider1.Value;
            else if (text.IsSelected)
                tb.Text = slider1.Value.ToString();
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progress.IsSelected)
                pb.Value = slider2.Value;
            else if (text.IsSelected)
                tb.Text = slider2.Value.ToString();
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progress.IsSelected)
                pb.Value = slider3.Value;
            else if (text.IsSelected)
                tb.Text = slider3.Value.ToString();
        }
    }
}
