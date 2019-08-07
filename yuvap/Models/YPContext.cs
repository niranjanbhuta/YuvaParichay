using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace yuvap.Models
{
    public partial class YPContext : DbContext //yuvap_schemaContext
    {
        public YPContext() //yuvap_schemaContext()
        {
        }

        public YPContext(DbContextOptions<YPContext> options) //yuvap_schemaContext
            : base(options)
        {
        }

        public virtual DbSet<Boy> Boy { get; set; }
        public virtual DbSet<BoyLikes> BoyLikes { get; set; }
        public virtual DbSet<Girl> Girl{ get; set; }
        public virtual DbSet<GirlLikes> GirlLikes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=127.0.0.1,3306;Database=indiafxp_yuvap;User Id=india_yuvap;Pwd=Yuvap@123");
            }
        }

// Assembly:  MySql.Data.EntityFrameworkCore (in MySql.Data.EntityFrameworkCore.dll) Version: 8.0.17, https://dev.mysql.doc... 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Boy>(entity =>            
            {
    // entity.HasKey(e => e.BoyID); //nsb added

                entity.ToTable("Boy", "indiafxp_yuvap"); //MySql = yuvap ,yuvap_schema) ; MSSql, MySql = indiafxp_yuvap

                entity.Property(e => e.BoyId)
                    .HasColumnName("Reg. Num.") //BoyId
                    .HasColumnType("int")
                    .ValueGeneratedNever();
                    

                entity.Property(e => e.BoylikedByConcat)
                    .HasColumnName("Girls Want to Cantact Me") //("Interested Girls")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNum)
                    .HasColumnName("Mobile Num.")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                   // .HasColumnName("Password")
                    //.HasMaxLength()
                    .IsUnicode(false);

               entity.Property(e => e.EditLock);
               // b.Property<bool>("EditLock");

            }    );  //')' is extra ? NO.

            modelBuilder.Entity<BoyLikes>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("BoyLikes", "indiafxp_yuvap");

                entity.HasIndex(e => e.BoyPrefers)
                    .HasName("Idx_BoyLikes_BoyPrefers");
              
                entity.Property (e => e.ID)
                .ValueGeneratedOnAdd() ;                

                entity.Property(e => e.BoyId)
                    .HasColumnName("BoyID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.BoyPrefers)
                    .HasColumnType("int)");                    

                entity.HasOne(d => d.Boys)  //Navigation Properties  of 'Many-Table'.   Is 'd' for property-name ?              
                    //.WithMany(p => BoyLikes) // Many-Table Name. Is 'p' for table-name ?
                    .WithMany(p => p.BoyLikes )
                    //.HasForeignKey<BoyLikes>(d => d.BoyId)
                    .HasForeignKey(d => d.BoyId)  //Many-Table Property 
                    .HasConstraintName("FK_BoyLikesBoyID_BoyBoyID");                 

             
              /*   entity.HasOne(d => d.BoyPrefersNavigation) //
                    .WithMany(p => p.BoyLikes)
                    .HasForeignKey(d => d.BoyPrefers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoyLikesBoyPrefers_GirlGirlID");
                */

                     entity.HasOne (d => d.BoyPrefersNavigation)          //("Girl") //
                    //.WithMany(p => BoyLikes)
                    .WithMany(p => p.BoyLikes)
                    .HasForeignKey(d => d.BoyPrefers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoyLikesBoyPrefers_GirlGirlID");           
            
            }  );
               // modelBuilder.Entity<BoyLikes>()
               //   .HasIndex(e =>  e.BoyID, e.BoyPrefers).IsUnique();  // nsb 1-2-19. Validate that same girl is not preferred
                   // .HasName("Idx_BoyLikes_BoyId-BoyPrefers");
          /*   modelBuilder.Entity<BoyLikes>()
             .HasIndex(p => new { p.qwerty, p.BoyPrefers}); //err: 'BoyLikes' does not contain a definition for 'BoyID'
           */ 

            modelBuilder.Entity<Girl>(entity =>
            {
                entity.ToTable("Girl", "indiafxp_yuvap");

                entity.Property(e => e.GirlId)
                    .HasColumnName("GirlID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.GirlLikedByConcat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GirlLikes>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("GirlLikes", "indiafxp_yuvap");

                entity.HasIndex(e => e.GirlPrefers)
                    .HasName("Idx_GirlLikes_GirlPrefers");

                entity.Property(e => e.ID)
                .ValueGeneratedOnAdd() ;

                entity.Property(e => e.GirlId)
                    .HasColumnName("GirlID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.GirlPrefers).HasColumnType("int");

                /* 
                entity.HasOne(d => d.Girls)
                    .WithOne(p => p.GirlLikes)
    //     .WithMany(p => p.GirlLikes) 
                    //.HasForeignKey<GirlLikes>(d => d.GirlId)
                   .HasForeignKey(d => d.GirlId)
                    .HasConstraintName("FK_GirlLikesGirlID_GirlGirlID");
                 */   


                     entity.HasOne(d => d.Girls)
                    //.WithOne(p => p.BoyLikes)
                    .WithMany(p => p.GirlLikes) // nsb modified
                    //.HasForeignKey<BoyLikes>(d => d.BoyId)
                    .HasForeignKey(d => d.GirlId)  //nsb
                    .HasConstraintName("FK_GirlLikesGirlID_GirlGirlID");
            
                entity.HasOne(d => d.GirlPrefersNavigation)
                    .WithMany(p => p.GirlLikes)
                    .HasForeignKey(d => d.GirlPrefers)
                    .HasConstraintName("FK_GirlLikesGirlPrefers_BoyBoyID");           

            });
              
               
        } // end onmodelcreating
    } //end of class
} // end of name space

/*
Help

(1) multi-column unique key: https://stackoverflow.com/questions/18889218/unique-key-constraints-for-multiple-columns-in-entity-framework
(a) 
  modelBuilder.Entity<Entity>()
   .HasIndex(p => new {p.FirstColumn , p.SecondColumn}).IsUnique();
(b)
modelBuilder.Entity<Entity>().HasAlternateKey(c => new [] {c.FirstColumn, c.SecondColumn}).HasName("IX_MultipleColumns");
(c)
[UniqueKey, 1] // Unique Key 
public int FirstColumn  { get; set;}
[UniqueKey ,1] // Unique Key 
public int SecondColumn  { get; set;}
(d)
   [Key]
   [Column(Order=0)]
   public int FirstColumn  { get; set;}
   [Key]
   [Column(Order=1)]
   public int SecondColumn  { get; set;}
(e)
        Property(p => p.Name)
            .HasUniqueIndexAnnotation("UK_Employee_Name_Company", 0);
        Property(p => p.CompanyId )
            .HasUniqueIndexAnnotation("UK_Employee_Name_Company", 1);
(f) By code
if (context.Entities.Any(e => e.FirstColumn == value1 
                           && e.SecondC
                           olumn == value2))
{
    // deal with duplicate values here.
}

 */