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


        public void pixelImage()
        {
            using (Image image = Image.FromFile("LakeErieAlgae.jpg"))
            {


                using (var context = image.CreateUnsafeContext())
                {
                    for (var w = 0; w < context.Width; w++)
                    {
                        for (var h = 0; h < context.Height; h++)
                        {
                            var pixel = context.GetRawPixel(w, h);
                            var average = Convert.ToByte((pixel.Red + pixel.Green + pixel.Blue) / 3d);
                            context.SetPixel(w, h, pixel.Alpha, average, average, average);
                            //Detect when a pixel is a certain shade of green
                            //If it is, set the pixel to 'white'
                            //Otherwise, 'black'
                            //Use Photoshop eyedropper tool to take reading of green color
                            //Use shade of green to make an if statement
                        }

                    }

                }
                //image.DetectPadding();
                image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\new.bmp", ImageFormat.Bmp);
            }



        }
    }
}
