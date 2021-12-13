using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsMvcApplication.Models
{
    public class WorkManger
    {
        string firstName;
        string lastName;
        string devision;

        public WorkManger(string _firstName, string _lastName, string _devision)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.devision = _devision;
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

        public string Devision
        {
            get { return this.devision; }
            set { this.devision = value; }
        }
    }
}