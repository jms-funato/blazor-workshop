using System.Linq;
using System.Threading.Tasks;
using EmailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public MailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpGet]
        public async Task<ActionResult<bool>> Get()
        {
            var message = new Message(new string[] { "funato@jms-web.co.jp" }, "Test email async", "This is the content from our async email.", null);
            return await _emailSender.SendEmailAsync(message);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post()
        {
            var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();

            var message = new Message(new string[] { "funato@jms-web.co.jp" }, "Test mail with Attachments", "This is the content from our mail with attachments.", files);
            return await _emailSender.SendEmailAsync(message);
        }
    }
}