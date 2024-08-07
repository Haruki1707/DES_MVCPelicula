using Microsoft.EntityFrameworkCore;

namespace MVCPelicula.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PeliculasDBContext(serviceProvider.GetRequiredService<DbContextOptions<PeliculasDBContext>>()))
            {
                if (!context.Generos.Any())
                {
                    context.Generos.AddRange(
                        new Genero
                        {
                            Nombre = "Fantasia"
                        },
                        new Genero
                        {
                            Nombre = "Ficcion de aventuras"
                        },
                        new Genero
                        {
                            Nombre = "Crimen"
                        },
                        new Genero
                        {
                            Nombre = "Accion"
                        }
                    );
                }
                if (!context.Peliculas.Any())
                {
                    context.Peliculas.AddRange(
                        new Pelicula
                        {
                            Titulo = "Harry Potter y la piedra filosofal",
                            FechaLanzamiento = DateTime.Parse("2001-11-16"),
                            GeneroId = 1,
                            Precio = 9.99M,
                            Director = "Chris Columbus"
                        },
                        new Pelicula
                        {
                            Titulo = "El señor de los anillos: La comunidad del anillo",
                            FechaLanzamiento = DateTime.Parse("2001-12-19"),
                            GeneroId = 2,
                            Precio = 8.99M,
                            Director = "Peter Jackson"
                        },
                        new Pelicula
                        {
                            Titulo = "Atrápame si puedes",
                            FechaLanzamiento = DateTime.Parse("2002-05-15"),
                            GeneroId = 3,
                            Precio = 9.99M,
                            Director = "Steven Spielberg"
                        },
                        new Pelicula
                        {
                            Titulo = "Matrix recargado",
                            FechaLanzamiento = DateTime.Parse("2003-11-13"),
                            GeneroId = 4,
                            Precio = 10.99M,
                            Director = "Lana Wachowski, Lilly Wachowski"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
