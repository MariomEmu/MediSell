﻿using AutoMapper;
using DAL.Models;

namespace BLL.DTOs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<ProductsOrder, ProductsOrderDto>();
            CreateMap<ProductsOrderDto, ProductsOrder>();
        }
    }
}