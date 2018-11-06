﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OICPen.Models;
using System.Collections.Generic;
using System.Data.Entity;
using Moq;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class TakeOrderDetailTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new List<TakeOrderDetailT>
            {
                new TakeOrderDetailT { ItemId = 2, Quantity = 1, TakeOrderId = 1},
                new TakeOrderDetailT {ItemId = 3, Quantity = 3, TakeOrderId = 1 }
            }.AsQueryable();



            var mockSet = new Mock<DbSet<TakeOrderDetailT>>();
            mockSet.As<IQueryable<TakeOrderDetailT>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<TakeOrderDetailT>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<TakeOrderDetailT>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<TakeOrderDetailT>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OICPenDbContext>();
            mockContext.Setup(c => c.TakeOrderDetails).Returns(mockSet.Object);

            var service = new OICPen.Services.TakeOrderDetailService(mockContext.Object);

            service.AddTakeOrderDetails(2, 3, new TakeOrderT { Id = 1, ClientId = 4, TakeOrdDate = DateTime.Now });


        }
    }
}
