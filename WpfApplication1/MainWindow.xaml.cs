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

namespace WpfApplication1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LeftButton.Click += LeftButtonClick;
            this.RightButton.Click += RightButtonClick;
        }

        private void RightButtonClick(object sender, RoutedEventArgs e)
        {

            var Rectangle = new Rectangle()
            {
                Width = 400,
                Height = 40,
                Margin = new Thickness(0, 10, 0, 10),
                Fill = Brushes.MediumSlateBlue
            };

            this.StackPanelRight.Children.Add(Rectangle);
        }

        private void LeftButtonClick(object sender, RoutedEventArgs e)
        {

            var Rectangle = new Rectangle()
            {
                Width = 90,
                Height = 90,
                Margin = new Thickness(0, 10, 0, 10),
                Fill = Brushes.Navy
            };
            this.StackPanelLeft.Children.Add(Rectangle);

        }
    }
}
