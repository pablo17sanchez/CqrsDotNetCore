using CqrsSample.Response;
using MediatR;
using System;

namespace CqrsSample.Commands
{
    public class CreateCustomerOrderCommand : IRequest<OrderResponse>
    {

        public Guid CustomerId { get; set; }

        public Guid ProductId { get; set; } 
    }
}
