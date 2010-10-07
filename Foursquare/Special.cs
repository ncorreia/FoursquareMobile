using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class Special
    {
        public Special()
        {
            Id = -1;
            Type = null;
            Kind = null;
            Message = null;
            Venue = null;
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public string Kind { get; set; }
        public string Message { get; set; }
        public Venue Venue { get; set; }

        public static Special Parse(XmlNode node)
        {
            Special special = new Special();
            if (node.SelectSingleNode("id") != null)
            {
                special.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("type") != null)
            {
                special.Type = node.SelectSingleNode("type").InnerText;
            }
            if (node.SelectSingleNode("kind") != null)
            {
                special.Kind = node.SelectSingleNode("kind").InnerText;
            }
            if (node.SelectSingleNode("message") != null)
            {
                special.Message = node.SelectSingleNode("message").InnerText;
            }
            if (node.SelectSingleNode("venue") != null)
            {
                special.Venue = Venue.Parse(node.SelectSingleNode("venue"));
            }
            return special;
        }
    }
}
