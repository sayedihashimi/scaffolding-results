using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiControllers.Models;

namespace WebApiControllers.Data
{
    public class WebApiControllersContext : DbContext
    {
        public WebApiControllersContext (DbContextOptions<WebApiControllersContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiControllers.Models.Contact> Contact { get; set; } = default!;
    }
}
