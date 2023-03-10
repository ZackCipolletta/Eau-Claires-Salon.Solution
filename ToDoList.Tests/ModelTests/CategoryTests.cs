using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class StylistTests : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
    }

    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new Stylist("test stylist");
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      string result = newStylist.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsStylistId_Int()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      int result = newStylist.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

      [TestMethod]
  public void GetAll_ReturnsAllStylistObjects_StylistList()
  {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    Stylist newStylist1 = new Stylist(name01);
    Stylist newStylist2 = new Stylist(name02);
    List<Stylist> newList = new List<Stylist> { newStylist1, newStylist2 };

    //Act
    List<Stylist> result = Stylist.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

    [TestMethod]
    public void AddItem_AssociatesItemWithStylist_ItemList()
    {
      // Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      List<Item> newList = new List<Item> { newItem };
      string name = "Work";
      Stylist newStylist = new Stylist(name);
      newStylist.AddItem(newItem);

      // Act
      List<Item> result = newStylist.Items;

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }




  }
}