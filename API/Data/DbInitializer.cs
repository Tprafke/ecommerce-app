using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Brown Brim",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "https://i.ibb.co/ZYW3VTp/brown-brim.png",
                    Brand = "Hat Club",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Beanie",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "https://i.ibb.co/ypkgK0X/blue-beanie.png",
                    Brand = "L.L.Bean",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown Cowboy Hat",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "https://i.ibb.co/QdJwgmp/brown-cowboy.png",
                    Brand = "Hat Club",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Grey Brim",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "https://i.ibb.co/RjBLWxB/grey-brim.png",
                    Brand = "L.L.Bean",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Beanie",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "https://i.ibb.co/YTjW3vF/green-beanie.png",
                    Brand = "L.L.Bean",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Palm Tree Cap",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "https://i.ibb.co/rKBDvJX/palm-tree-cap.png",
                    Brand = "Hat Club",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Beanie",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "https://i.ibb.co/bLB646Z/red-beanie.png",
                    Brand = "L.L.Bean",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Wolf Cap",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "https://i.ibb.co/1f2nWMM/wolf-cap.png",
                    Brand = "Hat Club",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Snapback",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "https://i.ibb.co/X2VJP2W/blue-snapback.png",
                    Brand = "Hat Club",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Adidas NMD",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "https://i.ibb.co/0s3pdnc/adidas-nmd.png",
                    Brand = "Adidas",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Adidas Yeezy",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "https://i.ibb.co/dJbG1cT/yeezy.png",
                    Brand = "Adidas",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Black Converse",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "https://i.ibb.co/bPmVXyP/black-converse.png",
                    Brand = "Converse",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nike White AirForce",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "https://i.ibb.co/1RcFPk0/white-nike-high-tops.png",
                    Brand = "Nike",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nike Red High Tops",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "https://i.ibb.co/QcvzydB/nikes-red.png",
                    Brand = "Nike",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nike Brown High Tops",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "https://i.ibb.co/fMTV342/nike-brown.png",
                    Brand = "Nike",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Air Jordan Limited",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/w4k6Ws9/nike-funky.png",
                    Brand = "Nike",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Timberlands",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/Mhh6wBg/timberlands.png",
                    Brand = "Timberlands",
                    Type = "Sneakers",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Black Jean Shearling",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/XzcwL5s/black-shearling.png",
                    Brand = "L.L.Bean",
                    Type = "Jackets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Jean Jacket",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1500,
                    PictureUrl = "https://i.ibb.co/mJS6vz0/blue-jean-jacket.png",
                    Brand = "Levi's",
                    Type = "Jackets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Grey Jean Jacket",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/N71k1ML/grey-jean-jacket.png",
                    Brand = "Levi's",
                    Type = "Jackets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown Shearling",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 3200,
                    PictureUrl = "https://i.ibb.co/s96FpdP/brown-shearling.png",
                    Brand = "L.L.Bean",
                    Type = "Jackets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tan Trench",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 3000,
                    PictureUrl = "https://i.ibb.co/M6hHc3F/brown-trench.png",
                    Brand = "L.L.Bean",
                    Type = "Jackets",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Tanktop",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1000,
                    PictureUrl = "https://i.ibb.co/7CQVJNm/blue-tank.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Floral Blouse",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1250,
                    PictureUrl = "https://i.ibb.co/4W2DGKm/floral-blouse.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Floral Dress",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1800,
                    PictureUrl = "https://i.ibb.co/KV18Ysr/floral-skirt.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Dots Dress",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2500,
                    PictureUrl = "https://i.ibb.co/N3BN1bh/red-polka-dot-dress.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Striped Sweater",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/KmSkMbH/striped-sweater.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow Track Suit",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 3000,
                    PictureUrl = "https://i.ibb.co/v1cvwNf/yellow-track-suit.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White Blouse",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1250,
                    PictureUrl = "https://i.ibb.co/qBcrsJg/white-vest.png",
                    Brand = "Nordstrom",
                    Type = "Womens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Camo Down Vest",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/xJS0T3Y/camo-vest.png",
                    Brand = "Nordstrom",
                    Type = "Mens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Floral T-shirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1500,
                    PictureUrl = "https://i.ibb.co/qMQ75QZ/floral-shirt.png",
                    Brand = "Good Shirt Co.",
                    Type = "Mens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Black & White Longsleeve",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/55z32tw/long-sleeve.png",
                    Brand = "Good Shirt Co.",
                    Type = "Mens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink T-shirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1750,
                    PictureUrl = "https://i.ibb.co/RvwnBL8/pink-shirt.png",
                    Brand = "Good Shirt Co.",
                    Type = "Mens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Jean Long Sleeve",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2000,
                    PictureUrl = "https://i.ibb.co/VpW4x5t/roll-up-jean-shirt.png",
                    Brand = "Levi's",
                    Type = "Mens",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Burgundy T-shirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1500,
                    PictureUrl = "https://i.ibb.co/mh3VM1f/polka-dot-shirt.png",
                    Brand = "Good Shirt Co.",
                    Type = "Mens",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}