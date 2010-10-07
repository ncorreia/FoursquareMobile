using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Foursquare
{
    public class Category
    {
        public Category()
        {
            Id = -1;
            FullPathName = null;
            NodeName = null;
            IconUrl = null;
        }

        public long Id { get; set; }
        public string FullPathName { get; set; }
        public string NodeName { get; set; }
        public string IconUrl { get; set; }

        public override string ToString()
        {
            return (Id != null ? "Id: " + Id + Environment.NewLine : "") +
                (FullPathName != null ? "FullPathName: " + FullPathName + Environment.NewLine : "") +
                (NodeName != null ? "NodeName: " + NodeName + Environment.NewLine: "") +
                (IconUrl != null ? "IconUrl: " + IconUrl : "");
        }

        public static Category Parse(XmlNode node)
        {
            if (node == null)
            {
                return null;
            }
            Category category = new Category();
            if (node.SelectSingleNode("id") != null)
            {
                category.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("fullpathname") != null)
            {
                category.FullPathName = node.SelectSingleNode("fullpathname").InnerText;
            }
            if (node.SelectSingleNode("nodename") != null)
            {
                category.NodeName = node.SelectSingleNode("nodename").InnerText;
            }
            if (node.SelectSingleNode("iconurl") != null)
            {
                category.IconUrl = node.SelectSingleNode("iconurl").InnerText;
            }
            return category;
        }
    }
}
