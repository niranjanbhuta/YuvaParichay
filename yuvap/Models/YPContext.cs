using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Data {    //Models

public class YPContext : DbContext {

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