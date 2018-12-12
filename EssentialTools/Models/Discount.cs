﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public class Discount {

    }

    public interface IDiscoutHelper {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscoutHelper {
        private decimal discountSize;

        public DefaultDiscountHelper(decimal discountParam) {
            discountSize = discountParam;
        }
        public decimal ApplyDiscount(decimal totalParam) {
            return (totalParam - (discountSize / 100m * totalParam));
        }
    }
}