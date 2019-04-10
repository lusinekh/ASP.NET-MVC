using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools1.Models
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize { get; set; }

        public DefaultDiscountHelper(decimal discountParam)
        {
            DiscountSize = discountParam;
        }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize / 100m * totalParam));
        }
    }
}
