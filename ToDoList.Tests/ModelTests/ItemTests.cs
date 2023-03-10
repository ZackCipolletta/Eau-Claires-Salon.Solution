using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTests : IDisposable
  {

    public IConfiguration Configuration { get; set; }

    public void Dispose()
    {
      Client.ClearAll();
    }
    
    public ClientTests()
    {
      IConfigurationBuilder builder = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
      DBConfiguration.ConnectionString = Configuration["ConnectionStrings:TestConnection"];
    }
    // [TestMethod]
    // public void ClientConstructor_CreatesInstanceOfClient_Client()
    // {
    //   Client newClient = new Client("test");
    //   Assert.AreEqual(typeof(Client), newClient.GetType());
    // }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";

    //   //Act
    //   Client newClient = new Client(description);
    //   string result = newClient.Description;

    //   //Assert
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Client newClient = new Client(description);

    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newClient.Description = updatedDescription;
    //   string result = newClient.Description;

    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ClientList()
    {
      // Arrange
      List<Client> newList = new List<Client> { };

      // Act
      List<Client> result = Client.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsClients_ClientList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Client newClient1 = new Client(description01);
      newClient1.Save();
      Client newClient2 = new Client(description02);
      newClient2.Save();
      List<Client> newList = new List<Client> { newClient1, newClient2 };

      //Act
      List<Client> result = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Client()
    {
      // Arrange, Act
      Client firstClient = new Client("Mow the lawn");
      Client secondClient = new Client("Mow the lawn");

      // Assert
      Assert.AreEqual(firstClient, secondClient);
    }

    // [TestMethod]
    // public void GetId_ClientsInstatiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Client newClient = new Client(description);

    //   //Act
    //   int result = newClient.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectClient_Client()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Client newClient1 = new Client(description01);
    //   Client newClient2 = new Client(description02);

    //   // Act
    //   Client result = Client.Find(2);

    //   // Assert
    //   Assert.AreEqual(newClient2, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectStylist_Stylist()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Stylist newStylist1 = new Stylist(name01);
    //   Stylist newStylist2 = new Stylist(name02);

    //   //Act
    //   Stylist result = Stylist.Find(2);

    //   //Assert
    //   Assert.AreEqual(newStylist2, result);
    // }

        [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_ClientList()
    {
      // Arrange
      List<Client> newList = new List<Client> { };

      // Act
      List<Client> result = Client.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Save_SavesToDatabase_ClientList()
    {
      // Arrange
      Client testClient = new Client("Most the lawn");

      // Act
      testClient.Save();
      List<Client> result = Client.GetAll();
      List<Client> testList = new List<Client> { testClient };

      // Assert
      CollectionAssert.AreEqual(testList, result);
    }

        [TestMethod]
    public void Find_ReturnsCorrectClientFromDatabase_Client()
    {
      //Arrange
      Client newClient = new Client("Mow the lawn");
      newClient.Save();
      Client newClient2 = new Client("Wash dishes");
      newClient2.Save();

      //Act
      Client foundClient = Client.Find(newClient.Id);
      //Assert
      Assert.AreEqual(newClient, foundClient);
    }
  }

}