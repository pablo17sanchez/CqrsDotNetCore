﻿using CqrsSample.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsSample.Repositories
{
    public interface IOrdersRepository
    {

        Task<List<OrderDto>> GetOrdersAsync();
        Task<OrderDto> CreateOrderAsync(Guid customerId, Guid productId);
        Task<OrderDto> GetOrderAsync(Guid orderId);



    }
}
