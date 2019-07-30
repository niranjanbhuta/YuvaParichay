using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace yuvap.Models
{
    public partial class BoyLikes
    {
        [Key] //nsb
        public int ID {get; set;}
        //[UniqueKey, 1] // multi-col nsb 1-2-19 err: Identifier expected at 21 i.e '1'
        public int BoyId { get; set; }
        //[UniqueKey, 1] // multi-col
        public int BoyPrefers { get; set; }

        public virtual Boy Boys { get; set; }
        public virtual Girl BoyPrefersNavigation { get; set; }
    }
}
