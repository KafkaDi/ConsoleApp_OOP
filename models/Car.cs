using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OOP.models
{
    public class Car
    {
        private int _maxMass;
        private int _maxHeight;
        //private int _maxPassangers;
        //private string _name;
        private Human[] _passangers;
        private int _countOfPassangers;

        public Car() { }

        public Car(int maxMass, int maxHeight, int maxPassangers)
        {
            _maxHeight = maxHeight;
            _maxMass = maxMass;
            _countOfPassangers = 0;
            //_maxPassangers = maxPassangers;
            _passangers = new Human[maxPassangers];
        }

        public void AddPassanger(Human newHuman)
        {
            if (_enthiaPassajers() && _enthialHeight(newHuman) && _enthialMass(newHuman))
            {
                _passangers[_countOfPassangers] = newHuman;
                _countOfPassangers++;
                Console.WriteLine($"Passajir {newHuman.GetName()} dobavlen");
            }
            else
            { Console.WriteLine("Vse mesta zabiti"); }
        }
        private bool _enthiaPassajers()
        {
            if (_countOfPassangers < _passangers.Length)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Vse mesta zabity(");
                return false;
            }
        }

        private bool _enthialHeight(Human newHuman)
        {
            if (newHuman.GetHeight() < _maxHeight)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Maximalny rost previshen(");
                return false;
            }
        }

        private bool _enthialMass(Human newHuman)
        {
            if (newHuman.GetMass() < _maxMass)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Maximalnaya massa previshena(");
                return false;
            }
        }

    }
}
