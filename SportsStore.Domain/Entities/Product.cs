using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class Products
    {
        //在一个独立的vs项目中定义域模型
        public int ProductId { get; set; }
        public string Name { set; get; }
        public string Description { get; set; }
        public decimal Price { set; get; }
        public string Category { get; set; }
    }
}
