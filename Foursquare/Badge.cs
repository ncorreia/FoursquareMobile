using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class Badge
    {
        public Badge()
        {
            Id = -1;
            Name = null;
            Icon = null;
            Description = null;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }

        public static Badge Parse(XmlNode node)
        {
            Badge badge = new Badge();

            if (node.SelectSingleNode("id") != null)
            {
                badge.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("name") != null)
            {
                badge.Name = node.SelectSingleNode("name").InnerText;
            }
            if (node.SelectSingleNode("icon") != null)
            {
                badge.Icon = node.SelectSingleNode("icon").InnerText;
            }
            if (node.SelectSingleNode("description") != null)
            {
                badge.Description = node.SelectSingleNode("description").InnerText;
            }

            return badge;
        }
    }
}
