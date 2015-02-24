using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BumpKit;

namespace AlgaeScore
{
    public class ImageReader
    {
        public ImageReader()
        {

        }
        
        public void pixelImage()
        {
            var image = Image.FromFile("");
            using (var context = image.CreateUnsafeContext())
            {
                for (var i = 0; i < context.Width; i++)
                {
                    for (var e = 0; e < context.Height; e++)
                    {
                        var pixel = context.GetRawPixel(i, e);
                        var average = Convert.ToByte((pixel.Red + pixel.Green + pixel.Blue) / 3d);
                        context.SetPixel(i, e, pixel.Alpha, average, average, average);
                    }
                }
            }
        }
        
        



        



    }
}
