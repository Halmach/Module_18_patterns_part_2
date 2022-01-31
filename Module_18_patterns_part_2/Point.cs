using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    /// <summary>
    /// Обычная точка на карте
    /// </summary>
    class Point : ILocation
    {
        double Latitude;
        double Longtitude;

        public Point(double Latitude, double Longtitude)
        {
            this.Latitude = Latitude;
            this.Longtitude = Longtitude;
        }

        // Метод для клонирования
        public ILocation Clone()
        {
            return new Point(Latitude, Longtitude);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Новая точка на карте с координатами {Longtitude}, {Latitude}");
        }
    }
}
