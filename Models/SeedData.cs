using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

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
                if (context.Customer.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Customer.AddRange(
                    new Customer
                    {
                        CustomerFirstName = "Kenny",
                        CustomerLastName = "Hartman",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1234 Jewellery Lane", JobBuilder = "Bill Widdick", JobDate = DateTime.Parse("2018-4-14") },
                            new Job { JobAddress = "8296 Calumet Drive", JobBuilder = "Shane Ward", JobDate = DateTime.Parse("2021-8-25") }
                        }
                    },
                    new Customer
                    {
                        CustomerFirstName = "Roger",
                        CustomerLastName = "Beck",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1234 Jewellery Lane", JobBuilder = "Bill Widdick", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "David",
                        CustomerLastName = "Evans",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1234 Jewellery Lane", JobBuilder = "Bill Widdick", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Bill",
                        CustomerLastName = "Widdick",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1234 Jewellery Lane", JobBuilder = "Bill Widdick", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Shane",
                        CustomerLastName = "Ward",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1234 Jewellery Lane", JobBuilder = "Bill Widdick", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Jason",
                        CustomerLastName = "Vineyards",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1302 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-9-30") },
                            new Job { JobAddress = "1303 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-9-30") },
                            new Job { JobAddress = "1305 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-9-23") },
                            new Job { JobAddress = "1438 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                        }
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}