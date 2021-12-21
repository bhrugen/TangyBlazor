using Tangy_Models;
using TangyWeb_Client.ViewModels;

namespace TangyWeb_Client.Serivce.IService
{
    public interface IPaymentService
    {
        public Task<SuccessModelDTO> Checkout(StripePaymentDTO model);

    }
}
