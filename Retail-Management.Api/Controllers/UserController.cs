using Microsoft.AspNet.Identity;
using Retail_Management.Api.Library.DataAccess;
using Retail_Management.Api.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Retail_Management.Api.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string id = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            return data.GetUserById(id).FirstOrDefault();
        } 
    }
}
