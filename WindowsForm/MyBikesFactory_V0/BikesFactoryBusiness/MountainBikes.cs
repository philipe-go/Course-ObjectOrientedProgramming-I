//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System;
using System.Windows.Forms;

namespace BikesFactoryBusiness
{
    [Serializable]
    public class MountainBikes : BMXBikes
    {
        private bool suspension = true;
        private int suspensionlifetime = 5;

        public bool Suspension { get => suspension; set => suspension = value; }
        public int Suspensionlifetime { get => suspensionlifetime; set => suspensionlifetime = value; }

        public override bool jump()
        {
            if (suspension)
            {
                Suspensionlifetime--;
                if(Suspensionlifetime<1) { suspension = false; }
            }

            return suspension;
        }

        public void installSuspension()
        {
            this.suspension = true;
            this.Suspensionlifetime = 1000;
        }

        public override double move()
        {
            if (this.Speed < 25)
            {
                return Speed + 2;
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
