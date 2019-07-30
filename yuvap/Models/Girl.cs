using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yuvap.Models
{
    public partial class Girl
    {
        public Girl()
        {
            BoyLikes = new HashSet<BoyLikes>();
        }
        [Key] //nsb
        public int GirlId { get; set; }
        public string Name { get; set; }
        public string MobileNum { get; set; }
        public string GirlLikedByConcat { get; set; }

        //public virtual GirlLikes GirlLikes { get; set; }
        public virtual ICollection<GirlLikes> GirlLikes { get; set; } //nsb modified
        public virtual ICollection<BoyLikes> BoyLikes { get; set; }
    }
}
