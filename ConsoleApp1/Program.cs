using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private String name;
        private int age;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = ++value; }
        }

        static void main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter your name: ");
             obj.Name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            obj.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: "+obj.Name);
            Console.WriteLine("Age: "+obj.Age);
            Console.ReadKey();
        }
    }
}
