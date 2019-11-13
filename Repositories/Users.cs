using System.Collections.Generic;
using System.Linq;
using dotnet_jwt_auth.Models;

namespace dotnet_jwt_auth.Repositories
{
    public static class Users
    {
        public static User FindUser(string name, string pwd)
        {

            var users_ = new List<User>();
            users_.Add(new User { Nome = "hian", Password = "123", Perfis = "admin,teste" });
            users_.Add(new User { Nome = "maria", Password = "456", Perfis = "admin,teste" });
            users_.Add(new User { Nome = "joao", Password = "789", Perfis = "admin,teste" });
            return users_.Where(x => x.Nome == name && x.Password == pwd).FirstOrDefault();
        }

    }
}