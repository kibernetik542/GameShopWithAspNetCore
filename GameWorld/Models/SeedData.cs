using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace GameWorld.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Uncharted 4: A Thief's End",
                    Description = "Uncharted 4: A Thief's End is an action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment for PlayStation 4.",
                    Category = "Adventure",
                    Price = 35.99M
                }, new Product
                {
                    Name = "Assassin's Creeed Origins",
                    Description = "Assassin's Creed Origins is an action-adventure video game developed by Ubisoft Montreal and published by Ubisoft",
                    Category = "Adventure",
                    Price = 68.00M
                }, new Product
                {
                    Name = "The Evil Within 2",
                    Description = "The Evil Within 2 is a third-person survival horror video game developed by Tango Gameworks and published by Bethesda Softworks for Microsoft Windows, PlayStation 4 and Xbox One.",
                    Category = "Horror",
                    Price = 59.99M
                }, new Product
                {
                    Name = "Resident Evil 7",
                    Description = "Resident Evil 7: Biohazard is a survival horror video game developed and published by Capcom. The game was released worldwide in January 2017 for Microsoft Windows, PlayStation 4 – with support for the PlayStation VR headset – and Xbox One. ",
                    Category = "Horror",
                    Price = 39.99M
                }, new Product
                {
                    Name = "Pro Evolution Soccer 2018",
                    Description = "Pro Evolution Soccer 2018 (abbreviated as PES 2018) is a sports video game developed by PES Productions and published by Konami for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360 and Xbox One.",
                    Category = "Sport",
                    Price = 35.94M
                }, new Product
                {
                    Name = "Middle-earth: Shadow of War",
                    Description = "Middle-earth: Shadow of War is an action role-playing game developed by Monolith Productions and published by Warner Bros. Interactive Entertainment. It is the sequel to 2014's Middle-earth: Shadow of Mordor, and was released worldwide for Microsoft Windows, PlayStation 4, and Xbox One on October 10, 2017.",
                    Category = "Action",
                    Price = 44.99M
                }, new Product
                {
                    Name = "Grand Theft Auto V",
                    Description = "Grand Theft Auto V is an action-adventure video game developed by Rockstar North and published by Rockstar Games",
                    Category = "Adventure",
                    Price = 42.99M
                }, new Product
                {
                    Name = "FIFA 18",
                    Description = "FIFA 18 is a football simulation video game in the FIFA series of video games, developed and published by Electronic Arts and was released worldwide on 29 September 2017 for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360, Xbox One and Nintendo Switch",
                    Category = "Sport",
                    Price = 65.99M
                });
                context.SaveChanges();
            }
        }
    }
}
