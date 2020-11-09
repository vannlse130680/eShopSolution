using eShopSolution.Application.DTOs;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModel.Catalog.Products;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

       Task<List<ProductViewModel>> GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task AddViewCount(int productId);

        Task<int> UpdateStock(int productId, int addedQuantity);

        Task<int> AddImage(int productId, List<IFormFile> files);


        Task<int> RemoveImage(int imgaeId);

        Task<int> UpdaeImage(int imageId, string caption, bool isDefault);

        //Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
