//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System;
using System.Windows.Forms;

namespace BikesFactoryBusiness
{
    [Serializable]
    public class MotorBikes : Bikes
    {
        private bool engineStarted = false;

        public bool EngineStarted { get => engineStarted; set => engineStarted = value; }

        public virtual void startEngine()
        {
            EngineStarted = true;
        }

        public override double move()
        {
            if (EngineStarted)
            {
                if (this.Speed < 300)
                {
                    return Speed + 10;
                }
                else
                {
                    MessageBox.Show("The bike reached its maximum speed");
                    return Speed;
                }
            }
            else
            {
                MessageBox.Show("The engine of the bike is stopped");
                return 0;
            }
        }

        public override double stop()
        {
            EngineStarted = false;
            return 0;
        }
    }
}
