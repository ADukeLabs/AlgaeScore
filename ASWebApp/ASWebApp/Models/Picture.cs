using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASWebApp.Models
{
    public class Picture
    {
        public int id { get; set; }
        public string image_Name { get; set; }
        public byte[] image { get; set; }
        public string image_Description { get; set; }
        public DateTime created_At { get; set; }
        public DateTime updated_At { get; set; }
 
    }
}