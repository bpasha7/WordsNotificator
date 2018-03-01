using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordsNotificator
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<MyWord> Dictionary { get; set; }

    }
}
