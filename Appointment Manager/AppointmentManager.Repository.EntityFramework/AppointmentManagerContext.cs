using AppointmentManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Repository.EntityFramework
{
    public class AppointmentManagerContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
             .Map<Customer>(m =>
             {
                 m.Requires("UserType").HasValue((int)UserRole.Customer);
                 m.ToTable("Users");
             }
             ).Map<ServiceProvider>(m =>
               {
                   m.Requires("UserType").HasValue((int)UserRole.ServiceProvider);
                   m.ToTable("Users");
               }
               )
               .ToTable("Users");


            modelBuilder.Entity<ServiceProviderReview>().HasRequired<Appointment>(a => a.Appointment);

            base.OnModelCreating(modelBuilder);
        }
    }
}
