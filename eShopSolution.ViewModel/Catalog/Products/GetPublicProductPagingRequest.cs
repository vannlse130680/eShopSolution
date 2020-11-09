using eShopSolution.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
