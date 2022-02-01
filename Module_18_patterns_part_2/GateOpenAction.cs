namespace Module_18_patterns_part_2
{
    internal class GateOpenAction : OpenAction
    {
        private Gate gate;

        public GateOpenAction(Gate gate)
        {
            this.gate = gate;
        }

        public override void Close()
        {
            gate.Close();
        }

        public override void Open()
        {
            gate.Open();
        }
    }
}