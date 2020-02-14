using System;
using System.Collections.Generic;
using System.Text;

namespace LasalleMembersV2.bus
{
    public class Member
    {
        #region //class private attibutes
        private int id;
        private string firstName;
        private string lastName;
        #endregion

        #region //attibutes properties
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        #endregion

        //parameterless constructor
        public Member()
        {
            this.id = 000;
            this.firstName = "unknown";
            this.lastName = "unknown";
        }

        //parameter constructor
        public Member(int id, string fn, string ls)
        {
            this.id = id;
            this.firstName = fn;
            this.lastName = ls;
        }

        public virtual double CalculPayment()
        {
            return 0;
        }
    }
}
