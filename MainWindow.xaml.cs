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

namespace TestWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void ButtonReset_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.White;

        private void ButtonRed_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Red;

        private void ButtonGreen_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Green;

        private void ButtonBlue_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Blue;

        private void ButtonCyan_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Cyan;

        private void ButtonMagenta_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Magenta;

        private void ButtonYellow_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Yellow;

        private void ButtonKey_OnClick(object sender, RoutedEventArgs e) => Screen.Background = Brushes.Black;

        private void ButtonCMYK_OnClick(object sender, RoutedEventArgs e)
        {
            StackPanelCMYK.Visibility = Visibility.Visible;
            StackPanelRGB.Visibility = Visibility.Collapsed;
            ButtonCMYK.Background = Brushes.LightGray;
            ButtonRGB.Background = (Brush) new BrushConverter().ConvertFrom("#FFEEEEEE")!;
        }
        
        private void ButtonRGB_OnClick(object sender, RoutedEventArgs e)
        {
            StackPanelRGB.Visibility = Visibility.Visible;
            StackPanelCMYK.Visibility = Visibility.Collapsed;
            ButtonRGB.Background = Brushes.LightGray;
            ButtonCMYK.Background = (Brush) new BrushConverter().ConvertFrom("#FFEEEEEE")!;
        }

    }
}