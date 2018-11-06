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

            var data = new List<TakeOrder>
            {
                new TakeOrder {TakeOrdDate = DateTime.Now, ClientId = 1},
                new TakeOrder {TakeOrdDate = DateTime.Now, ClientId = 2}
            }.AsQueryable();



            var mockSet = new Mock<DbSet<TakeOrder>>();
            mockSet.As<IQueryable<TakeOrder>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<TakeOrder>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<TakeOrder>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<TakeOrder>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OICPenDbContext>();
            mockContext.Setup(c => c.TakeOrders).Returns(mockSet.Object);

            var service = new OICPen.Services.TakeOrderService(mockContext.Object);
            var takeOrders = service.GetAllTakeOrders();

            Assert.AreEqual(2, takeOrders.Count);
            Assert.AreEqual(0, takeOrders[0].Id);
            Assert.AreEqual(1, takeOrders[0].ClientId);
            Assert.AreEqual(null, takeOrders[0].ShipDate);

            service.AddTakeOrder(new TakeOrder { ClientId = 1, TakeOrdDate = DateTime.Now });
            mockSet.Verify(m => m.Add(It.IsAny<TakeOrder>()), Times.Exactly(1));
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(1));

        }
    }
}
