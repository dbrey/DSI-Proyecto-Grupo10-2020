﻿#pragma checksum "C:\Datos G FM\Universidad\DSI\hitoFinal\DSI-Proyecto-Grupo10-2020\DSI Hito5 Grupo 10\Interfaz1P.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F3A65BF4A3DA50C6FFCFE235DBE7DCE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSI_Hito5_Grupo10
{
    partial class Interfaz1p : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Interfaz1P.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).KeyUp += this.Grid_KeyUp;
                }
                break;
            case 3: // Interfaz1P.xaml line 24
                {
                    this.MapView = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Interfaz1P.xaml line 25
                {
                    this.Cuadro = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // Interfaz1P.xaml line 26
                {
                    this.ToMapButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ToMapButton).Click += this.ToMap;
                    ((global::Windows.UI.Xaml.Controls.Button)this.ToMapButton).PointerEntered += this.ToMapButtonEntered;
                    ((global::Windows.UI.Xaml.Controls.Button)this.ToMapButton).PointerExited += this.ToMapButtonExited;
                }
                break;
            case 6: // Interfaz1P.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.ToPausa;
                }
                break;
            case 7: // Interfaz1P.xaml line 35
                {
                    this.GearLever = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // Interfaz1P.xaml line 36
                {
                    this.SpeedMarker = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

