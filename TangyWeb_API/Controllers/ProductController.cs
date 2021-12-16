using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tangy_Business.Repository.IRepository;

namespace TangyWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
