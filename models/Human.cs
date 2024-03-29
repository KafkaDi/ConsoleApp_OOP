﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OOP.models
{
    public class Human
    {
        private int _mass;
        private int _height;
        private string _name;

        public Human() { }

        public Human(int mass, int height, string name)
        {
            _mass = mass;
            _height = height;
            _name = name;
        }
        public int GetMass()
        {
            return _mass;
        }
        public int GetHeight()
        {
            return _height;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
