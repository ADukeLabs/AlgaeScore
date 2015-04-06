using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations;

namespace ASWebApp.Models
{
    public class Images
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageText { get; set; }
        //public string Image { get; set; }

        public string ImagePath { get; set; }
    }
}