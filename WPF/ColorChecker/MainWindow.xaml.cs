using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SolidColorBrush scolorBrush = new SolidColorBrush();
            scolorBrush.Color = Color.FromRgb((byte)redSlider.Value, (byte)greenSlider.Value, (byte)blueSlider.Value);
            colerArea.Background = scolorBrush;
        }

        private void stacckBotonn_Click(object sender, RoutedEventArgs e) {
            string format = String.Format("R {0} G {1} B {2}",redSlider.Value,greenSlider.Value,blueSlider.Value);
            colorListbox.Items.Add(format);
            
        }
        private void colorListbox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] Click = colorListbox.SelectedItem.ToString().Split(' ');
            rText.Text = Click[1];
            gText.Text = Click[3];
            bText.Text = Click[5];
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            SolidColorBrush BUr = new SolidColorBrush();
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            BUr.Color = mycolor.Color;
            redSlider.Value = BUr.Color.R;
            greenSlider.Value = BUr.Color.G;
            blueSlider.Value = BUr.Color.B;
            colerArea.Background = BUr;

        }
    }

}


