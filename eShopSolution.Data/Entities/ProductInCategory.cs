using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    // thiết lập quan hệ nhiều nhiều
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}
