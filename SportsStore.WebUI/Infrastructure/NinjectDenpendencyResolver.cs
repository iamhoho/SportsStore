using Moq;
using Ninject;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //数据绑定
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new List<Products>
            {
                new Products { Name="Surf board",Price=25},
                new Products { Name = "Football", Price = 25 },
                new Products { Name = "Pingpang", Price = 95 }
            });
            // Ninject会一直以同样的模仿对象来满足对IProductRepository接口的请求
            kernel.Bind<IProductsRepository>().ToConstant(mock.Object);
        }
    }
}
