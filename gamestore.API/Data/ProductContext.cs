using Gamestore.API.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamestore.API.Data
{

    public class ProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }

        private static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
         {

        new Product()
                {
                    Name = "Hogwarts Legacy",
                    Description = "Hogwarts Legacy : L'Héritage de Poudlard est un jeu vidéo de rôle développé par Avalanche Software et édité par Warner Bros. Interactive Entertainment en collaboration avec Portkey Games.",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Game"
                },
                new Product()
                {
                    Name = "Star Wars Jedi: Survivor",
                    Description = "Star Wars Jedi: Survivor est un jeu vidéo d'action-aventure développé par Respawn Entertainment et édité par Electronic Arts. Suite de Star Wars Jedi: Fallen Order, il est sorti sur Microsoft Windows, PlayStation 5 et Xbox Series le 28 avril 2023.",
                    ImageFile = "product-2.png",
                    Price = 70.00M,
                    Category = "Game"
                },
                new Product()
                {
                    Name = "Diablo IV",
                    Description = "jeu vidéo d'action-RPG de type hack 'n' slash développé par Blizzard Entertainment. Il constitue le quatrième épisode principal de la série Diablo, faisant suite à Diablo III sorti en 2012.",
                    ImageFile = "product-3.png",
                    Price = 59.99M,
                    Category = "Game"
                },
                new Product()
                {
                    Name = "Final Fantasy XVI",
                    Description = "Final Fantasy XVI est un jeu vidéo de rôle d'action-aventure développé et édité par Square Enix, qui sortira le 22 juin 2023 sur PlayStation 5. Il s'agit du seizième opus principal de la série Final Fantasy.",
                    ImageFile = "product-4.png",
                    Price = 71.99M,
                    Category = "Game"
                },
                new Product()
                {
                    Name = "Dead Island 2",
                    Description = "Dead Island 2 est un jeu vidéo d'action-aventure de type survival horror, développé par Dambuster Studios et édité par Deep Silver. Il s'inscrit dans le même univers que Dead Island. Initialement prévu pour 2015, il a été reporté à de nombreuses reprises à cause de son développement chaotique.",
                    ImageFile = "product-5.png",
                    Price = 38.00M,
                    Category = "Game"
                },
                new Product()
                {
                    Name = "Resident Evil 4",
                    Description = "Resident Evil 4, sorti au Japon sous le nom Biohazard 4, est un jeu vidéo de tir à la troisième personne de type survival horror, développé par Capcom Production Studio 4 et édité par l'entreprise japonaise Capcom. L'histoire se déroule six ans après les événements de Resident Evil 2. Elle met en scène l'agent Leon S.",
                    ImageFile = "product-6.png",
                    Price = 69.00M,
                    Category = "Game"
                }
            };
        }
    }
}


