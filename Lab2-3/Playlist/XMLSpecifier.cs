using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Playlist
{
    public static class XMLSpecifier
    {
        public static void Save(string path, Playlist list)
        {
            XMLLINQ.saveToXML(path, list);
            //switch (System.Configuration.ConfigurationSettings.AppSettings["XMLType"])
            //{
            //    //case "XMLDocument":
            //    //    XMLDocument.saveToXML(path, list);
            //    //    break;
            //    case "XMLLINQ":
            //        XMLLINQ.saveToXML(path, list);
            //        break;
            //    //case "XMLSerialization":
            //    //    XMLSerialization.saveToXML(path, list);
            //    //    break;
            //}
        }

        public static Playlist loadXML(string path)
        {
            switch (ConfigurationSettings.AppSettings["XMLType"])
            {
                //case "XMLDocument":
                //    return XMLDocument.loadFromXML(path);
                case "XMLLINQ":
                    return XMLLINQ.loadFromXML(path);
                //case "XMLSerialization":
                //    return XMLSerialization.loadFromXML(path);
                default:
                    return null;
            }
        }
    }
}