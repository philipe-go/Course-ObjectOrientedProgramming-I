//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using BikesFactoryBusiness;
using System.Windows.Forms;

namespace BikesFactoryData
{
    public abstract class FileHandler
    {
        #region ##file handler for the Bikes Data Base##
        static string xmlFilePath = @"..\..\data\BikesDataBase.xml";

        public static void writeXmlFile(List<Bikes> aListOfBikes)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Bikes>));
            XmlWriter writer = XmlWriter.Create(xmlFilePath);
            xs.Serialize(writer, aListOfBikes);
            writer.Close();
        }

        public static List<Bikes> readXmlFile()
        {
            List<Bikes> tempListOfBikes = new List<Bikes>();
            if (File.Exists(xmlFilePath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Bikes>));
                StreamReader sr = new StreamReader(xmlFilePath);
                tempListOfBikes = (List<Bikes>)xs.Deserialize(sr);
                sr.Close();
            }
            else { MessageBox.Show("There is no Data Base generated"); }
            return tempListOfBikes;
        }
        #endregion

        #region ##file handler for the Users Data Base##
        static string userFilePath = @"..\..\data\UsersDataBase.xml";
        //public Accounts newUser = new Accounts();

        public static void writeUsersFile()
        {
            List<Accounts> aListOfUsers = new List<Accounts>();
            aListOfUsers.Add(new Accounts("admin", "123"));

            XmlSerializer xs = new XmlSerializer(typeof(List<Accounts>));
            XmlWriter writer = XmlWriter.Create(userFilePath);
            xs.Serialize(writer, aListOfUsers);
            writer.Close();
        }

        public static void writeUsersFile(Accounts newUser)
        {
            List<Accounts> aListOfUsers = new List<Accounts>();
            aListOfUsers.Add(new Accounts("admin", "123"));
            aListOfUsers.Add(newUser);

            XmlSerializer xs = new XmlSerializer(typeof(List<Accounts>));
            XmlWriter writer = XmlWriter.Create(userFilePath);
            xs.Serialize(writer, aListOfUsers);
            writer.Close();
        }

        public static List<Accounts> readUsersFile()
        {
            List<Accounts> tempListOfUsers = new List<Accounts>();
            if (File.Exists(userFilePath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Accounts>));
                StreamReader sr = new StreamReader(userFilePath);
                tempListOfUsers = (List<Accounts>)xs.Deserialize(sr);
                sr.Close();
            }
            return tempListOfUsers;
        }
        #endregion
    }
}
