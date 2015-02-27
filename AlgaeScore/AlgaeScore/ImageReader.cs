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
            var image = Image.FromFile("LakeErieAlgae.jpg");
            using (var context = image.CreateUnsafeContext())
            for (var i = 0; i < context.Width; i++)
            {
                for (var e = 0; e < context.Height; e++)
                {
                    var pixel = context.GetRawPixel(i, e);
                    var average = Convert.ToByte((pixel.Red + pixel.Green + pixel.Blue) / 3d);
                    context.SetPixel(i, e, pixel.Alpha, average, average, average);
                    break;
                } 
            image.Save(@"C:\Users\Alex\Documents\GitHub\AlgaeScore\AlgaeScore\bin", ImageFormat.Gif);
            break;
            }
            
        }

        //public void gifEncoder()
        //{
        //    using (var image = Image.FromFile("LakeErieAlgae.jpg"))
        //    using (var gif = File.OpenWrite("LakeErieAlgae.jpg"))
        //    using (var encoder = new GifEncoder(gif))
        //        for (var i = 0; i < 360; i += 10)
        //            using (var frame = image.Rotate(i, false))
        //            {
        //                encoder.AddFrame(frame);
        //            }
        //}


    }
}
