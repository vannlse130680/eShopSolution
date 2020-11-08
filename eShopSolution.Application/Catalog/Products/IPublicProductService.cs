using eShopSolution.Application.Catalog.Products.DTOs;
using eShopSolution.Application.Catalog.Products.DTOs.Manage;
using eShopSolution.Application.Catalog.Products.DTOs.Public;
using eShopSolution.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GetProductPagingRequest = eShopSolution.Application.Catalog.Products.DTOs.Public.GetProductPagingRequest;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>>  GetAllByCategoryId(GetProductPagingRequest request);

    }
}
