using Auction.DTO;
using Auction.Service.ServiceInterfases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionUsersRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUserById(int Id)
        {
            var user = _userService.GetUser(Id);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost]
        public IActionResult RegistrateUser(UserDTO userDTO)
        {
            _userService.AddUser(userDTO);
            return Ok(userDTO);
        }
    }
}
