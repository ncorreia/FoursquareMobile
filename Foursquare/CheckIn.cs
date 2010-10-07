using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class CheckIn
    {
        public CheckIn()
        {
            Id = -1;
            Display = null;
            Created = DateTime.MinValue;
            Venue = null;
            User = null;
            Shout = null;
            Distance = -1;
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public Venue Venue { get; set; }
        public User User { get; set; }
        public string Display { get; set; }
        public string Shout { get; set; }
        public double Distance { get; set; }

        public static CheckIn Parse(XmlNode node)
        {
            CheckIn checkIn = new CheckIn();
            if (node.SelectSingleNode("id") != null)
            {
                checkIn.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("created") != null)
            {
                checkIn.Created = DateTime.Parse(node.SelectSingleNode("created").InnerText);
            }
            if (node.SelectSingleNode("venue") != null)
            {
                checkIn.Venue = Venue.Parse(node.SelectSingleNode("venue"));
            }
            if (node.SelectSingleNode("user") != null)
            {
                checkIn.User = User.Parse(node.SelectSingleNode("user"));
            }
            if (node.SelectSingleNode("display") != null)
            {
                checkIn.Display = node.SelectSingleNode("display").InnerText;
            }
            if (node.SelectSingleNode("shout") != null)
            {
                checkIn.Shout = node.SelectSingleNode("shout").InnerText;
            }
            if (node.SelectSingleNode("distance") != null)
            {
                checkIn.Distance = double.Parse(node.SelectSingleNode("distance").InnerText);
            }
            return checkIn;
        }
    }
}
