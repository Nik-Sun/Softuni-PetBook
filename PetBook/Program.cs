
using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using PetBook.Core.Repositories;
using PetBook.Core.Services;
using PetBook.Hubs;
using PetBook.Infrastructure.Data;
using PetBook.Infrastructure.Data.Models;


var builder = WebApplication.CreateBuilder(args);

Account account = new Account(
  builder.Configuration.GetSection("Cloudinary:CloudName").Value,
  builder.Configuration.GetSection("Cloudinary:ApiKey").Value,
  builder.Configuration.GetSection("Cloudinary:ApiSecret").Value
 );

Cloudinary cloudinary = new Cloudinary(account);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PetBookDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(options => 
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireNonAlphanumeric = false;
    
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<PetBookDbContext>();

builder.Services.AddSingleton(typeof(Cloudinary),cloudinary);
builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IRepository, PetBookRepository>();
builder.Services.AddScoped<IPetService, PetService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<ICityService, CityService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.MapHub<ChatHub>("/Message/Chats");

app.Run();
