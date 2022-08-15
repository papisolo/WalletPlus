using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data.MappingConfiguration
{
    public static class CustomerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("First_Name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100).HasColumnName("Last_Name");
            modelBuilder.Entity<Customer>().Property(c => c.MiddleName).IsRequired(true).HasMaxLength(100).HasColumnName("Middle Name") ;
            modelBuilder.Entity<Customer>().Property(c => c.Country).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.State).IsRequired(true).HasMaxLength(11);
            modelBuilder.Entity<Customer>().Property(c => c.City ).IsRequired(true).HasMaxLength(11);
            modelBuilder.Entity<Customer>().Property(c => c.BirthDate).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(c => c.Gender).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(c => c.Status ).IsRequired(true);




            return modelBuilder;


        }

  
        }
    }

