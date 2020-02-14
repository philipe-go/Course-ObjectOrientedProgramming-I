//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System;
using System.Windows.Forms;

namespace BikesFactoryBusiness
{
    [Serializable]
    public class SpeedBikes : RoadBikes
    {
        public override double move()
        {
            if (this.Speed < 50)
            {
                return Speed + 6;
            }
            else
            {
                MessageBox.Show("The bike reached its maximum speed");
                return Speed;
            }
        }
        public override double stop()
        {
            return 0;
        }
    }
}
