using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services.Utilities;
public class EmailHelper
{
    private readonly IConfiguration _config;

    public EmailHelper(IConfiguration config)
    {
        _config = config;
    }

    public SmtpClient GetClient()
    {
        return new SmtpClient(_config["Email:Local:Client"])
        {
            Port = 587,
            Credentials = new NetworkCredential(_config["Email:Local:Account"], _config["Email:Local:Key"]),
            EnableSsl = true,
        };
    }

    public MailMessage GetMessage(string subject, string body)
    {
        return new MailMessage
        {
            From = new MailAddress(_config["Email:Local:Account"]),
            Subject = subject,
            Body = body,
            IsBodyHtml = true,
        };
    }
}
