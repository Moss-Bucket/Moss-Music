
using MossMusic.Core;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Moss Music");
        Console.Write("Enter the path of your Music Library: ");

        string musicPath = Console.ReadLine() ?? "";

        MusicLibrary library = new MusicLibrary(musicPath);

        Console.WriteLine($"Library path: {library.MusicLibraryPath}");
    }
}
