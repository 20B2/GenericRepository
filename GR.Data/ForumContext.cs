using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Data
{
    public class MasterContext:DbContext
    {
        public MasterContext():base("name=ForumMasterDb")
        {

        }
        public DbSet<Account> Users { get; set; }
    }

    public class ForumContext : DbContext 
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
    }

    public class Users
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string  Password { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserStatus
    {
        public int  ID { get; set; }
        public string Name { get; set; }
    }

    public class Account
    {
        public int ID { get; set; }
        public string AccountType { get; set; }
    }
}
