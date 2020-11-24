using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace PillsController
{
    class ApplicationContext :  DbContext
    {
        public DbSet<Pill> Pills { get; set; }
        public ApplicationContext() : base("DefaultConnection"){}


    }
}
