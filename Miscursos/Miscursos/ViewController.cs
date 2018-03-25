using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using UIKit;

namespace Miscursos
{
    public partial class ViewController : UIViewController
    {

        JArray arrCourse;


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            GetJson();
         }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        private async void GetJson()
        {
            Console.WriteLine("Empieza carga de JSON");

            var client = new HttpClient ()
            {
                BaseAddress = new Uri("http://area51.pe/")
            };

            string url = string.Format("http://area51.pe/home/cursos.json");
            var resp = await client.GetAsync(url);
            var result = resp.Content.ReadAsStringAsync().Result;

            JObject values = JObject.Parse(result);

            arrCourse = (JArray)values["responseData"]["results"];

            // Console.WriteLine(arrCourse);
            Console.WriteLine("Termino de cargar el JSON");



            var course = new List<Course>();

            for (var i = 0; i < arrCourse.Count; i++)
            {
                var e = new Course
                {

                    Title = arrCourse[i]["nameCurso"].ToString(),
                    Description = arrCourse[i]["description"].ToString(),
                    Image = arrCourse[i]["imageURL"].ToString(),
                    Duration = arrCourse[i]["hours"].ToString(),
                    Teacher = arrCourse[i]["instructor"].ToString(),
                    Date = arrCourse[i]["start"].ToString(),
                };

                course.Add(e);
            }

            var courseData = new CourseData(course);


            courseData.CurrentNavigationController = this.NavigationController;


            //añadir infortmacion al tableview
            CoursesTableView.Source = courseData;
            CoursesTableView.RowHeight = 220f;
            CoursesTableView.EstimatedRowHeight = 220f;
            CoursesTableView.ReloadData();

            courseData.controller = this;
        }
    }
}
