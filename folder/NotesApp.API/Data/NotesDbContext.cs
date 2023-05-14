using Microsoft.EntityFrameworkCore;
using NotesApp.API.Models.DomainModel;

namespace NotesApp.API.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
