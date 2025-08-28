using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWeb01.Models;

namespace MVCWeb01.Data
{
    public class MVCWeb01Context : DbContext
    {
        public MVCWeb01Context (DbContextOptions<MVCWeb01Context> options)
            : base(options)
        {
        }

        public DbSet<MVCWeb01.Models.Contact> Contact { get; set; } = default!;
    }
}
