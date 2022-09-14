using System;
using System.Collections.Generic;

namespace Design_Patterns.Factories
{
    /*Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
     * 
     * Advantages:
     * You can be sure that the products you’re getting from a factory are compatible with each other.
     * You avoid tight coupling between concrete products and client code
     * Single Responsibility Principle. You can extract the product creation code into one place, making the code easier to support.
     * Open/Closed Principle. You can introduce new variants of products without breaking existing client code.
     * 
     * Disadvantages:
     * The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.
     * 
     * */
    public class AbstractFactory
    {
    }

    public class HotDrinkMachine
    {
        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType($"Design_Patterns.Factories.{Enum.GetName(typeof(AvailableDrink), drink)}Factory"));
                factories.Add(drink, factory);
            }
        }
        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }

        public enum AvailableDrink
        {
            Coffe, Tea, SomeDrink
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();
    }

    internal class SomeDrink : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Consuming some hot drink");
        }
    }

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Consuming tea");
        }
    }

    internal class Coffe : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Consuming Coffe");
        }
    }

    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }

    public interface IHotDrink
    {
        void Consume();
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"You prepared {amount} ml of tea");
            return new Tea();
        }
    }

    internal class CoffeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"You prepared {amount} ml of tea");
            return new Coffe();
        }
    }

    internal class SomeDrinkFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"You prepared {amount} ml of some drink");
            return new SomeDrink();
        }
    }
}
