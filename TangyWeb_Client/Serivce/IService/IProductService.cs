using Tangy_Models;

namespace TangyWeb_Client.Serivce.IService
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetAll();
        public Task<ProductDTO> Get(int productId);
    }
}
