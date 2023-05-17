using System;

namespace PixelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3840;
            int upperGapLimit = 1;
            int lowerGapLimit = 0;
            int upperSideLimit = 20;
            int lowerSideLimit = 0;
            int lowerN = 1;
            int upperN = 1;

            Console.WriteLine("Running Pixel bar chain calculator.\n\nWarning: this program does not have any kind of safety for checking correct input.\nOnly give positive integers as input and be aware that the larger the total area and upper limits,\nthe more memory and time consuming the calculation will be.\n\nThe program will run (upper side limit) * (upper gap limit) * (upper N limit) calculations.\n\n");


            Console.WriteLine("\nInput the total length of your area in pixels,\ne.g. the inside of a HP bar container.");
            total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the lower limit of the side padding between your object chain and the total area in pixels,\ne.g. the gap between a chain of HP bars and a HP bar container.");
            lowerSideLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the upper limit of the side padding between your object chain and the total area in pixels.");
            upperSideLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the lower limit of the gap between objects in your object chain in pixels,\ne.g. the gap between each HP bar in a HP bar container.");
            lowerGapLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the upper limit of the gap between objects in your object chain in pixels.");
            upperGapLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the lower limit of the amount of objects in your object chain in pixels,\ne.g. the amount of HP bar objects in a HP bar container.");
            lowerN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the upper limit of the amount of objects in your object chain in pixels.");
            upperN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nN = the number of separate objects.\nTotal = The total length of the confining area in pixels.\nSide = the number of pixels drawn on both ends of the chain of N separate objects as a gap between the chain and the confining area.\nGap = the number of pixels between each object in the chain of separate objects.\nWidth = the length of the separate objects in the chain measured in pixels.\n");
            Console.WriteLine("Example where\nN: \t" + 3 + "\nTotal: \t" + 15 + "\tSide: \t" + 1 + "\tGap: \t" + 2 + "\nWidth: \t" + 3 + "\n");
            Console.WriteLine("# X X X - - X X X - - X X X #\n\n\n");
            for (int gap = lowerGapLimit; gap <= upperGapLimit; gap++)
            {
                for (int side = lowerSideLimit; side <= upperSideLimit; side++)
                {
                    for (int n = lowerN; n <= upperN; n++)
                    {
                        double width = Convert.ToDouble((total - 2.0f * side - gap * (n - 1)) / n);
                        if (width % 1 == 0)
                        {
                            Console.WriteLine("N: \t" + n + "\nTotal: \t" + total + "\tSide: \t" + side + "\tGap: \t" + gap + "\nWidth: \t" + width + "\n");
                        }
                    }
                }
            }
        }
    }
}
