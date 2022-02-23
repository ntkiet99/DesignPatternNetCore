using DesignPatternNetCore.Data;
using DesignPatternNetCore.Interfaces;
using DesignPatternNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternNetCore.Services
{
    public class UserService : IUserService
    {
        public DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public void Add(User model)
        {
            var entity = new User();
            entity.Username = model.Username;
            entity.Password = model.Password;
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public List<User> Get()
        {
            return _context.Users.ToList();    
        }

        public void Ngoc()
        {
            
        }
    }
}
