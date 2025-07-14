using MicroECommerce.Catalog.Contracts.DTOs;
using MicroECommerce.Catalog.Contracts.Requests;

namespace MicroECommerce.Catalog.Application.Interfaces;

public interface IProductService
{
    Task<ProductDTO> CreateAsync(CreateProductRequest request);
}
