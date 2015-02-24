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
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using myKinect.Pages;

namespace myKinect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }        
        
        private readonly KinectSensorChooser sensorChooser;

        public MainWindow()
        {
            InitializeComponent();

            Switcher.pageSwitcher = this;

            //Create Sensor Choose to select and manage Kinect Sensor
            this.sensorChooser = new KinectSensorChooser();            
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;            
            this.sensorChooser.Start();

            //Bind the Sensor to the KinectRegion Control
            var regionSensorBinding = new Binding("Kinect") { Source = this.sensorChooser };
            BindingOperations.SetBinding(this.kinectRegion, KinectRegion.KinectSensorProperty, regionSensorBinding);

            //Set the height and width of the KinectRegion based on ScreenResolution
            mainWindow.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            mainWindow.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            kinectRegion.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            kinectRegion.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            mainGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            mainGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;

            //Load initialPage with initial Buttons
            initialPage iniPage = new initialPage();
            mainGrid.Children.Add(iniPage);
            
            
        }

        #region SensorChooser Event Handler
        private static void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args)
        {
            if (args.OldSensor != null)
            {
                try
                {
                    args.OldSensor.DepthStream.Range = DepthRange.Default;
                    args.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    args.OldSensor.DepthStream.Disable();
                    args.OldSensor.SkeletonStream.Disable();
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    MessageBox.Show("Please connect a Kinect Sensor", "No Kinect Found", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            if (args.NewSensor != null)
            {
                try
                {
                    args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    args.NewSensor.SkeletonStream.Enable();

                    try
                    {
                        args.NewSensor.DepthStream.Range = DepthRange.Near;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
                    }
                    catch (InvalidOperationException)
                    {
                        // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.
                        args.NewSensor.DepthStream.Range = DepthRange.Default;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    }
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    MessageBox.Show("Please connect a Kinect Sensor", "No Kinect Found", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion
        
        #region Finalise Methods
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.sensorChooser.Stop();
        }
        #endregion        
 

    }
}
