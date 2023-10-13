﻿using TaskApi.Models;
using TaskApi.Models.DTO;

namespace TaskApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> RegisterAsync(RegisterDTO model);
        bool Login(LoginDTO model);
        public Task<User?> FindUserByEmailAsync(string email);
    }
}
