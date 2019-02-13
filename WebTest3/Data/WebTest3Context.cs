using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebTest3.Models
{
    public class WebTest3Context : DbContext
    {
        public WebTest3Context (DbContextOptions<WebTest3Context> options)
            : base(options)
        {
        }

        public DbSet<WebTest3.Models.Pet> Pet { get; set; }
    }
}
