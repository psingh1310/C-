using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{
    class Part : IEquatable<Part>
    {
        public string name { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return "ID: " + id + " Name: " + name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Part objAspart = obj as Part;
            if (objAspart == null)
                return false;
            else return Equals(objAspart);

        }

        public override int GetHashCode()
        {
            return id;
        }

        public bool Equals(Part other)
        {
            if (other == null)
                return false;
            return (this.id.Equals(other.id));
        }
    }
}
