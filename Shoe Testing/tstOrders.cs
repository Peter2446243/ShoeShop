﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace Shoe_Testing
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
    }
}