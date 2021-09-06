using System;

namespace LINQProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ Program");
            LinqExample.Demo();
            Console.WriteLine("------------------------");
            LinqExample.AddDataTable();
            Console.WriteLine("------------------------");
            LinqToEntities.Entities();
        }
    }
}