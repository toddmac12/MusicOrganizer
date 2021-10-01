using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public void Dispose()

    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitile_String()
    { //arange
      string title = "new record";
      Record newRecord = new Record(title);
      //Act
      string result = newRecord.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "new record";
      Record newRecord = new Record(title);

      //Act
      string updatedTitle = "new record 2";
      newRecord.Title = updatedTitle;
      string result = newRecord.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_RecordList()
    {
      // Arrange
      List<Record> newList = new List<Record> { };

      // Act
      List<Record> result = Record.GetAll();
     

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void GetId_RecordInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "new record 2";
      Record newRecord = new Record(title);

      int result = newRecord.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectRecord_Record () {
      //Arrange
      string title01 = "new record";
      string title02 = "new record 2";
      Record newRecord1 = new Record (title01);
      Record newRecord2 = new Record (title02);

      //Act
        Record result = Record.Find(2);

      //Assert
      Assert.AreEqual (newRecord2, result);
    }

  }
}
