using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace Services.Utilities;
public interface IEmailHelper
{
    SmtpClient GetClient();
    MailMessage GetActivationMessage(string password, string email);
}

public class EmailHelper : IEmailHelper
{
    private readonly IConfiguration _config;
    private readonly string _env;

    public EmailHelper(IConfiguration config)
    {
        _config = config;
        _env = SettingHelper.GetEnvironment();
    }

    public SmtpClient GetClient()
    {
        return new SmtpClient(_config[$"Email:{_env}:Client"])
        {
            Port = 587,
            Credentials = new NetworkCredential(_config[$"Email:{_env}:Account"], _config[$"Email:{_env}:Key"]),
            EnableSsl = true,
        };
    }

    public MailMessage GetActivationMessage(string password, string email)
    {
        var subject = "Account Information";
        return new MailMessage
        {
            From = new MailAddress(_config[$"Email:{_env}:Account"]),
            Subject = subject,
            Body =
            "<div>Dear Customer,</div><br><br>" +
            $"<div>Your account with the email <b>{email}</b> " +
            $"and the Password <b>[{password}]</b> was created successfully.<br>" +
            "Please consider changing the password after the first login.</div><br><br>" +
            "<div>Sincerely,<br>The QSTC team.</div>",
            IsBodyHtml = true,
        };
    }
}
