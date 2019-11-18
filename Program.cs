using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 30;
            FiveOneTwoEigth.Stories = 3;
            FiveOneTwoEigth.Depth = 10;
            FiveOneTwoEigth.Purchase("Shirish");

            Building FourTwoTwo = new Building("422 8th Avenue");
            FourTwoTwo.Width = 30;
            FourTwoTwo.Stories = 3;
            FourTwoTwo.Depth = 11;
            FourTwoTwo.Purchase("Mangal");

            Console.WriteLine(FiveOneTwoEigth.Print());
            Console.WriteLine(FourTwoTwo.Print());

        }
    }
}