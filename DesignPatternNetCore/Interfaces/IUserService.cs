using DesignPatternNetCore.Models;
using System.Collections.Generic;

namespace DesignPatternNetCore.Interfaces
{
    public interface IUserService
    {
        List<User> Get();
        void Add(User model);
    }
}
