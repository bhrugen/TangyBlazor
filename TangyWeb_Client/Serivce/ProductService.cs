using Tangy_Models;
using TangyWeb_Client.Serivce.IService;

namespace TangyWeb_Client.Serivce
{
    public class ProductService : IProductService
    {
        public Task<ProductDTO> Get(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
