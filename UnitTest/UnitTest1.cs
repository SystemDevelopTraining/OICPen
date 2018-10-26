using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using OICPen;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataEntity = new List<OICPen.Models.Client>
                {
                    new Client {Id = 1, Date = DateTime.Now },
                    new Client {Id = 2, Date = DateTime.Now }
                }.AsQueryable();

            // DbSetのMock
            var mockMyEntity = new Mock<DbSet<MyEntity>>();
            // DbSetとテスト用データを紐付け
            mockMyEntity.As<IQueryable<Type>>().Setup(m => m.Provider).Returns(dataEntity.Provider);
            mockMyEntity.As<IQueryable<Type>>().Setup(m => m.Expression).Returns(dataEntity.Expression);
            mockMyEntity.As<IQueryable<Type>>().Setup(m => m.ElementType).Returns(dataEntity.ElementType);
            mockMyEntity.As<IQueryable<Type>>().Setup(m => m.GetEnumerator()).Returns(dataEntity.GetEnumerator());

            // DBContextにMockを設定
            var mockContext = new Mock<< MyDbContext > ();
            mockContext.Setup(m => m.TestEntity).Returns(mockMyEntity.Object);
            mockMyEntity.SetUp(f => f.Create()).Returns(new MyEntity());

            // DBContextのMockをコンストラクタなどからテスト対象クラスに受け渡す
            var target = new Target(mockContext);
        }
    }
}
