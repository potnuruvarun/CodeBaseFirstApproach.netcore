using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseFirstApproach.Model.Models
{
    public  class UserDbcontext:DbContext
    {
        public UserDbcontext(DbContextOptions <UserDbcontext>options):base(options)
        {
            
        }

        public DbSet<RegistartionModels> UserRegistration { get; set; }
        

    }
}
