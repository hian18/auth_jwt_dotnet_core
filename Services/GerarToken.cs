using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using dotnet_jwt_auth.Models;
using Microsoft.IdentityModel.Tokens;

namespace dotnet_jwt_auth.Services
{

    public static class TokenService
    {
        public static string GerarToken(User user)
        {

            var tokenHandle = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{

                new Claim(ClaimTypes.Name,user.Nome),
                new Claim(ClaimTypes.Name,user.Nome)
                }
                ),
                Expires=DateTime.UtcNow.AddHours(2),
                SigningCredentials=new SigningCredentials{}
            };


        }
    }

}