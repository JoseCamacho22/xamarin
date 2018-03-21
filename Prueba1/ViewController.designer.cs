// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Prueba1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSaludo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtApellido { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNombre { get; set; }

        [Action ("btnSaludo:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSaludo (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (lblSaludo != null) {
                lblSaludo.Dispose ();
                lblSaludo = null;
            }

            if (txtApellido != null) {
                txtApellido.Dispose ();
                txtApellido = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }
        }
    }
}