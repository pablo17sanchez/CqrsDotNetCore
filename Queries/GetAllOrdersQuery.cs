using CqrsSample.Response;
using MediatR;
using System.Collections.Generic;

namespace CqrsSample.Queries
{
    public class GetAllOrdersQuery : IRequest<List<OrderResponse>>
    {
    }
}
