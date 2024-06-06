using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using trycode_test.Models;

namespace trycode_test.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students = default!;
    public DbSet<Premium> Premiums = default!;

public DbSet<trycode_test.Models.Student> Student { get; set; } = default!;
}

