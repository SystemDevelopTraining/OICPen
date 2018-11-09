using System;
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
            var dataEntity = new List<ClientT>
            {
                new ClientT {ClientTID=1, Name = "髪無　禿蔵", Hurigana = "かみなし　はげぞう", Address = "大阪県大阪群大阪1234-5", PostNum = "12345678", PhoneNum = "08024856275"},
                new ClientT {ClientTID=2,Name = "禿丘　鶴雄", Hurigana = "はげおか　つるお", Address = "奈良県奈良市奈良1234-5", PostNum = "12345678", PhoneNum = "09012345678"}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<ClientT>>();

            mockSet.As<IQueryable<ClientT>>().Setup(m => m.Provider).Returns(dataEntity.Provider);
            mockSet.As<IQueryable<ClientT>>().Setup(m => m.Expression).Returns(dataEntity.Expression);
            mockSet.As<IQueryable<ClientT>>().Setup(m => m.ElementType).Returns(dataEntity.ElementType);
            mockSet.As<IQueryable<ClientT>>().Setup(m => m.GetEnumerator()).Returns(dataEntity.GetEnumerator());

            // DBContextにMockを設定
            var mockContext = new Mock<OICPenDbContext> ();
            mockContext.Setup(c => c.Clients).Returns(mockSet.Object);

            var service = new OICPen.Services.ClientService(mockContext.Object);
            var clients = service.GetClients();

            Assert.AreEqual(2, clients.Count);
            Assert.AreEqual("かみなし　はげぞう", clients[0].Hurigana);
            Assert.AreEqual("はげおか　つるお", clients[1].Hurigana);

            var addC = new ClientT{Name = "田中 かなた", Hurigana = "たなか　かなた", Address = "奈良県桜井市芝1343-5", PostNum = "22222222", PhoneNum = "0722221221" };

            service.AddClient(addC);
            mockSet.Verify(m => m.Add(It.Is<ClientT>(x => addC.Name == x.Name)), Times.Exactly(1));
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(1));

            var findClient=service.FindByID(1);
            Assert.AreEqual(findClient.Name, "髪無　禿蔵");
            var findClients = service.FindByName("禿丘");
            Assert.AreEqual(findClients[0].Name, "禿丘　鶴雄");
            findClients = service.FindByHurigana("つるお");
            Assert.AreEqual(findClients[0].Name, "禿丘　鶴雄");
        }
    }
}
