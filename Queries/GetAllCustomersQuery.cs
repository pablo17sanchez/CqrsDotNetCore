using CqrsSample.Response;
using MediatR;
using System.Collections.Generic;

namespace CqrsSample.Queries
{
    public class GetAllCustomersQuery : IRequest<List<CustomerResponse>>
    {
    }
}
