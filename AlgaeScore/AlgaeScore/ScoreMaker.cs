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
    public class ScoreMaker
    {
        //Create int variables called 'whiteScore' and 'blackScore'
        public int whiteScore = 0;
        public int blackScore = 0;

        public decimal scoreCalculator()
        {
            decimal white = whiteScore;
            decimal black = blackScore;
            //Get instance of new bitmap image.
            var picture = Bitmap.FromFile("new.bmp");
            using (var context = picture.CreateUnsafeContext())
            {
                for (var w = 0; w < context.Width; w++)
                {
                    for (var h = 0; h < context.Height; h++)
                    {
                        BumpKit.UnsafeBitmapContext.Pixel pixel = context.GetRawPixel(w, h);
                        if (pixel.EqualsColor(Color.White))
                        {
                            white++;
                        }
                        else if (pixel.EqualsColor(Color.Black))
                        {
                            black++;
                        }
                    }
                }
                
            }
            Console.WriteLine(white);
            Console.WriteLine(black);
            decimal score = Math.Floor(white / black * 100);
            return score;
            //Console.WriteLine(score);
            //Console.ReadLine();
        }

    }
}
