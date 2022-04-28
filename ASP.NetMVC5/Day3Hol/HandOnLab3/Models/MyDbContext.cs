using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HandOnLab3.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=conn")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}