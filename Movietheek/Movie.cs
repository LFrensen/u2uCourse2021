using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movietheek
{
  [Serializable]
  public class Movie
  {
    //Step 1 - place your properties here
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }
  }

  static class Movies
  {
    //Step 2 - Implement the static GetMovies() method here
    public static List<Movie> GetMovies()
    {
        var movies = new List<Movie>()
        {
            new Movie() { Title = "The Eternals", Genre = "Actie/Avontuur/Drama/Superheldenfilm/Fantasyfilm/Sciencefiction", Rating = 7},
            new Movie() { Title = "No time To Die", Genre = "Actie/Misdaad/Avontuur/Spionage/Mysteriefilm/Thriller", Rating = 7},
            new Movie() { Title = "Ron's Gone Wrong", Genre = "Kinderen/Komedy/Familiefilm/Animatie/Avontuur/Sciencefiction", Rating = 7 },
            new Movie() { Title = "Paw Patrol: The Movie", Genre = "Komedie/Animatie/Avontuur/Tekenfilm/Familiefilm", Rating = 6 },
            new Movie() { Title = "Dune", Genre = "Actie/Avontuur/Drama/Epos/Fantasyfilm/Sciencefiction", Rating = 8 }
        };
        return movies;
    }
  }
}
