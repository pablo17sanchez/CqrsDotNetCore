using CqrsSample.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsSample.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {

        public Guid OrderId { get; }

        public GetOrderByIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }


    }
}
