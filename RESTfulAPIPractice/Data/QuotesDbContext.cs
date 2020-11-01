using Microsoft.EntityFrameworkCore;
using RESTfulAPIPractice.Models;

namespace RESTfulAPIPractice.Data
{
    public class QuotesDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
    }
}