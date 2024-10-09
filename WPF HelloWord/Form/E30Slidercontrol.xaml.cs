using System;
using System.Windows;
using System.Windows.Media;

namespace WPF_HelloWord.Form
{
    /// <summary>
    /// Interaction logic for E30Slidercontrol.xaml
    /// </summary>
    public partial class E30Slidercontrol : Window
    {
        public E30Slidercontrol()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
			Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
			this.Background = new SolidColorBrush(color);
        }
    }
}
