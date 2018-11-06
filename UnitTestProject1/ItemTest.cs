using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OICPen.Models;
using System.Linq;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new List<Item>
            {
                new Item {Name = "鉛筆", Hurigana = "えんぴつ" , JAN = "1234567890123", PurchasePrice = 50, Price = 100, SafetyStock = 30, RegistDate = DateTime.Now,  Note = "", IsDeleted = false},
                new Item {Name = "シャープペンシル", Hurigana = "しゃーぷぺんしる" , JAN = "0123456789012", PurchasePrice = 100, Price = 120, SafetyStock = 40, RegistDate = DateTime.Now,  Note = "", IsDeleted = false}
            }.AsQueryable();



            var mockSet = new Mock<DbSet<Item>>();
            mockSet.As<IQueryable<Item>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Item>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Item>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Item>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OICPenDbContext>();
            mockContext.Setup(c => c.Items).Returns(mockSet.Object);

            var service = new OICPen.Services.ItemService(mockContext.Object);
            var items = service.GetItems();

            Assert.AreEqual("鉛筆", items[0].Name);
            Assert.AreEqual(2, items.Count);
            Assert.AreEqual("しゃーぷぺんしる", items[1].Hurigana);

            var i = new Item { Name = "消しゴム", Hurigana = "けしごむ", JAN = "9012345678901", PurchasePrice = 30, Price = 80, SafetyStock = 30, RegistDate = DateTime.Now, Note = "よく消える", IsDeleted = false };

            service.AddItem(i);

            mockSet.Verify(m => m.Add(It.Is<Item>(x => i.Name == x.Name)), Times.Exactly(1));
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(1));

        }
    }
}
