using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {
            Building EightHundredEigth = new Building ("800 8th Street");
            EightHundredEigth.Width = 315.5;
            EightHundredEigth.Depth = 128.2;
            EightHundredEigth.Stories = 7;

            Console.WriteLine (EightHundredEigth._address);
        }
    }
}