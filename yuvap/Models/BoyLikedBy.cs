using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace yuvap.Models
{
       //[DatabaseGenerated(DatabaseGeneratedOption.None)]
       public class BoyLikedBy
    {
          
        [Key]
        public int ID {get; set;}
        public int BoyID { get; set; }
        public int GirlID {get;set;}

       // public BoysLike boysLike {get;set;}
        
        }

}