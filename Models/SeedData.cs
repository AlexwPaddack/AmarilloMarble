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
                        CustomerFirstName = "David",
                        CustomerLastName = "Evans",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1234 Jewellery Lane", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
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
                            new Job { JobAddress = "1300 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1436 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "4209 Merlot", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1305 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1304 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1303 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1300 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1436 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1438 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "4209 Fume", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1305 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1300 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1303 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1304 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1436 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1348 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "4209 Riesling", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1300 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1302 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1303 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1304 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1305 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1436 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "1438 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") },
                            new Job { JobAddress = "4209 Inez", JobBuilder = "Neilson Communities", JobDate = DateTime.Parse("2021-11-3") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Jim",
                        CustomerLastName = "Seybert",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "401 24th", JobBuilder = "N/A", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Stan",
                        CustomerLastName = "Brown",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "5709 Dixon", JobBuilder = "N/A", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Karen",
                        CustomerLastName = "Frank",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "519 South Bayberry Circle", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-5-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Becky",
                        CustomerLastName = "Daniels",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "7566 Franklin Ave.", JobBuilder = "Shane Ward Construction", JobDate = DateTime.Parse("2018-6-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Raudel",
                        CustomerLastName = "Mendoza",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "98 Durham Court", JobBuilder = "Dewald Construction", JobDate = DateTime.Parse("2018-7-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Chase",
                        CustomerLastName = "Case",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "7677 Elmwood St.", JobBuilder = "David Evans Remodling", JobDate = DateTime.Parse("2018-8-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Cheryl",
                        CustomerLastName = "Compton",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "1 Catherine Court", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-9-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Chad",
                        CustomerLastName = "Smiley",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "350 Country Club Lane", JobBuilder = "Dewald Construction", JobDate = DateTime.Parse("2018-10-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Kimora",
                        CustomerLastName = "Kent",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "7386 Queen Road", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-11-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Jeffery",
                        CustomerLastName = "Farmer",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "730 Mill St.", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-12-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Sophia",
                        CustomerLastName = "Gill",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "66 Washington Road", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Devon",
                        CustomerLastName = "Sanders",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "5 Greenview St.", JobBuilder = "Dewald Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Layton",
                        CustomerLastName = "Vincent",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "105 Cedarwood Drive", JobBuilder = "Case Concepts", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Caitlin",
                        CustomerLastName = "Cook",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "9067 W. Marconi Rd.", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Colten",
                        CustomerLastName = "White",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "934 NW. Hill Drive", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Walter",
                        CustomerLastName = "White",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "9 State Drive", JobBuilder = "Shane Ward Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Kayley",
                        CustomerLastName = "Keith",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "3 Rose Dr.", JobBuilder = "Shane Ward Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Gerald",
                        CustomerLastName = "Petty",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "9630 S. Redwood Drive", JobBuilder = "Rillo Roofing", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Joey",
                        CustomerLastName = "Jordisan",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "8831 Courtland Drive", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Corey",
                        CustomerLastName = "Taylor",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "51 Green Hill Lane", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Will",
                        CustomerLastName = "Ramos",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "8053 10th Street", JobBuilder = "Shane Ward Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    },

                    new Customer
                    {
                        CustomerFirstName = "Armando",
                        CustomerLastName = "Montoya",
                        Jobs = new List<Job> {
                            new Job { JobAddress = "601 Pendergast Road", JobBuilder = "B&J Construction", JobDate = DateTime.Parse("2018-4-14") }
                        }
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
} 