using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class EarlyBinding
    {
        private string name;
        private string subject;

        public EarlyBinding(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public string getName { get => name; }
        public string getSubject { get => subject; }

        public void details()
        {
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am studing " + subject);
        }
    }
}
