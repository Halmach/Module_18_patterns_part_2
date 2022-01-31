using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    class Place : ILocation
    {
        string Address;
        public Place(string address)
        {
            this.Address = address;
        }

        public ILocation Clone()
        {
            return new Place(this.Address);
        }

        public void GetInfo()
        {
            Console.WriteLine($" Новый объект по адресу {Address}");
        }
    }
}
