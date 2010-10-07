using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class CheckInInfo
    {
        public CheckInInfo()
        {
            Id = -1;
            Message = null;
            Created = DateTime.MinValue;
            Venue = null;
            Mayor = null;
            Badges = null;
            Scoring = null;
            Specials = null;
        }

        public long Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public Venue Venue { get; set; }
        public Mayor Mayor { get; set; }
        public Badge[] Badges { get; set; }
        public Score[] Scoring { get; set; }
        public Special[] Specials { get; set; }

        public static CheckInInfo Parse(XmlNode node)
        {
            CheckInInfo checkInInfo = new CheckInInfo();
            if (node.SelectSingleNode("id") != null)
            {
                checkInInfo.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("message") != null)
            {
                checkInInfo.Message = node.SelectSingleNode("message").InnerText;
            }
            if (node.SelectSingleNode("created") != null)
            {
                checkInInfo.Created = DateTime.Parse(node.SelectSingleNode("created").InnerText);
            }
            if (node.SelectSingleNode("venue") != null)
            {
                checkInInfo.Venue = Venue.Parse(node.SelectSingleNode("venue"));
            }
            if (node.SelectSingleNode("mayor") != null)
            {
                checkInInfo.Mayor = Mayor.Parse(node.SelectSingleNode("mayor"));
            }
            if (node.SelectSingleNode("badges") != null)
            {
                List<Badge> badges = new List<Badge>();
                foreach (XmlNode n in node.SelectNodes("badges/badge"))
                {
                    badges.Add(Badge.Parse(n));
                }
                checkInInfo.Badges = badges.ToArray();
            }
            if (node.SelectSingleNode("scoring") != null)
            {
                List<Score> scores = new List<Score>();
                foreach (XmlNode n in node.SelectNodes("scoring/score"))
                {
                    scores.Add(Score.Parse(n));
                }
                checkInInfo.Scoring = scores.ToArray();
            }
            if (node.SelectSingleNode("specials") != null)
            {
                List<Special> specials = new List<Special>();
                foreach (XmlNode n in node.SelectNodes("specials/special"))
                {
                    specials.Add(Special.Parse(n));
                }
                checkInInfo.Specials = specials.ToArray();
            }
            return checkInInfo;
        }
    }
}
