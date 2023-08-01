using System.Text.Json;
using Models;

namespace Models;

public class FavoritesSongs
{
    // Creating properties
    public string? Name { get; set; }
    public List<Songs> ListOfMusics { get; } // Creating a list of songs

    // Creating constructor with parameters
    public FavoritesSongs(string Name)
    {
        this.Name = Name;
        ListOfMusics = new List<Songs>();
    }


    // Creating a method to add songs to the list
    public void AddSong(Songs musica)
    {
        ListOfMusics.Add(musica);
    }

    // Creating a method to remove songs from the list
    public void RemoveSong(Songs musica)
    {
        ListOfMusics.Remove(musica);
    }

    // Creating a method to show the list of songs in the console
    public void ShowSongs()
    {
        // Using foreach to show the list of songs
        foreach (var musica in ListOfMusics)
        {
            Console.WriteLine($"{musica}");
        }
    }

    // Creating a method to create a json file with the list of songs
    public void JsonMusics()
    {
        // Creating a json string with the name and list of songs
        string json = JsonSerializer.Serialize(new {
            name = Name,
            listOfMusics = ListOfMusics
        });

        // Combining the path of the current directory with the name of the file
        var path = Path.Combine(Environment.CurrentDirectory, $"FavoritesSongs{Name}.json");

        // Creating the file
        var jsonFile = File.WriteAllTextAsync(path, json);

        Console.WriteLine($"File created successfully! {path}");
    }
}
