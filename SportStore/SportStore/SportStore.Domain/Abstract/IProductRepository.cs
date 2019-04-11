using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Entityes;

namespace SportStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products{ get; }
    }
}
