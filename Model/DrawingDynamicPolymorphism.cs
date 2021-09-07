using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismForSummerSchool.Model
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Dynamic Polymorphism (Runtime Polymorphism)
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Dynamic Polymorphism decides which method to execute in runtime.
    //1. Method Overriding is an example of dynamic polymorphism, and it is requred to happens dynamic polymorphism.
    //2. Dynamic Polymorphism achieved through dynamic binding.
    //3. Dynamic Polymorphism happens between different classes.
    //4. It is required where a subclass object is assigned to super class object for dynamic polymorphism.
    //5. Inheritance involved for dynamic polymorphism.
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class Drawing
    {
        public virtual double Area()
        {
            Console.WriteLine("jjhkljnlkjhkljhl");
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 2020;
        }

        public override double Area()
        {
            base.Area();
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Square : Drawing
    {
        public double Length { get; set; }

        public Square()
        {
            Length = 2021;
        }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Height = 18.18;
            Width = 19.19;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}