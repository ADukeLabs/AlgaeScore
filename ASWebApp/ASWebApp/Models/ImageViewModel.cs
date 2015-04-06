using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASWebApp.Models
{
    public class ImageViewModel
    {
        public string ImageName { get; set; }
        public string ImageText { get; set; }
        public HttpPostedFileBase Image { get; set; }
    }
}