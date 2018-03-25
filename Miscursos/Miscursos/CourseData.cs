using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Miscursos
{
    public class CourseData : UITableViewSource
    {

        public UINavigationController CurrentNavigationController;
        public ViewController controller;
        private List<Course> course;

        public CourseData(List<Course> course) //datos dentro de una lista de cursos
        {
            this.course = course; //lleno mi curso con lo que venga del contructor
        }
        

        //REFERENCIA A A LA CELDA QUE TENEMOS
		public override  UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
           var cell = (Coursecell)tableView.DequeueReusableCell("celda", indexPath);

            cell.UpdateCellAsync(course[indexPath.Row]);

            return cell;
		}



        //Define las lineas con las que estamos trabajando
		public override nint RowsInSection(UITableView tableview, nint section)
		{
            return course.Count;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            //base.RowSelected(tableView, indexPath);

            tableView.DeselectRow(indexPath, true);

            ViewDetalle detalle = controller.Storyboard.InstantiateViewController("ViewDetalle") as ViewDetalle;

            detalle.DetalleCurso = course[indexPath.Row];//Referencia del curso numero de fila

            controller.NavigationController.PushViewController(detalle, true );
		}
	}
}
