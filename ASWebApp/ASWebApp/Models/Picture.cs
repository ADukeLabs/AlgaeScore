using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations;

namespace ASWebApp.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImgURL { get; set; }

        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
 
    }
}