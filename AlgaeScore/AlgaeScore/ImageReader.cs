using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgaeScore
{
    public class ImageReader
    {
        //Initialize a variable that contains the image
        Bitmap bmp1 = new Bitmap(100, 100);

        //Initialize a list to contain the pixels
        List<Bitmap> pxls = new List<Bitmap>();

        //Method to add and save Bitmap to list
        public void addPixels()
        {
            pxls.Add(bmp1);
        }

        



    }
}
