using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using BumpKit;

namespace AlgaeScore
{
    public class ImageReader
    {
        public ImageReader()
        {

        }

        public string imageName = Console.ReadLine();
        
        public void pixelImage()
        {
            using (Image image = Image.FromFile(imageName + ".jpg"))
            {
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
                            //var average = Convert.ToByte((pixel.Red + pixel.Green + pixel.Blue) / 3d);
                            //context.SetPixel(w, h, pixel.Alpha, average, average, average);
                        }

                    }

                }
                //image.DetectPadding();
                image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\new.bmp", ImageFormat.Bmp);
                //Create histogram of new bitmap file
            }
        }

        


    }
}
