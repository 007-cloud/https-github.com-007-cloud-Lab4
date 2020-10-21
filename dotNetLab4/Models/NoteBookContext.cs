using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetLab4.Models
{
    public class NoteBookContext : DbContext
    {
        public DbSet<NoteBook> NoteBook { get; set; }
        public DbSet<Order> Orders { get; set; }
        public NoteBookContext(DbContextOptions<NoteBookContext> options)
    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
