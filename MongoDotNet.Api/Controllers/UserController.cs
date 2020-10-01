using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDotNet.Api.Models;
using MongoDotNet.Core.Models;
using MongoDotNet.Services;

namespace MongoDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly UserServices userServices;
        public UserController(UserServices userServices)
        {
            this.userServices = userServices;
        }

        [HttpGet]
        public ActionResult<List<IUser>> GetUsers() => this.userServices.Read();
        

        [HttpGet("{id}", Name=nameof(GetUser))]
        public ActionResult<IUser> GetUser(String id) 
        {
            IUser user = this.userServices.Read(id);
            return new ActionResult<IUser>(user);
        }

        [HttpPost]
        public ActionResult<IUser> AddBook([FromBody] AddUserRequest addUserRequest) 
        {
            IUser createdUser = this.userServices.Create(addUserRequest);
            
            createdUser.Password = addUserRequest.Password;
            return CreatedAtRoute(nameof(AuthenticateUser), new AuthenticateUserRequest(createdUser));
        }

        [HttpPost("auth", Name = nameof(AuthenticateUser))]
        public ActionResult<String> AuthenticateUser([FromBody] AuthenticateUserRequest authenticateUserRequest) 
        {
            return "authToken";
        }

    }
}
