#pragma checksum "C:\Users\Carlos\Documents\GitHub\MeMeCollection\MemeCollection\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6F5B3D6556D818C3EBB0BAFED0A7457D2F62DD1E5499779BDBB01513260B632"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemeCollection
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.volver;
                }
                break;
            case 3: // MainPage.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.volverAlante;
                }
                break;
            case 4: // MainPage.xaml line 28
                {
                    this.svMenu = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 5: // MainPage.xaml line 44
                {
                    this.iconRecientes = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)this.iconRecientes).PointerReleased += this.irRecientes;
                }
                break;
            case 6: // MainPage.xaml line 45
                {
                    this.iconCategorias = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)this.iconCategorias).PointerReleased += this.irCategorias;
                }
                break;
            case 7: // MainPage.xaml line 46
                {
                    this.iconTienda = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)this.iconTienda).PointerReleased += this.irTienda;
                }
                break;
            case 8: // MainPage.xaml line 47
                {
                    this.iconAcercaDe = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)this.iconAcercaDe).PointerReleased += this.irAcercaDe;
                }
                break;
            case 9: // MainPage.xaml line 48
                {
                    this.iconAjustes = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)this.iconAjustes).PointerReleased += this.irAjustes;
                }
                break;
            case 10: // MainPage.xaml line 50
                {
                    this.txtRecientes = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtRecientes).PointerReleased += this.irRecientes;
                }
                break;
            case 11: // MainPage.xaml line 51
                {
                    this.txtCategorias = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtCategorias).PointerReleased += this.irCategorias;
                }
                break;
            case 12: // MainPage.xaml line 52
                {
                    this.txtTienda = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtTienda).PointerReleased += this.irTienda;
                }
                break;
            case 13: // MainPage.xaml line 53
                {
                    this.txtAcercaDe = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtAcercaDe).PointerReleased += this.irAcercaDe;
                }
                break;
            case 14: // MainPage.xaml line 54
                {
                    this.txtAjustes = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.txtAjustes).PointerReleased += this.irAjustes;
                }
                break;
            case 15: // MainPage.xaml line 57
                {
                    this.frmMain = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 16: // MainPage.xaml line 17
                {
                    this.btnMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMenu).Click += this.Button_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

