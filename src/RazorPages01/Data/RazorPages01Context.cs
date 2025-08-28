using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages01.Models;

namespace RazorPages01.Data
{
    public class RazorPages01Context : DbContext
    {
        public RazorPages01Context (DbContextOptions<RazorPages01Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPages01.Models.Contact> Contact { get; set; } = default!;
    }
}
