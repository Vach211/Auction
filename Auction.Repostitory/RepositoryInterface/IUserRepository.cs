using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.DataAccess.Entity;
using Auction.DTO;

namespace Auction.Repostitory.RepositoryInterface
{
    public interface IUserRepository
    {
        public User GetUser(int id);
        public Task  AddUserAsync(UserDTO userDTO);
    }
}
