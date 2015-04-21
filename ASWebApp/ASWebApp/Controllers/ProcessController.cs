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
        // GET: Process
        public ActionResult Index()
        {
            //List<ImageViewModel> imagePaths = new List<ImageViewModel>();
            //imagePaths.Add(new ImageViewModel {Name = "AlgaeSwirls", Image = "/Content/Images/algae_swirls.jpg" });
            //imagePaths.Add(new ImageViewModel {Name = "LakeErieAlgae", Image = "/Content/Images/LakeErieAlgae.jpg" });
            //imagePaths.Add(new ImageViewModel {Name = "NorthSea", Image = "/Content/Images/NorthSeaAlgae.jpg" });
            //imagePaths.Add(new ImageViewModel {Name = "SN_Algae", Image = "/Content/Images/sn_algae.jpg" });
            //return View(imagePaths);

            List<string> imagePaths = new List<string>();
            imagePaths.Add("/Content/Images/algae_swirls.jpg");
            imagePaths.Add("/Content/Images/LakeErieAlgae.jpg");
            imagePaths.Add("/Content/Images/NorthSeaAlgae.jpg");
            imagePaths.Add("/Content/Images/sn_algae.jpg");
            return View(imagePaths);
        }

        public ActionResult DefaultHome()
        {
            return View("Home");
        }

        public ActionResult Home(string name)
        {
            //string colorUrl = "/Process/colorimage/" + name;
            //string blackWhiteUrl = "/Process/blackandwhite/" + name;
            var newModel = new ImageViewModel();
            newModel.Image1 = name;
            newModel.Image2 = name;
            //newModel.Score = Score();
            return View(newModel);
        }

        //public ActionResult Home(string name)
        //{
        //    string fileUrl = "/Content/Images/" + name + ".jpg";
        //    return View((object)fileUrl);
        //}

        public FilePathResult ColorImage(string name)
        {
            var dir = Server.MapPath("~/Content/Images");
            var imagePath = Path.Combine(dir, name + ".jpg");
            return File(imagePath, "image/jpeg");
        }

        public FilePathResult blackAndWhite(string name)
        {
            var dir = Server.MapPath("~/Content/Images");
            var imagePath = Path.Combine(dir, name + ".jpg");
            ImageReader img1 = new ImageReader();
            img1.pixelImage(imagePath);
            return File("~/Content/Images/new.bmp", "image/bmp");
        }

        public string Score()
        {
            ScoreReader score = new ScoreReader();
            var newScore = score.scoreCalculator();
            return "Algae bloom is: " + newScore + "%";
        }
    }
}