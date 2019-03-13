using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace hw17
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (WebClient client = new WebClient())
            //{
            //    var items = new List<Item>();

            //    client.Encoding = Encoding.UTF8;

            //    var xml = client.DownloadString("https://habr.com/ru/rss/interesting/");

            //    XmlDocument xmlDocument = new XmlDocument();
            //    xmlDocument.LoadXml(xml);

            //    foreach (XmlElement element in xmlDocument.GetElementsByTagName("item"))
            //    {
            //        XmlNode titleElement = null;
            //        XmlNode linkElement = null;
            //        XmlNode descriptionElement = null;
            //        XmlNode pubDateElement = null;

            //        foreach (XmlElement child in element)
            //        {
            //            if (child.Name == "title")
            //            {
            //                titleElement = child;
            //                //Console.WriteLine("{0} = {1}", child.Name, child.InnerText);              //1 задание
            //            }
            //            else if (child.Name == "link")
            //            {
            //                linkElement = child;
            //                //Console.WriteLine("{0} = {1}", child.Name, child.InnerText);
            //            }
            //            else if (child.Name == "description")
            //            {
            //                descriptionElement = child;
            //                //Console.WriteLine("{0} = {1}", child.Name, child.InnerText);
            //            }
            //            else if (child.Name == "pubDate")
            //            {
            //                pubDateElement = child;
            //                //Console.WriteLine("{0} = {1}", child.Name, child.InnerText);
            //            }
            //        }
            //        var item = new Item
            //        {
            //            Title = titleElement.InnerText,
            //            Link = linkElement.InnerText,
            //            Description = descriptionElement.InnerText,
            //            PubDate = pubDateElement.InnerText,
            //        };
            //        items.Add(item);
            //    }             
            //}

            
           
            XmlDocument xmlDocument = new XmlDocument();
            
            XmlElement rootStudentElement = xmlDocument.CreateElement("student");

            XmlElement firstNameElement = xmlDocument.CreateElement("firstName");
            firstNameElement.InnerText = "Андрей";
            rootStudentElement.AppendChild(firstNameElement);
            
            XmlElement lastNameElement = xmlDocument.CreateElement("lastName");                  //2 задание
            lastNameElement.InnerText = "Андреев";
            rootStudentElement.AppendChild(lastNameElement);

            XmlElement ageElement = xmlDocument.CreateElement("age");
            ageElement.InnerText = "18";
            rootStudentElement.AppendChild(ageElement);
            
            XmlElement cityElement = xmlDocument.CreateElement("city");
            cityElement.InnerText = "Астана";
            rootStudentElement.AppendChild(cityElement);
          
            xmlDocument.AppendChild(rootStudentElement);
           
            xmlDocument.Save("data.xml");

            Console.ReadKey();
        }
    }
}
