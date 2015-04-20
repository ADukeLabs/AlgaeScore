using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using BumpKit;

namespace ASWeb2._0.Controllers.ImageLogic
{
    public class ImageReader
    {
        public Image pixelImage(string imagePath)
        {
            var image = Image.FromFile(imagePath);
            using (var context = image.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                        if (pixel.Red >= 35 && pixel.Red <= 114 && pixel.Green >= 99 && pixel.Green <= 238 && pixel.Blue >= 83 && pixel.Blue <= 114)
                        {
                            context.SetPixel(w, h, Color.White);
                        }
                        else
                        {
                            context.SetPixel(w, h, Color.Black);
                        }
                    }
                }
            }
            return image;
        }

        public byte[] imageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}