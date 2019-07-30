using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yuvap.Models
{
    public partial class Boy
    {
        public Boy()
        {
            GirlLikes = new HashSet<GirlLikes>();
            BoyLikes = new HashSet<BoyLikes>(); // nsb 221-1-19
        }
        [Key] //nsb         
        public int BoyId { get; set; }
        public string Name { get; set; }
        public string MobileNum { get; set; }
        public string BoylikedByConcat { get; set; }
        
        public string Password {get;set;} // nsb dt 1-2-19
        //[DataType(bool)]
        public bool EditLock {get;set;}

        //public virtual BoyLikes BoyLikes { get; set; }
        public virtual ICollection<BoyLikes> BoyLikes { get; set; } // nsb modified
        public virtual ICollection<GirlLikes> GirlLikes { get; set; }
    }
}
