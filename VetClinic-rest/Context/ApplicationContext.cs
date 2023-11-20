using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using VetClinic_Rest.Models;

namespace VetClinic_Rest.Context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { 

        }

        public DbSet<Clients> Clients { get; set; }

    }
}
