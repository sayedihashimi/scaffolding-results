using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiEndpoints01.Models;

namespace WebApiEndpoints01.Data
{
    public class WebApiEndpoints01Context : DbContext
    {
        public WebApiEndpoints01Context (DbContextOptions<WebApiEndpoints01Context> options)
            : base(options)
        {
        }

        public DbSet<WebApiEndpoints01.Models.Contact> Contact { get; set; } = default!;
    }
}
