using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            Console.WriteLine("Hello World!");
            //words that start with 'L'
            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.Contains("L")
                                          select fruit;

            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>(){
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine($"Multiples of 4 or 6: {num}");
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            IEnumerable<string> descend = from name in names
                                          orderby name descending
                                          select name;

            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }

            // Output how many numbers are in this list
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine($"Total numbers: {numbers2.Count}");

            // How much money have we made?
            List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};

            Console.WriteLine($"Total amount made: {purchases.Sum()}");
            // What is our most expensive product?
            List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};
            Console.WriteLine($"Most expensive product price: {prices.Max()}");

            ////check for squares
            List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};

            IEnumerable<int> isSquare = wheresSquaredo.Where(num => Math.Sqrt(num) % 1 == 0);

            foreach (int num in isSquare)
            {
                Console.WriteLine($"{num} is a perfect square");
            }

        }
    }
}
