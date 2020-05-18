﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using WishList.Models;
namespace WishList.Data

{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Item> Items;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
