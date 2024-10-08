using BaiKiemTra03_02.Controllers;
using BaiKiemTra03_02.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTra03_02.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<book> book { get; set; }
        public DbSet<Author> Author { get; set; }

    }
}
