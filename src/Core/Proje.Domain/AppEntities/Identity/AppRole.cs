using Microsoft.AspNetCore.Identity;

namespace Proje.Domain.AppEntities.Identity
{
    public sealed class AppRole:IdentityRole<string>
    {

        public string Code { get; set; }
        public string Title { get; set; }

        public AppRole(string code, string title,string name)
        {
            Id=Guid.NewGuid().ToString();
            Code = code;
            Title = title;
            Name=name;
        }
        public AppRole()
        {
            
        }


    }
}
