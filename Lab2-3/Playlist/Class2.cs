//using System;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Xml;
//using System.Xml.Schema;

//namespace Playlist
//{
//    class XMLDocument
//    {
//        public static void saveToXML(string path, Playlist list)
//        {
//            XmlDocument doc = new XmlDocument();

//            var root = doc.CreateElement("Playlist");

//            list.SongsList.ForEach(song =>
//            {
//                XmlElement songEl = doc.CreateElement("Playlist");

//                XmlElement titleEl = doc.CreateElement("Title");
//                titleEl.InnerText = song.GetTitle();
//                songEl.AppendChild(titleEl);

//                XmlElement authorEl = doc.CreateElement("Author");
//                authorEl.InnerText = song.GetAuthor();
//                songEl.AppendChild(authorEl);

//                XmlElement durationEl = doc.CreateElement("Duration");
//                durationEl.InnerText = song.GetDuration().ToString(CultureInfo.InvariantCulture);
//                songEl.AppendChild(durationEl);

//                root.AppendChild(songEl);
//            }
//                );
//            doc.AppendChild(root);
//            doc.Save(path);
//        }

//        public static Playlist loadFromXML(string path)
//        {
//            Playlist list = new Playlist("NewPlaylist");
//            XmlDocument doc = new XmlDocument();
//            doc.Load(path);
//            var schema = XmlSchema.Read(new MemoryStream(Encoding.UTF8.GetBytes(Playlist\XMLSchema1)), new ValidationEventHandler(ValidationCallbackOne));
//            doc.Schemas.Add(schema);

//            doc.Validate(new ValidationEventHandler(ValidationCallbackOne));

//            foreach (var s_list in doc.ChildNodes.OfType<XmlElement>().Where(e => e.Name == "ShoppingList"))
//                foreach (var note in s_list.ChildNodes.OfType<XmlElement>().Where(e => e.Name == "ShoppingNote"))
//                {
//                    list.AddSong(
//                    note.GetElementsByTagName("Title").Item(0).InnerText,
//                    note.GetElementsByTagName("Author").Item(0).InnerText,
//                    int.Parse(note.GetElementsByTagName("Duration").Item(0).InnerText, CultureInfo.InvariantCulture));
//                }
//            return list;
//        }
//        public static void ValidationCallbackOne(object sender, ValidationEventArgs args)
//        {
//            Console.WriteLine(args.Message);
//        }
//    }
//}