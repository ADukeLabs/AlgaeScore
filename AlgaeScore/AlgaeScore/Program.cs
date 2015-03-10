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
            image1.pixelImage();
            ScoreMaker score1 = new ScoreMaker();
            decimal score = score1.scoreCalculator();
            Console.WriteLine("Algae Cover Percentage: " + score + "%");
            Console.ReadKey();
        }
    }
}
