using Microsoft.EntityFrameworkCore;
using AirportIncidentSystem.Models;

namespace AirportIncidentSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<IncidentReport> IncidentReports { get; set; }
    }
}