using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// primary contructor 
// Initializes a new instance of the DbContext class using the specified options.
public class StoreContext(DbContextOptions options) : DbContext(options)
{
    // A DbSet can be used to query and save instances of Product
  public required DbSet<Product> Products { get; set; }
}
