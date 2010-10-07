using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class Score
    {
        public Score()
        {
            Points = 0;
            Icon = null;
            Message = null;
        }

        public int Points { get; set; }
        public string Icon { get; set; }
        public string Message { get; set; }

        public static Score Parse(XmlNode node)
        {
            Score score = new Score();
            if (node.SelectSingleNode("points") != null)
            {
                score.Points = int.Parse(node.SelectSingleNode("points").InnerText);
            }
            if (node.SelectSingleNode("icon") != null)
            {
                score.Icon = node.SelectSingleNode("icon").InnerText;
            }
            if (node.SelectSingleNode("message") != null)
            {
                score.Message = node.SelectSingleNode("message").InnerText;
            }
            return score;
        }
    }
}
