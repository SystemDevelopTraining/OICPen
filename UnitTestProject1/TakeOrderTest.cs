using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Collections.Generic;
using OICPen.Models;
using System.Linq;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class TakeOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var data = new List<TakeOrderT>
            {
                new TakeOrderT {TakeOrdDate = DateTime.Now, ClientTID = 1},
                new TakeOrderT {TakeOrdDate = DateTime.Now, ClientTID = 2}
            }.AsQueryable();



            var mockSet = new Mock<DbSet<TakeOrderT>>();
            mockSet.As<IQueryable<TakeOrderT>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<TakeOrderT>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<TakeOrderT>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<TakeOrderT>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OICPenDbContext>();
            mockContext.Setup(c => c.TakeOrders).Returns(mockSet.Object);

            var service = new OICPen.Services.TakeOrderService(mockContext.Object);
            var takeOrders = service.GetAllTakeOrders();

            Assert.AreEqual(2, takeOrders.Count);
            Assert.AreEqual(0, takeOrders[0].TakeOrderTID);
            Assert.AreEqual(1, takeOrders[0].ClientTID);
            Assert.AreEqual(null, takeOrders[0].ShipDate);

            service.AddTakeOrder(new TakeOrderT { ClientTID = 1, TakeOrdDate = DateTime.Now });
            mockSet.Verify(m => m.Add(It.IsAny<TakeOrderT>()), Times.Exactly(1));
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(1));

        }
    }
}
