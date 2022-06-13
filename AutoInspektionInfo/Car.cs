using System;
using System.Collections.Generic;
using System.Text;

namespace AutoInspection2
{
    class Car
    {
        public string carName = "Audi";
        public int baujahr = 1995;
        public int lastInspectionYear = 2010;


        //Konstruktor
        public Car(string newName, int newBaujahr)
        {
            carName = newName;
            baujahr = newBaujahr;
        }

        public void Inspect()
        {
            lastInspectionYear = 2022;
        }
    }
}
