using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OICPen.Models;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class GiveOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new List<GiveOrderT>
            {
                new GiveOrderT {GiveOrdDate = DateTime.Now, StaffTID = 1},
                new GiveOrderT {GiveOrdDate = DateTime.Now, StaffTID = 2}
            }.AsQueryable();



            var mockSet = new Mock<DbSet<GiveOrderT>>();
            mockSet.As<IQueryable<GiveOrderT>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<GiveOrderT>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<GiveOrderT>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<GiveOrderT>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OICPenDbContext>();
            mockContext.Setup(c => c.GiveOrders).Returns(mockSet.Object);

            var service = new OICPen.Services.GiveOrderService(mockContext.Object);
            var giveOrders = service.GetGiveOrders();
        }
    }
}
