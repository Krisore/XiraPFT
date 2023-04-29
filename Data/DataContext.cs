﻿using Microsoft.EntityFrameworkCore;
using XiraPFT.Model;

namespace XiraPFT.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users => Set<User>();
}