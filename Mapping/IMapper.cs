using CqrsSample.Dtos;
using CqrsSample.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsSample.Mapping
{
    public interface IMapper
    {

        List<CustomerResponse> MapCustomerDtosToCustomerResponses(List<CustomerDto> dtos);

        CustomerResponse MapCustomerDtoToCustomerResponse(CustomerDto customerDto);

        List<OrderResponse> MapOrderDtosToOrderResponses(List<OrderDto> customerOrders);

        OrderResponse MapOrderDtoToOrderResponse(OrderDto order);
    }
}
