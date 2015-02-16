using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication1.Models
{

    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}