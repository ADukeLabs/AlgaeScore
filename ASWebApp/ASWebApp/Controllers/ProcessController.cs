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



namespace ASWebApp.Controllers
{
    public class ProcessController : Controller
    {

        

        // GET: Process
        public ViewResult Index()
        {
            List<string> imagePaths = new List<string>();
            imagePaths.Add("/Content/Images/algae_swirls.jpg");
            ViewBag.Images = imagePaths;
            return View();
        }

        //Set instance variable of filename string from Content/Images folder

        //public ActionResult loadImages()
        //{
            
        //}
    }
}