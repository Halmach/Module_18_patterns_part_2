using System;

namespace Module_18_patterns_part_2
{
    internal class ImplementationTwo : BaseClass
    {
        int id;

        public ImplementationTwo(int id)
        {
            this.id = id;
        }

        public override BaseClass Clone()
        {
            return new ImplementationTwo(this.id);
        }

        public override void GetId()
        {
            Console.WriteLine($"Создан объект с Id {this.id}");
        }
    }
}