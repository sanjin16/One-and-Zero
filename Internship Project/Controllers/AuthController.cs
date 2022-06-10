﻿using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database.Authentication;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Request;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password, request.FirstName, request.LastName
                );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);

        }
    }
}
