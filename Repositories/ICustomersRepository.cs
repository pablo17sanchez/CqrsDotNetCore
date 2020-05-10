using CqrsSample.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CqrsSample.Repositories
{
    public  interface ICustomersRepository
    {
        Task<CustomerDto> GetCustomerAsync(Guid customerId);

        Task<List<CustomerDto>> GetCustomersAsync();
    }
}
