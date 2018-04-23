using System;

namespace FacadeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new HouseBuilderFacade();

            Console.WriteLine("Building house");
            facade.BuildHouse();
            Console.WriteLine("Building mansion");
            facade.BuildMansion();
        }
    }
}
