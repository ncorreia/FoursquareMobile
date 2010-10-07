using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Net;
using System.IO;

namespace Foursquare
{
    public class User
    {
        public User()
        {
            Id = -1;
            FirstName = null;
            LastName = null;
            Photo = null;
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string FriendStatus { get; set; }

        public static User GetUser(long userId)
        {
            string url = string.Format("http://api.foursquare.com/v1/user?uid={0}", userId);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Headers.Add("Authorization", "Basic " + FoursquareAPI.AuthHash);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument xdoc = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                xdoc.Load(stream);
            }
            return User.Parse(xdoc.DocumentElement);
        }

        public static User Parse(XmlNode node)
        {
            User user = new User();

            if (node.SelectSingleNode("id") != null)
            {
                user.Id = long.Parse(node.SelectSingleNode("id").InnerText);
            }
            if (node.SelectSingleNode("firstname") != null)
            {
                user.FirstName = node.SelectSingleNode("firstname").InnerText;
            }
            if (node.SelectSingleNode("lastname") != null)
            {
                user.LastName = node.SelectSingleNode("lastname").InnerText;
            }
            if (node.SelectSingleNode("photo") != null)
            {
                user.Photo = node.SelectSingleNode("photo").InnerText;
            }
            if (node.SelectSingleNode("gender") != null)
            {
                user.Gender = (Gender)Enum.Parse(typeof(Gender), node.SelectSingleNode("gender").InnerText, true);
            }
            if (node.SelectSingleNode("email") != null)
            {
                user.Email = node.SelectSingleNode("email").InnerText;
            }
            if (node.SelectSingleNode("twitter") != null)
            {
                user.Twitter = node.SelectSingleNode("twitter").InnerText;
            }
            if (node.SelectSingleNode("facebook") != null)
            {
                user.Facebook = node.SelectSingleNode("facebook").InnerText;
            }
            if (node.SelectSingleNode("friendstatus") != null)
            {
                user.FriendStatus = node.SelectSingleNode("friendstatus").InnerText;
            }

            return user;
        }
    }
}
