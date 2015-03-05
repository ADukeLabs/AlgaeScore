﻿using System;
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
            using (Image image = Image.FromFile("LEA.jpg"))
            {
                using (var context = image.CreateUnsafeContext())
                {
                    for (var w = 0; w < context.Width; w++)
                    {
                        for (var h = 0; h < context.Height; h++)
                        {
                            BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                            //var pixel = context.GetRawPixel(w, h); 
                            
                            //if (pixel.Red >= 133 && pixel.Green >= 249 && pixel.Blue >= 116)
                            //{
                               
                            //}
                            if (pixel.Red > 18 && pixel.Red < 58 && pixel.Green > 67 && pixel.Green < 123 && pixel.Blue > 71 && pixel.Blue < 81)
                            {
                                context.SetPixel(w, h, Color.White);
                            }
                            else
                            {
                                context.SetPixel(w, h, Color.Black);
                            }
                            //var average = Convert.ToByte((pixel.Red + pixel.Green + pixel.Blue) / 3d);
                            //context.SetPixel(w, h, pixel.Alpha, average, average, average);
                            //Detect when a pixel in the image matches the value of the 'green' shade
                            //If it is, set the pixel to 'white'
                            //Otherwise, 'black'
                            //Use Photoshop eyedropper tool to take reading of green color
                            //Use shade of green to make an if statement
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
