using Microsoft.VisualStudio.TestTools.UnitTesting;
using stringWordApp.Models;
using System.Collections.Generic;
using System;

namespace wordcount.Tests
{
  [TestClass]
  public class wordtest
  {
    [TestMethod]
    public void testcount()
    {
      Wordstring test = new Wordstring ("hello hello hey", "hello");
      int count = test.count();
      int counter = 2;
      Assert.AreEqual(counter, count);
    }
  }
} 