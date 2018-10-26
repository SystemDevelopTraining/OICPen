﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OICPen.Models;
using System.Linq;
using System.Data.Entity;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataEntity = new List<Client>
            {
                new Client {Name = "髪無　禿蔵", Hurigana = "かみなし　はげぞう", Address = "大阪県大阪群大阪1234-5", PostNum = "12345678", PhoneNum = "08024856275"},
                new Client {Name = "禿丘　鶴雄", Hurigana = "はげおか　つるお", Address = "奈良県奈良市奈良1234-5", PostNum = "12345678", PhoneNum = "09012345678"}
            }.AsQueryable();

            var mockMyEntity = new Mock<DbSet<Client>>();

            mockMyEntity.As<IQueryable<Client>>().Setup(m => m.Provider).Returns(dataEntity.Provider);
            mockMyEntity.As<IQueryable<Client>>().Setup(m => m.Expression).Returns(dataEntity.Expression);
            mockMyEntity.As<IQueryable<Client>>().Setup(m => m.ElementType).Returns(dataEntity.ElementType);
            mockMyEntity.As<IQueryable<Client>>().Setup(m => m.GetEnumerator()).Returns(dataEntity.GetEnumerator());

            // DBContextにMockを設定
            var mockContext = new Mock<OICPenDbContext> ();
            mockContext.Setup(c => c.Clients).Returns(mockMyEntity.Object);

            var service = new ClientService(mockContext.Object);
            var clients = service.GetAllClients();

            Assert.AreEqual(2, clients.Count);
            Assert.AreEqual("かみなし　はげぞう", clients[0].Hurigana);
            Assert.AreEqual("はげおか　つるお", clients[1].Hurigana);

        }
    }
}
