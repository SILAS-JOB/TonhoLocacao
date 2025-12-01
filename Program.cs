using ChicasEventos.Models;
using TonhoLocacao.Models;
using TonhoLocacao.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));




// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
// .AddJwtBearer(jwtOptions =>
// {
//     var authority = builder.Configuration["Jwt:Authority"];
//     if (!string.IsNullOrEmpty(authority))
//     {
//         jwtOptions.Authority = authority;
//     }
// });

// var requireAuthPolicy = new AuthorizationPolicyBuilder()
//     .RequireAuthenticatedUser()
//     .Build();

// builder.Services.AddAuthorizationBuilder()
//     .SetFallbackPolicy(requireAuthPolicy);


builder.Services.AddMvc();

// builder.Services.AddSwaggerGen( options =>
// {
//    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Crud Api", Version = "v1"}); 
// });

builder.Services.AddDbContext<UserDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

var configuration = builder.Configuration;

// Console.WriteLine(configuration["ConnectionString:DefaultConnection"]);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
// app.MapSwagger();
// app.UseSwagger();
// app.UseSwaggerUI(options =>
// {
//     options.SwaggerEndpoint("v1/swagger.json", "Api V1");
// });

app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
