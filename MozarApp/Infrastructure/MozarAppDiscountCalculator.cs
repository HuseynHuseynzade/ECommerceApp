using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Infrastructure
{
    public class MozarAppDiscountCalculator : IDiscountCalculator
    {
        public decimal GetDiscount(decimal price, decimal percent)
        {
          decimal result=  price - ((price * percent) / 100);
          return  Math.Round(result, 2);
        }
    }
}
