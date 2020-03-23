using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BlazingPizza.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AppVersionController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AppVersionController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet("appver")]
        //public async Task<ActionResult<string>> GetAppVersion()
        //{
        //    //var appver = "";
        //    //return await appver;
        //}
    }
}
