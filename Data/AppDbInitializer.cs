using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CREAR_API.Data.Models;
using System.Linq;
using System;
namespace CREAR_API.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a la BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Books()
                    {                       
                        Titulo = "すしです。",
                        Descripcion = "Book talking about sushi",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Cuisine",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,

                    },
                    new Books()
                    {                        
                        Titulo = "The 2nd Place",
                        Descripcion = "Olymics book about 2nd places",
                        IsRead = true,
                        Genero = "Sports",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
