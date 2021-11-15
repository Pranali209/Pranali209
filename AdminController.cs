using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BalProject;
using DalProject;
using ProjectWebApplication.Models;

namespace ProjectWebApplication.Controllers
{
    public class AdminController : ApiController
    {
     
       public string  Get()
        {
            return "value";
        }

        [HttpPost]
        public IHttpActionResult AdminLogin(BalLayer ba)
        {
            DalLayer ds = new DalLayer();
            bool ans = ds.Check(ba);
            if (ans == false)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid user", });

            }
            else
            {
                return Ok(new { status = 200, isSuccess = true, message = "Invalid user"});

            }

        }
    }
}
