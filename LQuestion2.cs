using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class LQuestion3
    {
        private int id = 25;
        protected string name = "Kartik";
        internal string course = "MCA";
        public int age = 22;
        static void Main(string[] args)
        {
            LQuestion3 L = new LQuestion3();
            Console.WriteLine("Course: " + L.course);
            Console.WriteLine("Age: " + L.age);
        }
    }
}
