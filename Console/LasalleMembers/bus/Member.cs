using System;
using System.Collections.Generic;
using System.Text;

namespace LasalleMembers.bus
{
    public abstract class Member
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

        public abstract double CalculPayment();
    }
}
