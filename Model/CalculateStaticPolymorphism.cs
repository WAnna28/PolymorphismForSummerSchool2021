using System;

namespace PolymorphismForSummerSchool.Model
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Static polymorphism(Compile-time Polymorphism)
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // 1. Static Polymorphism decides which method to execute during compile time.
    // 2. Method Overloading is an example of static polymorphism, and it is requred to happens static polymorphism.
    // 3. Static Polymorphism achieved through static binding.
    // 4. Static Polymorphism happens in the same class.
    // 5. Object assignment is not required for static polymorphism.
    // 6. Inheritance not involved for static polymorphism.
    public class CalculateStaticPolymorphism
    {
        public string author;
        public string name;
        public CalculateStaticPolymorphism
            (string name = null, string author = null)
        {
            this.author = author;
            this.name = name;
        }

        public void AddNumbers(int num1, int num2)
        {
            //Console.WriteLine("num1 + num2 = {0}", num1 + num2);
            Console.WriteLine("int, int");
        }

        public void AddNumbers(string num1, in int? num2)
        {
            Console.WriteLine("string, int");
        }

        public void AddNumbers(string num1, ref int num2)
        {
            Console.WriteLine("string, int");
        }

        public void AddNumbers(short num1, int num2)
        {
            Console.WriteLine("short, int");
        }

        //public void AddNumbers(double num1, double num2)
        //{            
        //    Console.WriteLine("CalculateStaticPolymorphism: double, double");
        //}

        public void AddNumbers(int num1, int num2, int num3)
        {
            Console.WriteLine("num1 + num2 + num3 = {0}", num1 + num2 + num3);
        }
    }

    public class B : CalculateStaticPolymorphism
    {
       /*new*/ public void AddNumbers(double num1, double num2)
        {
            //Console.WriteLine("num1 + num2 = {0}", num1 + num2);
            Console.WriteLine("double, double");
        }
    }
}
