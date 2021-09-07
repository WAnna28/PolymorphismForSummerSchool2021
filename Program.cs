using PolymorphismForSummerSchool.Model;
using System;
using System.Collections.Generic;

namespace PolymorphismForSummerSchool
{
    class Program
    {
        static void Main()
        {
            ///* Static or Compile Time Polymorphism  */
            //CalculateStaticPolymorphism c = new CalculateStaticPolymorphism();
            //c.AddNumbers(int.MaxValue, 2);
            //c.AddNumbers((short)4, 45);
            //c.AddNumbers("test", 45);
            //c.AddNumbers(1, 2, 3);
            //  c.AddNumbers(1, 2, 3, 4);

            CalculateStaticPolymorphism d =
                new CalculateStaticPolymorphism(author: "dddd");

            CalculateStaticPolymorphism df =
                new CalculateStaticPolymorphism("fff");
            B b = new B();

            Circle c = new Circle();
            Square s = new Square();
            deee(c); deee(s);

            b.AddNumbers(5.7, 4.3);
            b.AddNumbers("anna", 8);

            Console.WriteLine();

            /* Dynamic / Runtime Polymorphism */
            var drawings = new List<Drawing>
            {
                new Rectangle(),
                new Square(),
                new Circle()
            };

            foreach (var drawing in drawings)
            {
                Console.WriteLine("Area: " + drawing.Area());
            }

            Console.ReadLine();
        }


        static void deee(Drawing f)
        {
            Console.WriteLine($"Type: {f.GetType()}, Area: {f.Area()}");
        }
    }
}
