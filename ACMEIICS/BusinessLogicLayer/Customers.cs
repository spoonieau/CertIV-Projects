using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEIICS.BusinessLogicLayer
{
    class Customers
    {
        private string firstName, lastName, address, suburb, state, gender, birthDate;
        private int customerID, categoryID, postCode;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }

        }
        //Declaring Default Constructor
        public Customers() { }

        //Parameterised Constructor
        public Customers(int customerid, int categoryid, string firstname,
                         string lastname, string address, string suburb,
                         string state, int postcode, string gender, string birthDate)
        {
            CustomerID = customerid;
            CategoryID = categoryid;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Suburb = suburb;
            State = state;
            PostCode = postcode;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
