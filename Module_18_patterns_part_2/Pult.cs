using System;

namespace Module_18_patterns_part_2
{
    internal class Pult
    {
        OpenAction openAction;
        internal void SetAction(OpenAction gateOpenAction)
        {
            openAction = gateOpenAction;
        }

        internal void OpenButton()
        {
            openAction.Open();
        }

        internal void CloseButton()
        {
            openAction.Close();
        }
    }
}