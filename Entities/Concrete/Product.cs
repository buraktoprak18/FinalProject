using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // bir classın defaul u internal 'dır
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnıtInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
