using Catalog.Api.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        { 
            bool existProduct = productCollection.Find(p=>true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());   
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name =  "Nike air",
                    Description ="Tênis caro demais",
                    Image   = "....virgula....",
                    Price = 950.00M,
                    Category = "Tênis"
                },
                new Product()
                {
                    Id = "702d2149e773f2a3990b47f5",
                    Name =  "Adidas Mali",
                    Description ="Tênis caro, mas nem tanto ",
                    Image   = "....tres riscos....",
                    Price = 650.00M,
                    Category = "Tênis"
                },
                new Product()
                {
                    Id = "802d2149e773f2a3990b47f5",
                    Name =  "Olympikus",
                    Description ="Tênisbom e barato",
                    Image   = "....3 circulos....",
                    Price = 350.00M,
                    Category = "Tênis"
                }
            };
        }

    }
}
