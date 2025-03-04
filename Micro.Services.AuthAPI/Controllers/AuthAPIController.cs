﻿using Micro.Services.AuthAPI.Models.Dto;
using Micro.Services.AuthAPI.Service.IService;
using Micro.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Micro.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {

        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        {
            var errorMassage = await _authService.Register(model);

            if(!string.IsNullOrEmpty(errorMassage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMassage;
                return BadRequest(_response);
            }

           // Console.WriteLine(_response);
            return Ok(_response);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {

           var loginResponse =await _authService.Login(model);
            if (loginResponse.User == null)
            {
                _response.IsSuccess=false;
                _response.Message = "UserName or Password is incorrect";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }



        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        {

            var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());
            if (!assignRoleSuccessful)
            {
                _response.IsSuccess = false;
                _response.Message = "Error Encountered";
                return BadRequest(_response);
            }
            
            return Ok(_response);
        }
    }
}
