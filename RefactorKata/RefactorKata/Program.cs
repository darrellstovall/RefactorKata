using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RefactorKata
{
    internal class Program
    {
        private static voic Main (string[] args) 
        {
            using var conn =
            var conn = new SqlConnection("Server=.;Database=myDataBase;User Id=myUsername;Password = myPassword;");

            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Products";
            /*
             * cmd.CommandText = "Select * from Invoices";
             */
            var reader = cmd.ExecuteReader();
            var products = new List<Product>();

            //TODO: Replace with Dapper

            while (reader.Read())
            {
                var prod = new Product {Name = reader["Name"].ToString()};
                products.Add(prod);
            }
            Console.WriteLine("Products Loaded!");

            conn.Dispose();

            foreach (var product in products)
            {
                Console.WriteLine(products[i].Name);
            }
        }
    }
    public class Product
    {
        public string Name { get; set; };
    }
}
