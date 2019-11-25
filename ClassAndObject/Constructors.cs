using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Constructors
    {
        private int date;
        private int month;
        private int year;

        // Default constructor.
        public Constructors()
        {
             date = 0;
             month = 0;
             year = 0;
        }

        // A constructor with two arguments.
        public Constructors(int date, int month, int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }


        //Getters and Setters
        public int _date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public int _month
        {
            get
            {
                return this.month;
            }
            set
            {
                this.month = value;
            }
        }

        public int _year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        // Override the ToString method.
        public override string ToString()
        {
            return $"({date},{month},{year})";
        }


    }
}
