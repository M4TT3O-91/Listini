using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Listino.Models;

namespace Listino.Data
{
    public class ListinoContext : DbContext
    {
        public ListinoContext (DbContextOptions<ListinoContext> options)
            : base(options)
        {
        }

        public DbSet<Listino.Models.Product>? Product { get; set; }
    }
}
