using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> faveFoods = new List<string>() {"pizza", "alfredo", "chicken", "sushi", "broccoli" };
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[4]);

            List<int> luckyNums = new List<int>();
            luckyNums.Add(13);
            luckyNums.Add(8);
            luckyNums.Add(44);
            luckyNums.Add(7);

            List<string> badFoods = new List<string>();
            badFoods[0] = "onions";
            badFoods[1] = "mushrooms";
            badFoods[2] = "liver";
            badFoods[3] = "pig feet";*/

            //List<string> faveFilms = new List<string>() { "GoodFellas", "Bullitt", "Old School" };
            //faveFilms.Insert(0, "The Big Sick");
            //faveFilms.Insert(3, "Dumbo");
            /*for (int  counter = 0; counter < faveFilms.Count; counter++)
            {
                Console.WriteLine(faveFilms[counter]);
            }
            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }*/
            //faveFilms.Remove("Old School");
            //faveFilms.Remove("Bullitt");
            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}
            //************************************
            //List<string> animals = new List<string>();
            //animals.Add("dog");
            //animals.Add("cat");
            //animals.Add("bird");
            //animals.Add("fish");
            //animals.Add("squirrel");
            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}
            //**************************************
            //List<bool> boolList = new List<bool>() { true, false, false, true, false };
            //foreach (bool item in boolList)
            //{
            //    if(item == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today. Enjoy the sun.");
            //    }
            //}
            //****************************************
            List<int> nums = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            nums.ForEach(Console.WriteLine);
            if (nums.Contains(23))
            {
                Console.WriteLine("23 was found");
            }
            if (nums.Contains(77))
            {
                Console.WriteLine("77 was found");
            }
            if (nums.Contains(15))
            {
                Console.WriteLine("15 was found");
            }
            nums.Remove(27);
            nums.Remove(77);
            nums.Remove(32);
            nums.Remove(6);

            nums.ForEach(Console.WriteLine);



            
            




        }
    }
}
