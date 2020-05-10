using CqrsSample.Response;
using MediatR;
using System;

namespace CqrsSample.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerResponse>
    {
        public Guid CustomerId { get; }
        public GetCustomerByIdQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

    }
}
