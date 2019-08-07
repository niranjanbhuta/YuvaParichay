using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yuvap.Models
{
    public partial class GirlLikes
    {
        [Key] //nsb
        public int ID {get; set;}
        public int GirlId { get; set; }
        public int GirlPrefers { get; set; }

        public virtual Girl Girls { get; set; }
        public virtual Boy GirlPrefersNavigation { get; set; }
    }
}
