using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Item> Items { get; set; }
    public DbSet<Stylist> Stylists { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
}
}