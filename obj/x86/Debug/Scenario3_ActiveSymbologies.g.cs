﻿#pragma checksum "C:\Users\Abdul Rehman\source\repos\Windows-universal-samples2\Samples\BarcodeScanner\shared\Scenario3_ActiveSymbologies.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "36AA3F07DAA171A1D1491117F3D4C8F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDKTemplate
{
    partial class Scenario3_ActiveSymbologies : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Scenario3_ActiveSymbologies.xaml line 23
                {
                    this.SymbologyListSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 3: // Scenario3_ActiveSymbologies.xaml line 27
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Scenario3_ActiveSymbologies.xaml line 90
                {
                    this.ErrorBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 5: // Scenario3_ActiveSymbologies.xaml line 91
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Scenario3_ActiveSymbologies.xaml line 81
                {
                    this.ScenarioOutputScanDataType = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Scenario3_ActiveSymbologies.xaml line 82
                {
                    this.ScenarioOutputScanDataLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Scenario3_ActiveSymbologies.xaml line 83
                {
                    this.ScenarioOutputScanData = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Scenario3_ActiveSymbologies.xaml line 48
                {
                    this.Display1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Scenario3_ActiveSymbologies.xaml line 65
                {
                    this.SetActiveSymbologiesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SetActiveSymbologiesButton).Click += this.SetActiveSymbologies_Click;
                }
                break;
            case 12: // Scenario3_ActiveSymbologies.xaml line 43
                {
                    this.ScenarioStartScanButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ScenarioStartScanButton).Click += this.ScenarioStartScanButton_Click;
                }
                break;
            case 13: // Scenario3_ActiveSymbologies.xaml line 44
                {
                    this.ScenarioEndScanButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ScenarioEndScanButton).Click += this.ScenarioEndScanButton_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

