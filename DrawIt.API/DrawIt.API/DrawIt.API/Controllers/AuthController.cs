﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DrawIt.Models;
using DrawIt.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DrawIt.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private UserManager<ApplicationUser> userManger;

        public AuthController(UserManager<ApplicationUser> userManger)
        {
            this.userManger = userManger;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                var user = await userManger.FindByEmailAsync(model.Email);
                if (user != null && await userManger.CheckPasswordAsync(user, model.Password))
                {
                    var claims = new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySercureKeySuperrrrr"));

                    var token = new JwtSecurityToken(
                        issuer: "http://online-pictionary.com",
                        audience: "http://online-pictionary.com",
                        expires: DateTime.UtcNow.AddDays(14),
                        claims: claims,
                        signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                        );

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo,
                        username = user.UserName
                    });
                }
                return Unauthorized();
            }
            catch (Exception e)
            {
                throw e;
                //return BadRequest();
            }
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] LoginModel model)
        {
            try
            {
                var user = await userManger.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ApplicationUser userRegister = new ApplicationUser()
                    {
                        Email = model.Email,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        UserName = model.Username
                    };

                    await userManger.CreateAsync(userRegister, model.Password);

                    return Ok();
                }
                return Unauthorized();
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
    }
}