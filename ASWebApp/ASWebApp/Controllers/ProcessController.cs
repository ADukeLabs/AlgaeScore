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
using ASWebApp.Controllers.ImageControllers;



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
        
        //public Image Display(string file)
        //{
        //    file = "algae_swirls";
        //    return file;
        //}

        
        public ActionResult ColorImage()
        {
            ImageReader colorImg = new ImageReader();
            colorImg.GetImage();
            return View();
        }

        public ActionResult blackAndWhite()
        {
            ImageReader black_white = new ImageReader();
            black_white.GetImage();
            black_white.pixelImage();
            return View();
        }

        
    }
}