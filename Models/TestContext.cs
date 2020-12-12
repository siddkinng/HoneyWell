using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserHoneyWell.Models
{
    public class TestContext :DbContext
    {
        public TestContext(DbContextOptions<Users> dbContextOptions): base(dbContextOptions) //scafolding issue due to some VS upgrade 
        {

        }

        public virtual DbSet<Users> USERS { get; set; }
    }
}
