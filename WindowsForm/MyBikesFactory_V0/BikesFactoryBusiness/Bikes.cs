//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System;
using System.Xml.Serialization;

namespace BikesFactoryBusiness
{
    [Serializable]
    [XmlInclude(typeof(SpeedBikes))]
    [XmlInclude(typeof(RoadBikes))]
    [XmlInclude(typeof(MountainBikes))]
    [XmlInclude(typeof(MotorBikes))]
    [XmlInclude(typeof(BMXBikes))]
    public abstract class Bikes : IMovable
    {
        #region ##attributes##
        private int serialNumber;
        private EnumBikeType bikeType;
        private EnumBikeColor bikeColor;
        private string madeIn;
        private string manufacturer;
        private string manufactureDate;
        private double speed;
        #endregion

        #region ##properties##
        public int SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string MadeIn { get => madeIn; set => madeIn = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string ManufactureDate { get => manufactureDate; set => manufactureDate = value; }
        public EnumBikeType BikeType { get => bikeType; set => bikeType = value; }
        public EnumBikeColor BikeColor { get => bikeColor; set => bikeColor = value; }
        public double Speed { get => speed; set => speed = value; }
        #endregion

        #region ##move methods##
        public abstract double move();

        public abstract double stop();
        #endregion

        #region ##constructors##
        public Bikes()
        {
            this.serialNumber = 0000;
            this.bikeType = EnumBikeType.undefined;
            this.bikeColor = EnumBikeColor.undefined;
            this.madeIn = "undefined";
            this.manufacturer = "undefined";
            this.ManufactureDate = "00/00/0000";
            this.speed = 0;
        }
        public Bikes(int sn, EnumBikeType type, EnumBikeColor col, string made, string manufact, int day, int month, int year)
        {
            this.serialNumber = sn;
            this.bikeType = type;
            this.bikeColor = col;
            this.madeIn = made;
            this.manufacturer = manufact;
            this.ManufactureDate = "00/00/0000";
            this.speed = 0;
        }
        #endregion

        public override string ToString()
        {
            return $"Bike :: Serial: {this.serialNumber} - Details: {this.bikeType} - {this.bikeColor} - {this.madeIn} - {this.manufacturer} - at: {this.ManufactureDate} - Velocity: {this.speed}";
        }
    }
}
