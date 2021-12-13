using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsMvcApplication.Models
{
    public class SuperVisor
    {
        string firstName;
        string lastName;
        int birthYear;
        int workXP;

        public SuperVisor(string _firstName, string _lastName, int _birthYear, int _workXP)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.birthYear = _birthYear;
            this.workXP = _workXP;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }

        public int WorkXP
        {
            get { return this.workXP; }
            set { this.workXP = value; }
        }
    }
}