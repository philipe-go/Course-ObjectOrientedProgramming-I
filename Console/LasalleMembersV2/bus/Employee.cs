using System;
using System.Collections.Generic;
using System.Text;

namespace LasalleMembersV2.bus
{
    public class Employee : Member
    {
        #region //class private attributes
        private double hrsPerWeek;
        private double hourlyRate;
        #endregion

        #region //attributes properties
        public double HrsPerWeek { get => hrsPerWeek; set => hrsPerWeek = value; }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        #endregion

        //parameterless method
        public Employee() : base()
        {
            this.hrsPerWeek = 0.00;
            this.hourlyRate = 0.00;
            base.Id = 00;
        }

        //parameter method
        public Employee(double hpw, double hr) : base()
        {
            this.hrsPerWeek = hpw;
            this.hourlyRate = hr;
            Member member = new Member();
        }

        //parameter method v2
        public Employee(double hpw, double hr, int id, string fn, string ln) : base()
        {
            this.hrsPerWeek = hpw;
            this.hourlyRate = hr;
            base.Id = id;
            base.FirstName = fn;
            base.LastName = ln;
        }

        //CalculPayment base class abstract method override
        public override double CalculPayment()
        {
            return (this.hourlyRate * this.hrsPerWeek);
        }

        //ToString method override
        public override string ToString()
        {
            return ("Employee informations: \n\t - ID: " + Convert.ToString(base.Id) + "\n\t - First Name: " + base.FirstName + "\n\t - Last Name: " + base.LastName + "\n\t - Total to receive: " + Convert.ToString(CalculPayment()));
        }
    }
}
