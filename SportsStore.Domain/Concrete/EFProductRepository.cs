using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    //继承获取数据接口，后面再用依赖项注入器来注入来自动实例这个类
    public class EFProductRepository : IProductsRepository
    {
        private EFdbcontext context = new EFdbcontext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

    }
}
