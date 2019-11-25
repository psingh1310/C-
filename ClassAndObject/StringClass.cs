using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class StringClass
    {
        private string name;
        private string dob;
        private string address;

        public StringClass(string name, string dob, string address)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
        }
        public string getname { get => name; }
        public string getdob { get => dob; }
        public string getAddress { get => address; }

        public String toString()
        {
            return ("Hi my name is " + this.getname + " my DOB is " + this.getdob + " my " +
                "Address is " + this.getAddress);
        }
    }



    }

