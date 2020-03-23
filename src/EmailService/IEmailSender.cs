using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task<ActionResult<bool>> SendEmailAsync(Message message);
    }
}
