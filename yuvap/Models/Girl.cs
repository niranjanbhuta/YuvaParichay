using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//using System.Idisposable;
//using Idisposable

namespace yuvap.Models
{
        public class Girl : IDisposable
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

        // Flag: Has Dispose already been called?
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

         // Protected implementation of Dispose pattern.
   protected virtual void Dispose(bool disposing)
   {
      if (disposed)
         return; 
      
      if (disposing) {
 //        handle.Dispose(); //nsb commented
         // Free any other managed objects here.
         //
      }
      
      disposed = true;
   }



    } //class

} // namespc

/*
Help
Boy SQL
CREATE TABLE `indiafxp_yuvap`. ( `BoyID` INT NOT NULL , `Name` VARCHAR NULL , `MobileNum` VARCHAR NULL , `Pref1` INT NULL , `Pref2` INT NULL , `Pref3` INT NULL , `Pref4` INT NULL , `Pref5` INT NULL , `Pref6` INT NULL , `Pref7` INT NULL , `Pref8` INT NULL , `BoyLikedByConcate` VARCHAR NULL , PRIMARY KEY (`BoyID`)) ENGINE = InnoDB;
 */