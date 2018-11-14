using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Infrastructure
{
    public interface IDiscountCalculator
    {
        decimal GetDiscount(decimal price, decimal percent);
    }
}
