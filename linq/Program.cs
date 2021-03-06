﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace linq {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith ("L")
            select fruit;

            foreach (string fruit in LFruits) {
                Console.WriteLine ($"L Fruit -- {fruit}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where (n => n % 4 == 0 || n % 6 == 0);
            fourSixMultiples = fourSixMultiples.OrderBy (n => n);
            foreach (var number in fourSixMultiples) {
                Console.WriteLine ($"{number} is a multiple of 4 or 6");
            }
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending (n => n).ToList ();

            foreach (string name in descend) {
                Console.WriteLine (name);
            }
            // Build a collection of these numbers sorted in ascending order

            List<int> AscendingNumbers = numbers.OrderBy (n => n).ToList ();
            Console.WriteLine ("----Ascending Numbers----");
            foreach (var number in AscendingNumbers) {
                Console.WriteLine (number);
            }

            // Output how many numbers are in this list

            int HowMany = numbers.Count ();

            Console.WriteLine ($"There are {HowMany} numbers in the list");
            // How much money have we made?
            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            double RollinInTheDough = purchases.Sum ();
            Console.WriteLine ($"Who needs school when my bank account looks like this => {RollinInTheDough.ToString("C", CultureInfo.CurrentCulture)}");

            // What is our most expensive product?
            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            double TheMostest = prices.Max ();
            Console.WriteLine ($"This is the most expensive computer I've ever purchased. {TheMostest.ToString("C", CultureInfo.CurrentCulture)}");

            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            List<int> garbageCan = wheresSquaredo.TakeWhile (n => n != (Math.Round (Math.Sqrt (n)) * Math.Round (Math.Sqrt (n)))).ToList ();

            Console.WriteLine ("Garbage Can");
            foreach (var num in garbageCan) {
                Console.WriteLine ($"{num} in garbageCan");
            }

        }
    }
}
