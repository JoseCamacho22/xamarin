using UIKit;

namespace ListadeCompras
{
    internal class MyDataSource : UITableViewSource
    {
        private ProductoTableViewController productoTableViewController;

        public MyDataSource(ProductoTableViewController productoTableViewController)
        {
            this.productoTableViewController = productoTableViewController;
        }
    }
}