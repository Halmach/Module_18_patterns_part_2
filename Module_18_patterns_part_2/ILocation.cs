using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    /// <summary>
    /// Общий интерфейс для объектов на карте
    /// </summary>
    interface ILocation
    {
        //  Метод копирования
        ILocation Clone();

        //Метод для получения информации об объекте
        void GetInfo();
    }
}
