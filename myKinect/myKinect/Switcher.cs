using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace myKinect
{
    class Switcher
    {
        public static MainWindow pageSwitcher;

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }   
    }
}
