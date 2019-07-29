
using Microsoft.EntityFrameworkCore;
using yuvap.Models;
using System;

namespace yuvap.Data {    //Models

public class YPContext : DbContext, IDisposable {

public YPContext  (DbContextOptions<YPContext> options) : base(options)
{
} //Constructor

public DbSet<Boy> Boy {get;set;}
//public DbSet<BoyLikes> BoyLikes {get;set;}
public DbSet<BoyLikedBy> BoyLikedBy {get;set;}

public DbSet<Girl> Girl {get;set;}
//public DbSet<GirlLikes> GirlLikes {get;set;}
public DbSet<GirlLikedBy> GirlLikedBy {get;set;}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Boy>() 
    .HasIndex(b => b.BoyID)
    .IsUnique()   ;

    modelBuilder.Entity<Girl>() 
    .HasIndex(b => b.GirlID)
    .IsUnique()   ;
}

// 2-1-19 nsb Ref. https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html
 /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=192.111.150.72; port=3306;database=indiafxp_yuvap;user=india_indiafxp;password=Yuvap@123");
      //("server=localhost;database=library;user=user;password=password")
    }
    */

/* public DbSet<Car> Cars { get; set; }
    //Fluent API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasKey(c => c.LicensePlate);

          //  .HasIndex(p => new { p.FirstName, p.LastName }) multiple index
    }
 */


 /* SQL Script sample
 CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Passport] NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Users_Passport] UNIQUE NONCLUSTERED ([Passport] ASC)
);
*/

} //class


} //Name space