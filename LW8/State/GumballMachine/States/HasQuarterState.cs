using System;

namespace GumballMachine.States
{
    public class HasQuarterState : IState
    {
        private readonly IGumballMachineContext _gumballMachine;

        public HasQuarterState(IGumballMachineContext gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetNoQuarterState();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.SetSoldState();
        }

        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
