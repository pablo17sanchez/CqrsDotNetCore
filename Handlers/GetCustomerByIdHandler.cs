using CqrsSample.Mapping;
using CqrsSample.Queries;
using CqrsSample.Repositories;
using CqrsSample.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsSample.Handlers
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, CustomerResponse>
    {

        private readonly IMapper _mapper;
        private readonly ICustomersRepository _customersRepository;

        public GetCustomerByIdHandler(IMapper mapper, ICustomersRepository customersRepository)
        {
            _mapper = mapper;
            _customersRepository = customersRepository;
        }

        public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customerDto = await _customersRepository.GetCustomerAsync(request.CustomerId);
            return customerDto == null ? null : _mapper.MapCustomerDtoToCustomerResponse(customerDto);
        }
    }
}
