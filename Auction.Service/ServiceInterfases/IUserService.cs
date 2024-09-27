using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.DTO;
using Auction.DataAccess.Entity;

namespace Auction.Service.ServiceInterfases
{
    public interface IUserService
    {
        public User GetUser(int id);
        public Task AddUser(UserDTO userDTO);
    }
}
