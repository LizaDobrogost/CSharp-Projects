using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PhoneDataBase
{
    class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<Phone> Phones { get; set; }

    }
}
