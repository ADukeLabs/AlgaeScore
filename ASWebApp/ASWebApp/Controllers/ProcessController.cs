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
            string fileUrl = "/Content/Images/" + name + ".jpg";
            return View((object)fileUrl);
        }

        public ActionResult ColorImage(string name)
        {
            var dir = Server.MapPath("~/Content/Images");
            var image = Path.Combine(dir, name + ".jpg");
            return File(image, "image/jpeg");    
        }

        //public ActionResult blackAndWhite(string name)
        //{
        //    var dir = Server.MapPath("~/Content/Images");
        //    var image = Path.Combine(dir, name + ".jpg");

        //}

        
    }
}