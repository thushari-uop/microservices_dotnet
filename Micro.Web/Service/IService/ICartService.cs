﻿using Micro.Web.Models;

namespace Micro.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsnyc(string userId);

        Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);

        Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId);

        Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);

        Task<ResponseDto?> EmailCart(CartDto cartDto);
    }
}
