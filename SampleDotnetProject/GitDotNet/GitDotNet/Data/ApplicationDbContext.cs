using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GitDotNet.Models;

namespace GitDotNet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GitDotNet.Models.Employee> Employee { get; set; }
        public DbSet<GitDotNet.Models.Person> Person { get; set; }
    }
}
