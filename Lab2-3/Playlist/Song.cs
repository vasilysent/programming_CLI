using System;

namespace Playlist
{
    [Serializable]
    public class Song
    {
        private String title;
        private String author;
        private int duration;
        public Song(String title, String author, int duration)
        {
            this.title = title;
            this.author = author;
            this.duration = duration;
        }
        public bool Contains (String search)
        {
            if (this.title.Contains(search) || this.author.Contains(search))
                return true;
            else return false;
        }
        public String GetTitle()
        {
            return this.title;
        }
        public String GetAuthor()
        {
            return this.author;
        }
        public String GetDuration()
        {
            return this.duration.ToString();
        }
        public void PrintInfo ()
        {
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
            Console.WriteLine(this.duration);
        }
    }
}
