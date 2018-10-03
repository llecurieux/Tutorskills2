using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tutorskills2.Models
{
    public class TutorskillsDb : DbContext
    {
        public DbSet<Post> Posts { get; set; }

    }
}