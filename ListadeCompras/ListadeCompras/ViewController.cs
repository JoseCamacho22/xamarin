using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace ListadeCompras
{
    public partial class ViewController : UIViewController


    {
        public List<string[]> miProducto { get; set; }

        protected ViewController(IntPtr handle) : base(handle)
        {

            miProducto = new List<string[]>();
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void agregarProducto(UIButton sender)
        {
            string[] data = new string[] { txtProducto.Text, txtCantidad.Text };

            miProducto.Add(data);

            txtProducto.Text = "";
            txtCantidad.Text = "";


        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
            base.PrepareForSegue(segue, sender);

            var miController = segue.DestinationViewController as ProductoTableViewController;

            if(miController !=null)
            {
                miController.misProductos = miProducto;
            }
		}
	}
}
