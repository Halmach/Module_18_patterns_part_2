using System;

namespace Module_18_patterns_part_2
{
    public class ImplementationOne : BaseClass
    {
        int id;

        public ImplementationOne(int id)
        {
            this.id = id;
        }

        public override BaseClass Clone()
        {
            return new ImplementationOne(this.id);
        }

        public override void GetId()
        {
           Console.WriteLine($"Создан объект с Id {this.id}");
        }
    }
}