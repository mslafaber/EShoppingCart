using EShoppingCart.Data;
using EShoppingCart.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace EShoppingCart
{
    public class DbInitializer
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var scopeeee = app.ApplicationServices.CreateScope();

            ApplicationDbContext context =
                scopeeee.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    new Item
                    {
                        Name = "MacBook Pro",
                        Price = 7.95M,
                        ItemDescription = "MacBook Pro description",
                        Category = Categories["Electronic Items"],
                        ItemImageUrl = "https://images.unsplash.com/photo-1548611635-b6e7827d7d4a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                        InStock = true,
                        IsPrefferedItem = true,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1548611635-b6e7827d7d4a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                    },
                    new Item
                    {
                        Name = "White Tshirt",
                        Price = 12.95M,
                        ItemDescription = "White Tshirt Description",
                        Category = Categories["Clothing Items"],
                        ItemImageUrl = "https://images.unsplash.com/photo-1529374255404-311a2a4f1fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1049&q=80",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1529374255404-311a2a4f1fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1049&q=80"
                    },
                    new Item
                    {
                        Name = "IPhone 7 Mobile Phone",
                        Price = 12.95M,
                        ItemDescription = "IPhone 7 Description",
                        Category = Categories["Electronic Items"],
                        ItemImageUrl = "https://images.unsplash.com/photo-1545984306-9143a47b0f6e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1545984306-9143a47b0f6e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                    },
                    new Item
                    {
                        Name = "Sneakers",
                        Price = 12.95M,
                        ItemDescription = "Sneakers Description",
                        Category = Categories["Clothing Items"],
                        ItemImageUrl = "https://images.unsplash.com/photo-1552346154-21d32810aba3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1552346154-21d32810aba3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Electronic Items", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Clothing Items", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}