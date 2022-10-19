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

namespace WpfApp1
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

        private void btn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var btn = sender as Button;

            if (e.LeftButton == MouseButtonState.Pressed)
                btn!.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255)));
            else if (e.RightButton == MouseButtonState.Pressed)
            {
                grid.Children.Remove(btn);
                Title = btn!.Content.ToString();
            }
        }
    }
}
