#pragma checksum "C:\Users\Carlos\Documents\GitHub\MeMeCollection\MemeCollection\TiendaTazasPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A6D6135D7675726A56C9D727BCD7872F7D8AAB0C89D69D585EF6862DB4B7431"
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
    partial class TiendaTazasPage : 
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
            case 2: // TiendaTazasPage.xaml line 21
                {
                    this.cbTienda = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbTienda).SelectionChanged += this.ordenarProductos;
                }
                break;
            case 3: // TiendaTazasPage.xaml line 22
                {
                    this.imgaddCarrito = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // TiendaTazasPage.xaml line 23
                {
                    this.txtCompras = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // TiendaTazasPage.xaml line 24
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 6: // TiendaTazasPage.xaml line 25
                {
                    this.producto1 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 7: // TiendaTazasPage.xaml line 26
                {
                    this.producto2 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 8: // TiendaTazasPage.xaml line 27
                {
                    this.producto3 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 9: // TiendaTazasPage.xaml line 28
                {
                    this.producto4 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 10: // TiendaTazasPage.xaml line 29
                {
                    this.producto5 = (global::MemeCollection.tiendaUserControl)(target);
                }
                break;
            case 11: // TiendaTazasPage.xaml line 30
                {
                    this.producto6 = (global::MemeCollection.tiendaUserControl)(target);
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

