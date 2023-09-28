using Microsoft.AspNetCore.Identity;
using Proje.Domain.AppEntities.Identity;
using Proje.WebApi.Configurations;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .InstallServices(
    builder.Configuration, typeof(IServiceInstaller).Assembly);






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if(!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "ergint",
            Email = "ergint@example.com",
            Id = Guid.NewGuid().ToString(),
            Name="Ergin",
            Surname="T"
        },"Password12*").Wait();
    }
}


    app.Run();
