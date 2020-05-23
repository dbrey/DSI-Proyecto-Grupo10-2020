using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSI_Hito5_Grupo10
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Map : Page
    {
        Image Coche;
        CoreCursor CursorHand = null;
        CoreCursor CursorArrow = null;


        public Map()
        {
            this.InitializeComponent();
            CursorHand = new CoreCursor(CoreCursorType.Hand, 0);
            CursorArrow = new CoreCursor(CoreCursorType.Arrow, 0);
        }

        private void PointerEntered(object sender, PointerRoutedEventArgs e)
        {



            Window.Current.CoreWindow.PointerCursor = CursorHand;
        }
        private void PointerExited(object sender, PointerRoutedEventArgs e)
        {



            Window.Current.CoreWindow.PointerCursor = CursorArrow;
        }
        private void PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Coche = e.OriginalSource as Image; 
            e.Handled = true;
            if (Coche.Opacity < 1)
            {
            Coche.Opacity = 1;
               
            }
            else Coche.Opacity = 0.5;

            
        }
        private void To1P(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Interfaz1p));
        }
        private void ToPausa(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pausa));
        }
    }
}
