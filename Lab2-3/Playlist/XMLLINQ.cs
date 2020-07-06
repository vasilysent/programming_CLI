using System.Linq;
using System.Xml.Linq;

namespace Playlist
{
    class XMLLINQ
    {

        public static Playlist loadFromXML(string path)
        {
            Playlist list = new Playlist("newPlaylist");
            XDocument.Load(path).Descendants("Playlist").ToList().First().Descendants("Song").ToList().ForEach(song =>
               list.AddSong((string)song.Element("Title"), (string)song.Element("Author"),
               (int)song.Element("Duration")));

            return list;
        }

        public static void saveToXML(string path, Playlist list)
        {
            XDocument doc = new XDocument(
                new XElement("Playlist", list.playlist.Select(songEl => new XElement("Song",
                    new XElement[]
                    {
                        new XElement("Title", songEl.GetTitle()),
                        new XElement("Author", songEl.GetAuthor()),
                        new XElement("Duration", songEl.GetDuration())
                    })).ToArray()
                    ));
            doc.Save(path);
        }
    }
}