using Foundation;
using System;
using System.Net.Http;
using UIKit;
using System.Net.Http;
using System.Threading.Tasks;

namespace Miscursos
{
    public partial class ViewDetalle : UIViewController
    {


        private Course detalleCurso;
        public Course DetalleCurso { get => detalleCurso; set => detalleCurso = value; }

        public ViewDetalle (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            lblTitle.Text = detalleCurso.Title;
            lblDescripcion.Text = detalleCurso.Description;
            lblIntructor.Text = detalleCurso.Teacher;
            lblTiempo.Text = detalleCurso.Duration;
            LoadImageAsync();
		}

        private async void LoadImageAsync()
        {
            image.Image = await LoadImage(detalleCurso.Image);
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