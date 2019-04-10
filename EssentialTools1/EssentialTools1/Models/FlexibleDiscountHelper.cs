using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools1.Models
{
    public class FlexibleDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            decimal discount = totalParam > 100 ? 70 : 20;
            return (totalParam - (discount / 100m * totalParam));
        }
    }
}