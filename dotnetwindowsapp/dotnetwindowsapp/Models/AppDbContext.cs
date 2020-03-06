using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dotnetwindowsapp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MyAzureConnection")
        {
        }

        public System.Data.Entity.DbSet<TaskItem> Tasks { get; set; }
    }
}