using Auction.Service.ServiceInterfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Repostitory.Repositories;
using Auction.Repostitory.RepositoryInterface;
using Auction.DTO;
using Auction.DataAccess.Entity;

namespace Auction.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(int id)
        {
            var user = _userRepository.GetUser(id);
            return user;
        }
        public async Task AddUser(UserDTO userDTO)
        {
           await _userRepository.AddUserAsync(userDTO);
        }
    }
}
