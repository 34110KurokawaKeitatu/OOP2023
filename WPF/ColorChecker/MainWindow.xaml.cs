using System;
using System.Collections;
using System.Collections.Generic;
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
            var colorlist = GetColorList();
            string format = String.Format("R {0} G {1} B {2}",redSlider.Value,greenSlider.Value,blueSlider.Value);
            var c = colorlist.FirstOrDefault(x => x.Color == ((SolidColorBrush)colerArea.Background).Color)?.Name ?? format;
            MyColor color = new MyColor { Color = ((SolidColorBrush)colerArea.Background).Color, Name = c };

            myColors.Add(color);
            colorListbox.Items.Add(color.Name);

            
        }
        private void colorListbox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var colorlist = GetColorList();
            var a = colorListbox.SelectedItem.ToString();

            foreach (var item in colorlist)
            {
                if( a == item.Name)
                {
                    rText.Text = item.Color.R.ToString();
                    gText.Text = item.Color.G.ToString();
                    bText.Text = item.Color.B.ToString();
                }

            }

            string[] Click = colorListbox.SelectedItem.ToString().Split(' ');
            if(Click.Length > 4)
            {
                rText.Text = Click[1];
                gText.Text = Click[3];
                bText.Text = Click[5];
            }
         
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }
        List<MyColor> myColors = new List<MyColor>();

        public class StackColor {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }

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


