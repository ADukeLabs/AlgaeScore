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
            //ImageTesting test1 = new ImageTesting();
            //test1.blackAndWhite();
            image1.pixelImage();
            ScoreMaker score1 = new ScoreMaker();
            Console.WriteLine("Algae Bloom Score: " + score1.scoreCalculator() + "%");
            Console.ReadKey();
        }
    }
}
