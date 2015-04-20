using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace ASWeb2._0.Controllers
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
            return View(newModel);
        }

        public ActionResult ColorImage(string name)
        {
            var dir = Server.MapPath("~/Content/Images");
            var imagePath = Path.Combine(dir, name + ".jpg");
            return File(imagePath, "image/jpeg");
        }

        public ActionResult blackAndWhite(string name)
        {
            var dir = Server.MapPath("~/Content/Images");
            var imagePath = Path.Combine(dir, name + ".jpg");
            ImageReader img1 = new ImageReader();
            var newImage = img1.pixelImage(imagePath);
            var blackwhiteimage = img1.imageToByte(newImage);
            return File(blackwhiteimage, "image/jpeg");
        }
    }
}