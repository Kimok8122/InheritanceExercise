using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            var Bird1 = new Bird();

            Bird1.TypeOfFood = "Worms";
            Bird1.ColorOf = "Red and Black";
            Bird1.FlySouth = "Yes";
            Bird1.TypeOfSong = "chrip chrip chrip";


            Console.WriteLine($"");

            Console.WriteLine($"This bird enjoys a meal of " +
                $"{Bird1.TypeOfFood}. It has feathers of {Bird1.ColorOf}." +
                $" It's song sounds a bit like '{Bird1.TypeOfSong}.' " +
                $"If asked if they fly south for the winter, they would " +
                $"answer: {Bird1.FlySouth}.");

            Console.WriteLine($"----------------------------------------");




           

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
