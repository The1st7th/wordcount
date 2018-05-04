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
    public void testempty()
    {
      Wordstring test = new Wordstring ("", "hello");
      int count = test.count();
      int counter = 0;
      Assert.AreEqual(counter, count);
    }
    [TestMethod]
    public void testcount()
    {
      Wordstring test = new Wordstring ("hello hello hey", "hello");
      int count = test.count();
      int counter = 2;
      Assert.AreEqual(counter, count);
    }
    [TestMethod]
    public void testwithnumbers()
    {
      Wordstring test = new Wordstring ("hello3 hello hey", "hello");
      int count = test.count();
      int counter = 1;
      Assert.AreEqual(counter, count);
    }
    [TestMethod]
    public void testwithpunctuations()
    {
      Wordstring test = new Wordstring ("hello. hello! hey.", "hello");
      int count = test.count();
      int counter = 2;
      Assert.AreEqual(counter, count);
    }
  }
} 