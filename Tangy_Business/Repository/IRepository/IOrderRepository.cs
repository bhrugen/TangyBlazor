using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_DataAccess;
using Tangy_Models;

namespace Tangy_Business.Repository.IRepository
{
    public interface IOrderRepository
    {
        public Task<OrderDTO> Get(int id);
        public Task<IEnumerable<OrderDTO>> GetAll(string? userId = null, string? status = null);
        public Task<OrderDTO> Create(OrderDTO objDTO);
        public Task<int> Delete(int id);

        public Task<OrderHeaderDTO> UpdateHeader(OrderHeaderDTO objDTO);

        public Task<OrderHeaderDTO> MarkPaymentSuccessful(int id);
        public Task<bool> UpdateOrderStatus(int orderId, string status);

        public Task<OrderHeaderDTO> CancelOrder(int id);
    }
}
