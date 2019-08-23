using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YuvaParichay
{
    public class Candidate : IComparable<Candidate>, IEquatable<Candidate>  //, IEnumerable<Candidate>
    
    {
        public string _Code {get ; set;}
        public string _Name { get; set; }
        public string _MobileNum { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Candidate objAsOff = obj as Candidate;
            if (objAsOff == null) return false;
            else return Equals(objAsOff);
        }

        public bool Equals(Candidate other)
        {
            if (other == null) return false;
            return (this._Code.Equals(other._Code));
        }

        // Default comparer for Part type. 
        public int CompareTo(Candidate NextObj)
        {
            // A null value means that this object is greater. 
            if (NextObj == null)
                return 1;

            else
                return this._Code.CompareTo(NextObj._Code);
        }

    }
}
