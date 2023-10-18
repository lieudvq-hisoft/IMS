using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services.Utilities;
public class EmailHelper
{
    private readonly IConfiguration _config;
    private readonly string _env;

    public EmailHelper(IConfiguration config)
    {
        _config = config;
        _env = "Dev";
    }

    public SmtpClient GetClient()
    {
        return new SmtpClient(_config[$"Email:{_env}:Client"])
        {
            Port = 587,
            Credentials = new NetworkCredential(_config["Email:Local:Account"], _config[$"Email:{_env}:Key"]),
            EnableSsl = true,
        };
    }

    public MailMessage GetActivationMessage(string email)
    {
        var subject = "Activate your new account";
        return new MailMessage
        {
            From = new MailAddress(_config[$"Email:{_env}:Account"]),
            Subject = subject,
            Body = $"<h1>Click the following link to confirm your email address</h1> <a href='{_config[$"Email:{_env}:Link"] + email}'>Activation Link</a>",
            IsBodyHtml = true,
        };
    }
}
