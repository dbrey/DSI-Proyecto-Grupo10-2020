using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Gaming.Input;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using System.Diagnostics;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSI_Hito5_Grupo10
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Interfaz1p : Page
    {
        public Interfaz1p()
        {
            this.InitializeComponent();
        }

        private void ToMap(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Map));
        }
        private void ToMapButtonEntered(object sender, PointerRoutedEventArgs e)
        {
            ToMapButton.Opacity = 100;
        }

        private void ToMapButtonExited(object sender, PointerRoutedEventArgs e)
        {
            ToMapButton.Opacity = 0;
        }

        private void ToPausa(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pausa)); ;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            Window.Current.CoreWindow.KeyDown -= HandleKeyDown;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Window.Current.CoreWindow.KeyDown += HandleKeyDown;
        }

        void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.W || e.Key == VirtualKey.S || e.Key == VirtualKey.GamepadLeftTrigger || e.Key == VirtualKey.GamepadRightTrigger)
            {
                Canvas.SetTop(GearLever, 700);
            }

        }

        private void HandleKeyDown(CoreWindow sender, KeyEventArgs e)
        {
            if (e.VirtualKey == VirtualKey.W || e.VirtualKey== VirtualKey.GamepadRightTrigger)
            {
                Canvas.SetTop(GearLever, 580);
            }

            else if (e.VirtualKey == VirtualKey.S || e.VirtualKey==VirtualKey.GamepadLeftTrigger)
                Canvas.SetTop(GearLever,820);
            else if (e.VirtualKey == VirtualKey.X || e.VirtualKey==VirtualKey.GamepadMenu)
            {
                this.Frame.Navigate(typeof(Map));
            }
        }
    }
}
