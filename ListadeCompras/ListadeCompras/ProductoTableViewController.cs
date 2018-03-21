using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace ListadeCompras
{
    public partial class ProductoTableViewController : UITableViewController
    {

        static NSString cellID = new NSString("cellProducto");
        public List<string[]> misProductos { get; set; }


        public ProductoTableViewController(IntPtr handle) : base(handle)
        {

            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), cellID);
            TableView.Source = new MyDataSource(this);
        }

        class MyDataSource : UITableViewSource
        {
            ProductoTableViewController controller;


            public MyDataSource(ProductoTableViewController controller)
            {
                this.controller = controller;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = new UITableViewCell(UITableViewCellStyle.Value1, cellID);
                var row = indexPath.Row;

                cell.TextLabel.Text = controller.misProductos[row][0];
                cell.DetailTextLabel.Text = controller.misProductos[row][1];

                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return controller.misProductos.Count;
            }
        }
    }
}