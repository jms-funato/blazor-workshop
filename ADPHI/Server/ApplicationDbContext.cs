using System.Collections.Generic;
using ADPHI.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ADPHI.Server
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //連結コンボボックス　テストデータ
            var countries = new List<Country>()
            {
                new Country(){Id = 1, Name = "Dominican Republic"},
                new Country(){Id = 2, Name = "United States" }
            };

            modelBuilder.Entity<Country>().HasData(countries);

            var states = new List<State>() {
              new State {Id = 1, Name = "Santo Domingo", CountryId = 1},
              new State {Id = 2, Name = "San Cristobal", CountryId = 1},
              new State {Id = 3, Name = "Vermont", CountryId = 2},
              new State {Id = 4, Name = "New York", CountryId = 2}
            };

            modelBuilder.Entity<State>().HasData(states);

            var people = new List<Person>();
            for (int i = 1; i < 100; i++)
            {
                people.Add(new Person() { Id = i, Name = $"Person {i}", StateId = 1 });
            }

            modelBuilder.Entity<Person>().HasData(people);

            base.OnModelCreating(modelBuilder);
        }
    }
}
