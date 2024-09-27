using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Auction.DataAccess;
using Auction.DataAccess.Context;
using Auction.DataAccess.Entity;
using Auction.DTO;
using Auction.Repostitory.RepositoryInterface;

namespace Auction.Repostitory.Repositories
{
    public class UserRepository : IUserRepository
    {
        //  private readonly AuctionDbContext _AuctionDbContect;

        /*public  UserRepository(AuctionDbContext AuctionDbContect)
        {
            _AuctionDbContect = AuctionDbContect;
        }*/
        public static List<User> Users = new List<User>();

        public User GetUser(int id)
        {
            string usersJson = File.ReadAllText("users.json");
            Users = JsonSerializer.Deserialize<List<User>>(usersJson);

            var u = Users.FirstOrDefault(u => u.Id == id);
            if (u == null)
            {
                return null;
            }
            return u;
        }

        public async Task AddUserAsync(UserDTO userDTO)
        {
            List<User> us = new List<User>();

            if (Users.Count != 0)
            {
                Users.Clear();
                string usersJson = File.ReadAllText("users.json");
                Users = JsonSerializer.Deserialize<List<User>>(usersJson);

            }

            User user = new User()
            {
                Id = Users.Count + 1,
                Email = userDTO.Email,
                Username = userDTO.Username,
                Password = userDTO.Password,
            };

            Users.Add(user);

            string newUserJson = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("users.json", newUserJson);
        }
    }
}
