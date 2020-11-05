using Microsoft.EntityFrameworkCore;
using RESTfulAPIPractice.Models;

namespace RESTfulAPIPractice.Data
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options) : base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }
    }
}