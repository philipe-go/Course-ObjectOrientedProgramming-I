//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System;

namespace BikesFactoryBusiness
{
    [Serializable]
    public class RoadBikes : Bikes
    {
        public override double move()
        {
            if (this.Speed < 30)
            {
                return Speed + 3;
            }
            else return Speed;
        }
        public override double stop()
        {
            return 0;
        }
    }
}
