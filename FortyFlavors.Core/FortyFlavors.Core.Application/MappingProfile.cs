using System;
using AutoMapper;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.DTOs.CreateDto;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.DTOs.UpdateDto;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
       
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();
     
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryDto, Category>();
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<CategoryUpdateDto, Category>();


        CreateMap<Order, OrderDto>();
        CreateMap<OrderDto, Order>();
        CreateMap<OrderCreateDto, Order>();
       
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
        CreateMap<UserCreateDto, User>();
        CreateMap<UserUpdateDto, User>();


        CreateMap<UserRegisterDto, User>()
            .ForMember(dest => dest.Password, opt => opt.Ignore()); // Şifreyi manuel hash edeceğiz
    }
}