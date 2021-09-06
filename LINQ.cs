using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LINQProject
{
    public class LinqExample
    {
        
        public static void Demo()
        {
            string[] names = { "Akhil", "ramesh", "suresh" };
            var myLinqQuery = from name in names
                              where name.Contains('e')
                              select name;
            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }
        }
        public static void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "juice");
            table.Rows.Add("2", "votka");
            table.Rows.Add("3", "breezer");
            DisplayProduct(table);
        }
        
        private static void DisplayProduct(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("Product Names");
            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}