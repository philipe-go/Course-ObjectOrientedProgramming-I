using System;
using System.Collections.Generic;
using System.Text;

namespace LasalleMembersV2.bus
{
    class Student : Member
    {
        #region //class private attributes
        private double firstFees;
        private double feesPerSession;
        private int numberOfSessions;
        #endregion

        #region //attributes properties
        public double FirstFees { get => firstFees; set => firstFees = value; }
        public double FeesPerSession { get => feesPerSession; set => feesPerSession = value; }
        public int NumberOfSessions { get => numberOfSessions; set => numberOfSessions = value; }
        #endregion

        //parameterless method
        public Student() : base()
        {
            this.firstFees = 0.00;
            this.feesPerSession = 0.00;
            this.numberOfSessions = 0;
            base.Id = 00;
            base.FirstName = "unknown";
            base.LastName = "unknown";
        }

        //parameter method
        public Student(double ff, double fps, int ns, int id, string fn, string ln) : base()
        {
            this.firstFees = ff;
            this.feesPerSession = fps;
            this.numberOfSessions = ns;
            base.Id = id;
            base.FirstName = fn;
            base.LastName = ln;
        }

        //CalculPayment base class abstract method override
        public override double CalculPayment()
        {
            return (this.firstFees + (this.feesPerSession * this.numberOfSessions));
        }

        //ToString method override
        public override string ToString()
        {
            return ("Student informations: \n\t - ID: " + Convert.ToString(base.Id) + "\n\t - First Name: " + base.FirstName + "\n\t - Last Name: " + base.LastName + "\n\t - Total Payment: " + Convert.ToString(CalculPayment()));
        }
    }
}
