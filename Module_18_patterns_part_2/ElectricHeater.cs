using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    /// <summary>
    ///  Реализация электрического отопления
    /// </summary>
    class ElectricHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine(" Нагрев электричеством");
        }
    }
}
