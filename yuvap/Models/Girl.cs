using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yuvap.Models
{
        public class Girl
    {    
       //[DatabaseGenerated(DatabaseGeneratedOption.None)]      
       [Key]
        //public int ID {get; set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display (Name = "Reg. No. Without Prefix of M/F etc.")]
        public int GirlID  { get; set; }
        
        //[Display (Name = "Name")]
        public  string  Name { get; set; }         
        
        [Display (Name = "Mobile No.")]
        public string MobileNum {get;set;}  

       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref1 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref2 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref3 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref4 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref5 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref6 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref7 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Pref8 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int? Pref9 {get; set;}
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int? Pref10 {get; set;}
          
       public  string  GirlLikedByConcat { get; set; } 
        
  //Navigation        
        //public virtual ICollection<GirlLikes> GirlsLike { get; set; }
    }

}