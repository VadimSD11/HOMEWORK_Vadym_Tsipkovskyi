using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebApplication5.Services.Email
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //TODO Create Email service
            await Task.CompletedTask;
        }
    }
}
