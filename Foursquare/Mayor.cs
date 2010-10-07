using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class Mayor
    {
        public Mayor()
        {
            Type = null;
            CheckIns = -1;
            User = null;
            Message = null;
        }

        public string Type { get; set; }
        public int CheckIns { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public int Count { get; set; }

        public static Mayor Parse(XmlNode node)
        {
            Mayor mayor = new Mayor();
            if (node.SelectSingleNode("type") != null)
            {
                mayor.Type = node.SelectSingleNode("type").InnerText;
            }
            if (node.SelectSingleNode("checkins") != null)
            {
                mayor.CheckIns = int.Parse(node.SelectSingleNode("checkins").InnerText);
            }
            if (node.SelectSingleNode("message") != null)
            {
                mayor.Message = node.SelectSingleNode("message").InnerText;
            }
            if (node.SelectSingleNode("user") != null)
            {
                mayor.User = User.Parse(node.SelectSingleNode("user"));
            }
            if (node.SelectSingleNode("count") != null)
            {
                mayor.Count = int.Parse(node.SelectSingleNode("count").InnerText);
            }
            return mayor;
        }
    }
}
