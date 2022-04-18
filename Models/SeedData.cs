using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AmarilloMarble.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CustomerDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<CustomerDbContext>>()))
            {
                // Look for any Customers.
                if (context.Customers.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Customers.AddRange(
                    new Customer
                    {
                        CustomerFirstName = "Kenny",
                        CustomerLastName = "Hartman"
                    },
                    new Customer
                    {
                        CustomerFirstName = "",
                        CustomerLastName = "Beck"
                    },

                    new Customer
                    {
                        CustomerFirstName = "David",
                        CustomerLastName = "Evans"
                    },

                    new Customer
                    {
                        CustomerFirstName = "Bill",
                        CustomerLastName = "Widick"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}