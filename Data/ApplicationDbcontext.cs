using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.Data
{
public class AppLicationDbContext : DbContext
{
    public AppLicationDbContext(DbContextOptions<AppLicationDbContext> options) : base(options)
    { }
public DbSet<Person> Person { get; set; }



}


}