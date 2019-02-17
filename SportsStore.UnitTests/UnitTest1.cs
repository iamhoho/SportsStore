
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.WebUI.Controllers;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;
using Moq;
using System.Linq;
using SportsStore.WebUI.Models;

namespace SportsStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId=1,Name="P1" },
                new Product {ProductId=2,Name="P2" },
                new Product {ProductId=3,Name="P3" },
                new Product {ProductId=4,Name="P4" },
                new Product {ProductId=5,Name="P5" }
            });
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            ProductsListViewModel redult = (ProductsListViewModel)controller.List(null,2).Model;


            Product[] prodArrary = redult.Products.ToArray();
            Assert.IsTrue(prodArrary.Length == 2);
            Assert.AreEqual(prodArrary[0].Name, "P4");
            Assert.AreEqual(prodArrary[1].Name, "P5");
        }
    }
}
