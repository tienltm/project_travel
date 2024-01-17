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
                    UserName = "user",
                    Email = "user@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }


            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Malaysia - Singapore",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 200000,
                    PictureUrl = "/images/products/tour-1.jpg",
                    Brand = "Singapore",
                    Type = "International",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Malaysia",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 150000,
                    PictureUrl = "/images/products/tour-2.jpg",
                    Brand = "Malaysia",
                    Type = "International",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bangkok",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 180000,
                    PictureUrl = "/images/products/tour-3.jpg",
                    Brand = "Thailand",
                    Type = "International",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Taiwan",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 300000,
                    PictureUrl = "/images/products/tour-4.jpg",
                    Brand = "Taiwan",
                    Type = "International",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tokyo",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 250000,
                    PictureUrl = "/images/products/tour-5.jpg",
                    Brand = "Japan",
                    Type = "International",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sapa",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 120000,
                    PictureUrl = "/images/products/tour-13.jpg",
                    Brand = "Việt Nam",
                    Type = "Domestic",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Singapore",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10000,
                    PictureUrl = "/images/products/tour-7.jpg",
                    Brand = "Singapore",
                    Type = "International",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tây Bắc",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/tour-10.jpg",
                    Brand = "Việt Nam",
                    Type = "Domestic",
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