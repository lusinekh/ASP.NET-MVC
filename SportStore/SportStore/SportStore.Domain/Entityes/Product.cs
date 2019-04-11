using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SportStore.Domain.Entityes
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return ProductID + "\t" + Name + "\t" + Discription + "\t" + Category + "\t" + Price;
        }
    }
}
