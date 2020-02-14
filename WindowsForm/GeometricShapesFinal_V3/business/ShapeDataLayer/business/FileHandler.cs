using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    public class FileHandler
    {
        static string xmlFilePath = @"../../data/ShapesDataBase.xml";

        public static void writeToXML(List<Shapes> aListOfShapes)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shapes>), new Type[] { typeof(Squares), typeof(Rectangles), typeof(Circles), typeof(Ellipses) });
            serializer.Serialize(writer, aListOfShapes);
            writer.Close();
        }

        public static List<Shapes> readFromXML()
        {
            List<Shapes> tempListOfShapes = new List<Shapes>();
            if (File.Exists(xmlFilePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shapes>), new Type[] { typeof(Squares), typeof(Rectangles), typeof(Circles), typeof(Ellipses) });
                StreamReader sr = new StreamReader(xmlFilePath);
                tempListOfShapes = (List<Shapes>)xmlSerializer.Deserialize(sr);
                sr.Close();
            }
            else { MessageBox.Show("There is no Data Base generated"); }

            return tempListOfShapes;

        }
    }
}
