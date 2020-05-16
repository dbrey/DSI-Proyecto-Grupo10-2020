using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Input;
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
    public sealed partial class Controles : Page
    {
        // Dictionary to maintain information about each active pointer.
        // An entry is added during PointerPressed/PointerEntered events and removed
        // during PointerReleased /PointerCaptureLost /PointerCanceled /PointerExited events.
        Dictionary<uint, Windows.UI.Xaml.Input.Pointer> pointers;

        public Controles()
        {
            this.InitializeComponent();


            // Initialize the dictionary.
            pointers = new Dictionary<uint, Windows.UI.Xaml.Input.Pointer>();

            KeyboardAccelerator GoBack = new KeyboardAccelerator();
            GoBack.Key = VirtualKey.GoBack;
            GoBack.Invoked += BackInvoked;
            KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            AltLeft.Key = VirtualKey.Left;
            AltLeft.Invoked += BackInvoked;
            this.KeyboardAccelerators.Add(GoBack);
            this.KeyboardAccelerators.Add(AltLeft);
            // ALT routes here
            AltLeft.Modifiers = VirtualKeyModifiers.Menu;

            PanelPC.PointerEntered += new PointerEventHandler(PanelPC_PointerEntered);
            PanelPC.PointerExited += new PointerEventHandler(PanelPC_PointerExited);
            PanelGamepad.PointerEntered += new PointerEventHandler(GamepadPanel_PointerEntered);
            PanelGamepad.PointerExited += new PointerEventHandler(Gamepadpanel_PointerExited);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opciones));
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
        private void BackInvoked(KeyboardAccelerator sender,
        KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        }

        private void PanelPC_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            e.Handled = true;

            PointerPoint ptrPt = e.GetCurrentPoint(PanelPC);

            // Lock the pointer to the target.
            PanelPC.CapturePointer(e.Pointer);

            // Check if pointer exists in dictionary (ie, enter occurred prior to press).
            if (!pointers.ContainsKey(ptrPt.PointerId))
            {
                // Add contact to dictionary.
                pointers[ptrPt.PointerId] = e.Pointer;
            }

            PanelPC.Opacity = 0.5;
        }

        private void PanelPC_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            e.Handled = true;

            PointerPoint ptrPt = e.GetCurrentPoint(PanelPC);

            // Lock the pointer to the target.
            PanelPC.CapturePointer(e.Pointer);

            // Check if pointer exists in dictionary (ie, enter occurred prior to press).
            if (!pointers.ContainsKey(ptrPt.PointerId))
            {
                // Add contact to dictionary.
                pointers[ptrPt.PointerId] = e.Pointer;
            }

            PanelPC.Opacity = 100;
        }

        private void GamepadPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            e.Handled = true;

            PointerPoint ptrPt = e.GetCurrentPoint(PanelGamepad);

            // Lock the pointer to the target.
            PanelGamepad.CapturePointer(e.Pointer);

            // Check if pointer exists in dictionary (ie, enter occurred prior to press).
            if (!pointers.ContainsKey(ptrPt.PointerId))
            {
                // Add contact to dictionary.
                pointers[ptrPt.PointerId] = e.Pointer;
            }

            PanelGamepad.Opacity = 0.5;
        }

        private void Gamepadpanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            e.Handled = true;

            PointerPoint ptrPt = e.GetCurrentPoint(PanelGamepad);

            // Lock the pointer to the target.
            PanelGamepad.CapturePointer(e.Pointer);

            // Check if pointer exists in dictionary (ie, enter occurred prior to press).
            if (!pointers.ContainsKey(ptrPt.PointerId))
            {
                // Add contact to dictionary.
                pointers[ptrPt.PointerId] = e.Pointer;
            }

            PanelGamepad.Opacity = 100;
        }
    }
}
