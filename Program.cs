using Design_Patterns.Factories;
using System;
using static Design_Patterns.Factories.HotDrinkMachine;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Factory
            HotDrinkMachine machine = new HotDrinkMachine();
            var tea = machine.MakeDrink(AvailableDrink.Tea, 350);
            var someDrink = machine.MakeDrink(AvailableDrink.SomeDrink, 500);
            someDrink.Consume();
            tea.Consume();
            #endregion



            Console.ReadLine();
        }
    }
}
