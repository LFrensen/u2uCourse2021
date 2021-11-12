using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Movietheek
{
  public partial class MainWindow : Window
  {
    private List<Movie> movieList;
    private string fileName = "movies.dat";

    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      if (File.Exists(fileName))
      {
        using (Stream s = File.Open(fileName, FileMode.Open))
        {
          BinaryFormatter b = new BinaryFormatter();
          movieList = (List<Movie>)b.Deserialize(s);
        }
      }
      else
      {
        //Step 3 - Uncomment the line underneath
        movieList = Movies.GetMovies();
      }
      Refresh();
    }

    private void Refresh()
    {
      this.DataContext = null;
      this.DataContext = movieList;
    }

    private void buttonAddNew_Click(object sender, RoutedEventArgs e)
    {
      //Step 4 - Do not remove the call to Refresh()
      Movie newMovie = new Movie() { Genre = textBoxGenre.Text, Title = textBoxTitle.Text, Rating = int.Parse(textBoxRating.Text) };
      movieList.Add(newMovie);
      Refresh();
    }

    private void buttonDelete_Click(object sender, RoutedEventArgs e)
    {
      //Step 5 - Do not remove the call to Refresh()
      movieList.Remove((Movie)listBoxMovieCollection.SelectedItem);
      Refresh();
    }

    private void buttonSave_Click(object sender, RoutedEventArgs e)
    {
      using (Stream s = File.Open(fileName, FileMode.Create))
      {
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(s, movieList);
      }
    }
  }
}
