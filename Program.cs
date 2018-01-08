using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a hashset for a set of cars
            HashSet<string> Showroom = new HashSet<string>();

            // Add my favorite 4 car models
            Showroom.Add("Odyssey");
            Showroom.Add("Sienna");
            Showroom.Add("Pacifica");
            Showroom.Add("Windstar");

            // Print the number of items in the hashset to the console
            Console.WriteLine(Showroom.Count);

            // try to add the an item a 2nd time
            Showroom.Add("Windstar");


            // create another hashset for a set of used cars
            HashSet<string> UsedLot = new HashSet<string>();

            // add two more car model names
            UsedLot.Add("Pinto");
            UsedLot.Add("Gremlin");

            // merge UsedLot with Showroom
            Showroom.UnionWith(UsedLot);


            // sell a car and remove it from the ShowRoom
            Showroom.Remove("Pacifica");


            // Print the number of items in the hashset to the console
            Console.WriteLine(Showroom.Count);

            // create a new hashset for a junkyard
            HashSet<string> Junkyard = new HashSet<string>
                {
                    "Supra", "Mustang", "Tahoe", "Pinto", "Odyssey"
                };

            // create a new set to practice with IntersectWith() to see which cars are in the junkyard and also in the Showroom. 
            HashSet<string> testIntersect = new HashSet<string>
                {
                    "Supra", "Tahoe", "Corvette"
                };

            testIntersect.IntersectWith(Junkyard);

            Showroom.UnionWith(Junkyard);

            Showroom.Remove("Tahoe");
            Showroom.Remove("Mustang");



        }
    }
}
