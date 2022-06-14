using System;

namespace AutoInspection2
{
    class Program
    {
        static void Main()
        {
            Car[] cars = new Car[8];
            cars[0] = new Car("Mercedes G", 2008);
            cars[1] = new Car("BMW 3", 2001);
            cars[2] = new Car("Audi A6", 2005);
            cars[3] = new Car("Audi A8", 2012);
            cars[4] = new Car("Hyundai", 2003);
            cars[5] = new Car("Toyota", 1995);
            cars[6] = new Car("Porsche 911 GT3", 2021);
            cars[7] = new Car("VW Golf R32", 2002);

            Console.WriteLine("Bitte geben sie einen Suchbegriff ein:");

            string searchTerm = Console.ReadLine();

            Console.WriteLine("Suchbegriff ist: " + searchTerm);

            Console.WriteLine("Folgende Autos wurden gefunden:");

            foreach (Car car in cars)
            {
                if (car.carName.Contains(searchTerm))
                {
                    Console.WriteLine(car.carName + " Baujahr: " + car.baujahr + " Letzte Inspection: " + car.lastInspectionYear);
                    car.Inspect();
                    Console.WriteLine("Neues Inspektionsjahr: " + car.lastInspectionYear);
                }
            }

            Console.ReadKey();
            Console.Clear();
            Main();

        }
    }
}
