using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsMvcApplication.Models
{
    public class Worker
    {
        string firstName;
        string lastName;
        int birthYear;
        int phoneNum;

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

        public int PhoneNumber
        {
            get { return this.phoneNum; }
            set { this.phoneNum = value; }
        }
    }
}