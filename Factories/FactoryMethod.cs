using System;

namespace Design_Patterns.Factories
{
    /*Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
     * 
     * Advantages:
     * You avoid tight coupling between the creator and the concrete products.
     * Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
     * Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.
     * 
     * Disadvantages:
     * The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.   
     * */
    internal class FactoryMethod
    {
    }

    public class MyButton
    {
        public static MyButton CreateButtonFor1080P()
        {
            return new MyButton(Math.Pow(2.5, 2.8), 20);
        }

        public static MyButton CreateButtonFor2K()
        {
            return new MyButton(Math.Pow(3, 2), 40);
        }

        public static MyButton CreateButtonFor4K()
        {
            return new MyButton(Math.Pow(4, 2.369), 80);
        }

        public MyButton(double x, double y)
        {

        }
    }
}
