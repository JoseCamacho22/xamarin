using Foundation;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using UIKit;

namespace Miscursos
{
    public partial class Coursecell : UITableViewCell
    {
        public Coursecell (IntPtr handle) : base (handle)
        {
        }

        internal async Task UpdateCellAsync(Course course)
        {
            lblTitle.Text = course.Title;
            lblDescription.Text = course.Date;
        //    image.Image = UIImage.FromFile(course.Image);

           image.Image = await LoadImage(course.Image);
        }

        async Task<UIImage> LoadImage(string imageUrl)
        {
            var httpClient = new HttpClient();
            Task<byte[]> contentsTask = httpClient.GetByteArrayAsync(imageUrl);
            var contents = await contentsTask;

           return UIImage.LoadFromData(NSData.FromArray(contents));

        }

       

    }
}