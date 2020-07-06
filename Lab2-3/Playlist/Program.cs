using System;
using System.Collections.Generic;

namespace Playlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist("My Playlist");
            String input;
            Boolean isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("menu:\n(Enter number to select)\n  1. Search\n  2. Show all\n  3. Add item\n  4. Delete item\n  5. Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Search by:\n  1. Author\n  2. Title\n  3. back");
                        String newInput = Console.ReadLine();
                        String search;
                        List<Song> results;
                        switch (newInput)
                        {
                            case "1":
                                search = Console.ReadLine();
                                results = playlist.SearchByAuthor(search);
                                if (results.Count != 0)
                                {
                                    int i = 1;
                                    foreach (Song song in results)
                                    {
                                        Console.WriteLine(i + ". ");
                                        song.PrintInfo();
                                        i++;
                                    }
                                }
                                else Console.WriteLine("No results");
                                break;
                            case "2":
                                search = Console.ReadLine();
                                results = playlist.SearchByTitle(search);
                                if (results.Count != 0)
                                {
                                    int i = 1;
                                    foreach (Song song in results)
                                    {
                                        Console.WriteLine(i + ". ");
                                        song.PrintInfo();
                                        i++;
                                    }
                                }
                                else Console.WriteLine("No results");
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("Enter number from 1 to 3");
                                break;
                        }
                        break;
                    case "2":
                        playlist.ShowAll();
                        break;
                    case "3":
                        Console.WriteLine("Enter song title ");
                        String title = Console.ReadLine();
                        Console.WriteLine("Enter song author ");
                        String author = Console.ReadLine();
                        Console.WriteLine("Enter song duration [s]: ");
                        String duration = Console.ReadLine();
                        playlist.AddSong(title, author, int.Parse(duration));
                        break;
                    case "4":
                        Console.WriteLine("Enter song number in list to delete: ");
                        String number = Console.ReadLine();
                        int num;
                        if (int.TryParse(number, out num))
                            playlist.DeleteSong(num);
                        else Console.WriteLine("Enter correct number");
                        break;
                    case "5":
                        Console.WriteLine("Goodby!");
                        Console.ReadLine();
                        isWorking = false;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
