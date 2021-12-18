using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models
{
    public class OrderDTO
    {
        public OrderHeaderDTO OrderHeader { get; set; }
        public List<OrderDetailDTO> OrderDetails { get; set; }
    }
}
