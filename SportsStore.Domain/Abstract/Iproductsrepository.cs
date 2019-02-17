using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Abstract
{
    public interface IProductsRepository
    {//创建一个可以返回Product数据的接口
        IEnumerable<Product> Products { get;  }
    }
}
