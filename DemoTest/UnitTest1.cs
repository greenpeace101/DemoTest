﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProject;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMessage()
        {
            //this is a test change
            Assert.AreEqual("Hello World", Program.createMessage());
        }
    }
}
