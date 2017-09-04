using System;

namespace ConsoleApp1
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
