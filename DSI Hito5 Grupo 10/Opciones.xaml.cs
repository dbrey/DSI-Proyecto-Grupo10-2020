using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_Hito5_Grupo10
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Opciones : Page
    {
        public Opciones()
        {
            this.InitializeComponent();
            KeyboardAccelerator GoBack = new KeyboardAccelerator();
            GoBack.Key = Windows.System.VirtualKey.GoBack;
            GoBack.Invoked += BackInvoked;
            KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            AltLeft.Key = Windows.System.VirtualKey.Left;
            AltLeft.Invoked += BackInvoked;
            this.KeyboardAccelerators.Add(GoBack);
            this.KeyboardAccelerators.Add(AltLeft);
            // ALT routes here
            AltLeft.Modifiers = VirtualKeyModifiers.Menu;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPrincipal));
        }
        private void ControlsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Controles));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BackButton.IsEnabled = this.Frame.CanGoBack;
        }

        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }

        private void IncreaseBrightButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrightBar.Width < BrightBar.MaxWidth)
                BrightBar.Width += BrightBar.MaxWidth / 10;
        }

        private void DecreaseBrightButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrightBar.Width > 0)
                BrightBar.Width -= BrightBar.MaxWidth / 10;
        }
        private void BackInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        }

        private void IncreaseVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            if (VolumeBar.Width < VolumeBar.MaxWidth)
                VolumeBar.Width += VolumeBar.MaxWidth / 10;
        }

        private void DecreaseVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            if (VolumeBar.Width > 0)
                VolumeBar.Width -= VolumeBar.MaxWidth / 10;
        }
    }
}
