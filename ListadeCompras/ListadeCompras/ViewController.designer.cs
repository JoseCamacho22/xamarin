// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ListadeCompras
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAgregar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCantidad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtProducto { get; set; }

        [Action ("agregarProducto:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void agregarProducto (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnAgregar != null) {
                btnAgregar.Dispose ();
                btnAgregar = null;
            }

            if (txtCantidad != null) {
                txtCantidad.Dispose ();
                txtCantidad = null;
            }

            if (txtProducto != null) {
                txtProducto.Dispose ();
                txtProducto = null;
            }
        }
    }
}