using System;
using eStoreAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace eStoreAPI.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
    
}