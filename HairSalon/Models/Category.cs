using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public List<Item> Items { get; set; }
  }
}