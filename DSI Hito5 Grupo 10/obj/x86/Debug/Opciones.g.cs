﻿#pragma checksum "C:\Users\David\Desktop\DSI 2020\DSI-Proyecto-Grupo10-2020\DSI Hito5 Grupo 10\Opciones.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6FB97001F1C964C08F96C8807445A102"
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
    partial class Opciones : 
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
            case 2: // Opciones.xaml line 13
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                }
                break;
            case 3: // Opciones.xaml line 16
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.ControlsButton_Click;
                }
                break;
            case 4: // Opciones.xaml line 17
                {
                    this.IncreaseBrightButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.IncreaseBrightButton).Click += this.IncreaseBrightButton_Click;
                }
                break;
            case 5: // Opciones.xaml line 18
                {
                    this.DecreaseBrightButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DecreaseBrightButton).Click += this.DecreaseBrightButton_Click;
                }
                break;
            case 6: // Opciones.xaml line 19
                {
                    this.IncreaseVolumeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.IncreaseVolumeButton).Click += this.IncreaseVolumeButton_Click;
                }
                break;
            case 7: // Opciones.xaml line 20
                {
                    this.DecreaseVolumeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DecreaseVolumeButton).Click += this.DecreaseVolumeButton_Click;
                }
                break;
            case 8: // Opciones.xaml line 22
                {
                    this.Bars = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9: // Opciones.xaml line 28
                {
                    this.VolumeBar = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 10: // Opciones.xaml line 29
                {
                    this.BrightBar = (global::Windows.UI.Xaml.Controls.Border)(target);
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

