using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmarilloMarble.Models;

    public class RazorPagesCustomerContext : DbContext
    {
        public RazorPagesCustomerContext (DbContextOptions<RazorPagesCustomerContext> options)
            : base(options)
        {
        }

        public DbSet<AmarilloMarble.Models.Customer> Customer { get; set; }
    }
