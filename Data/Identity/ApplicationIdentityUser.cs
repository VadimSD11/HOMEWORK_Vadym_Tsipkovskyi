using Microsoft.AspNetCore.Identity;
namespace WebApplication5.Data.Identity
{
    public class ApplicationIdentityUser:IdentityUser
    {
        public long ApplicationId { get; set; }
        public string Name { get; set; }
    }
}
