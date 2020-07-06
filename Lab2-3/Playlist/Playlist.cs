using System;
using System.Collections.Generic;
using System.Linq;

namespace Playlist
{
    [Serializable]
    public class Playlist
    {
        private String playlistName;
        public List<Song> playlist { get; private set; }
        

        public Playlist(String name)
        {
            this.playlistName = name;
            this.playlist = new List<Song>();
        }
        public void AddSong(String title, String author, int duration)
        {
            if (playlist.Any(song => song.GetTitle() == title) && playlist.Any(song => song.GetAuthor() == author) && playlist.Any(song => song.GetDuration().Equals(duration.ToString())))
                Console.WriteLine("This song already exists");
            playlist.Add(new Song(title, author, duration));
            Console.WriteLine("Song has been added");
        }
        public void DeleteSong(int number)
        {
            if (number <= playlist.Count && number > 0)
            {
                playlist.Remove(playlist[number - 1]);
                Console.WriteLine("Song has been removed");
            }
            else Console.WriteLine("Incorrect number");
        }
        public List<Song> SearchByAuthor(String search)
        {
            return playlist.FindAll(result => result.Contains(search));
        }
        public List<Song> SearchByTitle(String search)
        {
            return playlist.FindAll(result => result.Contains(search));
        }
        public void ShowAll()
        {
            Console.WriteLine(playlistName + ":");
            int i = 1;
            foreach (Song song in playlist)
            {
                Console.WriteLine(i + ". ");
                song.PrintInfo();
            }
        }
    }
}
