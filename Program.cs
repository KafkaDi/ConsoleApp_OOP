using System;

namespace ConsoleApp_OOP.models
{
       class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car(4000, 220, 3);
            Human vlad = new Human(74, 175, "Влад");
            Human ivan = new Human(74, 175, "Иван");
            Human dima = new Human(74, 240, "Дима");
            Human alex = new Human(74, 175, "Алексей");


            firstCar.AddPassanger(vlad);
            firstCar.AddPassanger(ivan);
            firstCar.AddPassanger(dima);
            firstCar.AddPassanger(alex);

            Console.ReadKey();
        }
    }
}
