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

namespace myKinect.Pages
{
    /// <summary>
    /// Interaction logic for musicPlayerPage.xaml
    /// </summary>
    public partial class musicPlayerPage : UserControl
    {
        
        public musicPlayerPage()
        {
            InitializeComponent();
            musicGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            musicGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            musicElement.Source = new Uri("Resources/music.wav", UriKind.RelativeOrAbsolute);
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {            
            musicElement.Play();            
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            musicElement.Pause();
            
            
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            initialPage ini = new initialPage();
            musicGrid.Children.Clear();
            musicGrid.Children.Add(ini);
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            musicElement.Stop();
            musicElement.Source = new Uri("Resources/music2.wav", UriKind.RelativeOrAbsolute);
            musicElement.Play();
        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            musicElement.Stop();
            musicElement.Source = new Uri("Resources/music.wav", UriKind.RelativeOrAbsolute);
            musicElement.Play();
        }
    }
}
