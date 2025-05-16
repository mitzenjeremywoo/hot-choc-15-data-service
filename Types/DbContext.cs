﻿using Microsoft.EntityFrameworkCore;

namespace Accounts.Types
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options) { }
    }
}
