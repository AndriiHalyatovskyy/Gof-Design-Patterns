using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builders
{
    /* Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
     * 
     * Advantages:
     * You can construct objects step-by-step, defer construction steps or run steps recursively.
     * You can reuse the same construction code when building various representations of products.
     * Single Responsibility Principle. You can isolate complex construction code from the business logic of the product.
     * 
     * Disadvantages:
     * The overall complexity of the code increases since the pattern requires creating multiple new classes.
     * */
    internal class Builder
    {
        public Laptop BuildAppleMacBook2022(ILaptopBuilder builder)
        {
            return builder.SetModel("Apple")
                 .SetProcessor("Intel Core I20")
                 .SetDescription("Mac Book 2022")
                 .SetVideoCard("Rtx 5090")
                 .Build();
        }
    }






    public class Laptop
    {
        public string Model { get; set; }
        public string Description { get; set; }
        public string Processor { get; set; }
        public string VideoCard { get; set; }
    }

    public class LaptopBuilder : ILaptopBuilder
    {
        private Laptop laptop = new Laptop();

        public ILaptopBuilder SetModel(string model)
        {
            laptop.Model = model;
            return this;
        }

        public ILaptopBuilder SetDescription(string description)
        {
            laptop.Description = description;
            return this;
        }
        public ILaptopBuilder SetProcessor(string processor)
        {
            laptop.Processor = processor;
            return this;
        }
        public ILaptopBuilder SetVideoCard(string videoCard)
        {
            laptop.VideoCard = videoCard;
            return this;
        }

        public Laptop Build() => laptop;
    }

    public interface ILaptopBuilder
    {
        ILaptopBuilder SetModel(string model);
        ILaptopBuilder SetDescription(string description);
        ILaptopBuilder SetProcessor(string processor);
        ILaptopBuilder SetVideoCard(string videoCard);
        Laptop Build();
    }
}
