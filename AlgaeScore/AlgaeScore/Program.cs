using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgaeScore
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageReader image1 = new ImageReader();
            image1.PixelImage();
            //image1.gifEncoder();
            image1.saveAs();
        }
    }
}
