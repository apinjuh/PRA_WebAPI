using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRA_WebAPI.DataBase;
using PRA_WebAPI.Entities;
using PRA_WebAPI.Models;

namespace PRA_WebAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private IRepository<Author> _repository;

        public UserController(IRepository<Author> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repository.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);


        }

        [HttpDelete("{Id}")]

        public async Task<IActionResult> DeleteUser(string id)
        {

            int iduser = int.Parse(id);
            var user = await _repository.Delete(iduser);
            if (user == null)
            {
                return NotFound();
            }
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> RegisterUser(Author request)
        {

            var checkEmail = (await _repository.Filter(x => x.Email == request.Email)).FirstOrDefault();
         

            if (checkEmail != null)
            {
                return BadRequest("User already exist");
            }

            var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            Author _user = new Author()
            {

                
                Email = request.Email,
                Password = passwordHash,
              

            };

            var user = await _repository.Add(_user);

            return Ok(user.ID);

        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginRequest request)
        {
            try
            {
                var userFromDatabase = (await _repository.Filter(x => x.Email == request.Email)).FirstOrDefault();
                if (userFromDatabase == null)
                {
                    return BadRequest("User doesnt exists ");
                }

                var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
                bool verified = false;
                verified = BCrypt.Net.BCrypt.Verify(request.Password, userFromDatabase.Password);

                if (verified)
                {
                    return Ok(userFromDatabase);
                }
                else
                {
                    return BadRequest("Wrong login data");
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
