using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ShapesDataLayer;

namespace GeometricShapesFinal
{
    class FileHandler
    {
        static string xmlFilePath = @"..\..\data\FileShapes.xml";

        public static void WriteToXmlFile(List<Shapes> listOfShapes)
        {
            XmlWriter writer = XmlWriter.Create(xmlFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Shapes>));
            serializer.Serialize(writer, listOfShapes);
            writer.Close();
        }

        public static List<Shapes> ReadFromXmlFile()
        {
            List<Shapes> tempListOfShapes = new List<Shapes>();

            if (File.Exists(xmlFilePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shapes>));
                StreamReader sr = new StreamReader(xmlFilePath);
                tempListOfShapes = (List<Shapes>)xmlSerializer.Deserialize(sr);
                sr.Close();
            }
            return tempListOfShapes;
        }
    }
}
