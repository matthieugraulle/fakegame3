using Gamestore.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamestore.Client.Data
{
    public static class ProductContext
    {
        //public class ProductContext
        // {
        //public ProductContext(IConfiguration configuration)
        //    {
        // var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
        // var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

        // Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
        // SeedData(Products);
        //}

        //public IMongoCollection<Product> Products { get; }

        // private static void SeedData(IMongoCollection<Product> productCollection)
        //  {
        //bool existProduct = productCollection.Find(p => true).Any();
        //       if (!existProduct)
        //      {
        // productCollection.InsertManyAsync(GetPreconfiguredProducts());
        //}
        //}

        //private static IEnumerable<Product> GetPreconfiguredProducts()
        //  {
        //      return new List<Product>()
        // {
        public static readonly List<Product> Products = new List<Product>
        {
        new Product()
                {
                    Name = "Hogwarts Legacy",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Star Wars Jedi: Survivor",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-2.png",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Diablo IV",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-3.png",
                    Price = 650.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "Final Fantasy XVI",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Name = "Dead Island 2",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-5.png",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Name = "Resident Evil 4",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-6.png",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                }
            };
        }
    }
    


