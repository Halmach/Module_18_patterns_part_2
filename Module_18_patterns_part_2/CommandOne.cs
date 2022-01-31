using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_patterns_part_2
{
    class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }

        // Отменить
        public override void Cancel()
        {
            Console.WriteLine("Команда отменена");
        }
    }
}
