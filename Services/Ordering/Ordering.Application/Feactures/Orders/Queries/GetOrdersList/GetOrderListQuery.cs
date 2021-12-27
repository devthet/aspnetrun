using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Feactures.Orders.Queries.GetOrdersList
{
    public class GetOrderListQuery
    {
        public string UserName { get; set; }
      
        public GetOrderListQuery(string userName)
        {
            UserName = userName;
        }
    }
}
