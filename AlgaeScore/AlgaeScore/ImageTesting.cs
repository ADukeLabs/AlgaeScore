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
    public class ImageTesting
    {
        public ImageTesting()
        {

        }


        public Image whiteImage(Image image)
        {
            image = Image.FromFile("algae_swirls.jpg");
            using (var context = image.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        //BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                        context.SetPixel(w, h, Color.White);
                    }
                }
            }
            image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\white.bmp", ImageFormat.Bmp);
            return image;
        }



        public Image blackImage()
        {
            Image image = Image.FromFile("algae_swirls.jpg");
            using (var context = image.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        //BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                        context.SetPixel(w, h, Color.Black);
                    }
                }
            }
            image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\black.bmp", ImageFormat.Bmp);
            return image;
        }


        public Image blackAndWhite()
        {
            Image image = Image.FromFile("algae_swirls.jpg");
            using (var context = image.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        var halfPixels = context.Height / 2;
                        if (h <= halfPixels)
                        {
                            context.SetPixel(w, h, Color.Black);
                        }
                        else
                        {
                            context.SetPixel(w, h, Color.White);
                        }
                        
                    }
                }
            }
            image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\half.bmp", ImageFormat.Bmp);
            return image;
        }



    }
}