using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jeans.User.CoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jeans.User.CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserModel userModel = new UserModel();

        [HttpGet]
        public IActionResult Get()
        {
            IList<UserModel> results = userModel.GetList();

            return Ok(results);
        }

        //[Route("getAll")]
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok("");
        //}

        //public IActionResult Post()
        //{
        //    return Ok("");
        //}

        //public IActionResult Put()
        //{
        //    return Ok();
        //}

        //public IActionResult Delete(int id)
        //{
        //    return Ok();
        //}
    }
}
