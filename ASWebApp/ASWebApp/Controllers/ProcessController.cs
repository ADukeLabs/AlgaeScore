using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using BumpKit;
using ASWebApp.Models;



namespace ASWebApp.Controllers
{
    public class ProcessController : Controller
    {

        //Put image file paths to list of strings
        //Pass files to razor page

        // GET: Process
        public ActionResult Index()
        {
            List<ImageViewModel> imagePaths = new List<ImageViewModel>();
            imagePaths.Add(new ImageViewModel {Name = "AlgaeSwirls", Image = "/Images/algae_swirls.jpg" });
            imagePaths.Add(new ImageViewModel {Name = "LakeErieAlgae", Image = "/Images/LakeErieAlgae.jpg" });
            imagePaths.Add(new ImageViewModel {Name = "NorthSea", Image = "/Images/NorthSeaAlgae.jpg" });
            imagePaths.Add(new ImageViewModel {Name = "SN_Algae", Image = "/Images/sn_algae.jpg" });
            return View(imagePaths);
        }

        
        //Display a sigle image from the index page in a view
        //TODO Have button to trigger black and white action
        
        public ActionResult Display(ImageViewModel file)
        {

            file = new ImageViewModel { Name = "AlgaeSwirls", Image = "/Images/algae_swirls.jpg" };
            return View(file);       
        }


        public ActionResult blackAndWhite(ImageViewModel file)
        {
            file = new ImageViewModel { Name = "AlgaeSwirls", Image = "/Images/algae_swirls.jpg" };
            var image = Image.FromFile(file.Image);
            using (var context = image.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                        if (pixel.Red >= 35 && pixel.Red <= 114 && pixel.Green >= 99 && pixel.Green <= 238 && pixel.Blue >= 83 && pixel.Blue <= 114)
                        {
                            context.SetPixel(w, h, Color.White);
                        }
                        else
                        {
                            context.SetPixel(w, h, Color.Black);
                        }
                    }
                }
            }
            image.Save("~Images/new, ImageFormat.Bmp");
            //return image;
            return View(image);
        }

        public ActionResult Score()
        {
            int whiteScore = 0;
            int blackScore = 0;

            decimal white = whiteScore;
            decimal black = blackScore;

            var picture = Bitmap.FromFile("new.bmp");
            using (var context = picture.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                        if (pixel.EqualsColor(Color.White))
                        {
                            white++;
                        }
                        else if (pixel.EqualsColor(Color.Black))
                        {
                            black++;
                        }
                    }
                }
            }
            decimal score = Math.Floor((white / (white + black)) * 100);
            return View(score);
        }
    }
}