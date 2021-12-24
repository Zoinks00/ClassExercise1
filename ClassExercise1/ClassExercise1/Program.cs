using System;
using System.Collections.Generic;

namespace ClassExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstCar = new Car();
            {
                FirstCar.Make = "Mazda";
                FirstCar.Model = "CX-50";
                FirstCar.Year = 2021;
            };
            Console.WriteLine($"Your 1st car is {FirstCar.Make} {FirstCar.Model} {FirstCar.Year}.");
        }
    }
}
