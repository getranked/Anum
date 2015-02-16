using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace MvcApplication1.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date{ get; set; }
        public string Time{ get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Task> Tasks{ get; set; }
    }
  
}

