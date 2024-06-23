using Bll.Services.UserServ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.UserModels;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;

        public UserController(IUserServices userServices)
        {
            _userService = userServices;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_userService.GetAll());
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _userService.Create(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(User user,Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _userService.Update(user);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _userService.Delete(Id);
            return Ok();
        }
    }
}
