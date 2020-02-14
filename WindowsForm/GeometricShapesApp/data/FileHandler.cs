using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using GeometricShapesApp.business;
using System.Runtime.Serialization.Formatters.Binary;

namespace GeometricShapesApp.data
{
    public class FileHandler
    {
        private static string filePathBin = @"..\..\data\shapesInventory.bin";

        public static void writeToBinFile(List<Shapes> listOfShapes)
        {
            FileStream fs = new FileStream(filePathBin, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listOfShapes);
            fs.Close();
        }

        public static List<Shapes> ReadFromBinFile()
        {
            List<Shapes> tempListofShapes = new List<Shapes>();

            if (File.Exists(filePathBin))
            {
                FileStream fs = new FileStream(filePathBin, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                tempListofShapes = (List < Shapes >) bf.Deserialize(fs);
                fs.Close();
            }

            return tempListofShapes;
        }
    }
}
