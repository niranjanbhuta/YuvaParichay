using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace yuvap.Models
{
       public class GirlLikedBy
    {
        
       [Key]
       public int ID {get; set;}
        public int GirlID { get; set; }
        public int BoyID {get;set;}

       // public GirlsLike girlsLike {get;set;}
        
        }
}