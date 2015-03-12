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

        public string name = Console.ReadLine();

        public void whiteImage()
        {
            Image image = Image.FromFile(name + ".jpg");
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
            image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\new.bmp", ImageFormat.Bmp);
        }



        public void blackImage()
        {
            Image image = Image.FromFile(name + ".jpg");
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
            image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\new.bmp", ImageFormat.Bmp);
        }

        //public void blackAndWhite()
        //{
        //    using (Image image = Image.FromFile(name + ".jpg"))
        //    {
        //            using (var context = image.CreateUnsafeContext())
        //            {
        //                for (var w = 0; w < context.Width; w++)
        //                {
        //                    for (var h = 0; h < context.Height; h++)
        //                    {
        //                        BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
        //                        if (w * h == 50)
        //                        {
        //                            context.SetPixel(w, h, Color.Black);
        //                        }
        //                        else
        //                        {
        //                            context.SetPixel(w, h, Color.White);
        //                        }
        //                    }
        //                }
        //                image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\AlgaeScore\bin\Debug\new.bmp", ImageFormat.Bmp);
        //            }
        //    }


        //}
    }
}
