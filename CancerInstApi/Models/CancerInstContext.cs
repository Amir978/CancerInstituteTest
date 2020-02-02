using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancerInstApi.Models
{
    public class CancerInstContext : DbContext
    {
        public CancerInstContext(DbContextOptions<CancerInstContext> options) 
            : base(options)
        {

        }
        public DbSet<Palindrome> Palindromes { get; set; }
    }
}
