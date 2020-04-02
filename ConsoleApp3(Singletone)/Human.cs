using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_Singletone_
{
    public class Human
    {
        protected string _name;
        protected int _id;
        public Human(string Name, int ID)
        {
            _name = Name;
            _id = ID;
        }
        public string Name { get { return _name; } }
        public int Id { get { return _id; } }
    }
}
