using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    class CarConveyor : Conveyor
    {
        public override void BuildDoors()
        {
            _product["doors"] = "4";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "150 л.с";
        }

        public override void BuildFrame()
        {
            _product = new Product("Автомобиль");
            _product["frame"] = "Рама автомобиля";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "4";
        }
    }
}
