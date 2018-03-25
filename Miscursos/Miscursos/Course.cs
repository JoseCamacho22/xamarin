using System;
namespace Miscursos
{
    public class Course
    {
        private string title;
        private string description;
        private string image;
        private string duration;
        private string date;
        private string teacher;


        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Date { get => date; set => date = value; }
        public string Teacher { get => teacher; set => teacher = value; }

    }
}
