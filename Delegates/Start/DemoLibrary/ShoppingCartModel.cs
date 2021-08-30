using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        
        public decimal GenerateTotal(MentionDiscount mentionDiscount, Func<List<ProductModel>,decimal,decimal> calculateDiscountTotal,Action<string> discountDetail)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionDiscount(subTotal);

            discountDetail("Applying discount");

            return calculateDiscountTotal(Items, subTotal);
            //if (subTotal > 100)
            //{
            //    return subTotal * 0.80M;
            //}
            //else if (subTotal > 50)
            //{
            //    return subTotal * 0.85M;
            //}
            //if (subTotal > 10)
            //{
            //    return subTotal * 0.90M;
            //}
            //else
            //{
            //    return subTotal * 1.0M;
            //}
        }
    }
}
