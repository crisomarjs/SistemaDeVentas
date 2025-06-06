using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit.Text;
using Microsoft.Extensions.Configuration;
using SVServices.Interfaces;
using MimeKit;

namespace SVServices.Implementation
{
    public class CorreoService : ICorreoService
    {
        private readonly IConfiguration _configuration;
        private SmtpClient _smtp;
        private readonly string _host;
        private readonly int _port;
        private readonly string _user;   
        private readonly string _pass;

        public CorreoService(IConfiguration configuration)
        {
            _configuration = configuration;
            _smtp = new SmtpClient();
            _host = configuration["Smtp:host"];
            _port = Convert.ToInt32(configuration["Smtp:port"]);
            _user = configuration["Smtp:user"];
            _pass = configuration["Smtp:pass"];
        }

        public async Task Enviar(string para, string asunto, string mensajeHtml)
        {
            _smtp = new SmtpClient();
            _smtp.Connect(_host, _port, SecureSocketOptions.StartTls);
            _smtp.Authenticate(_user, _pass);

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_user));
            email.To.Add(MailboxAddress.Parse(para));
            email.Subject = asunto;
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = mensajeHtml
            };
            await _smtp.SendAsync(email);
            await _smtp.DisconnectAsync(true);
        }
    }
}
