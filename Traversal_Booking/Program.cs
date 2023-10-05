using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Traversal_Booking.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
// Hizmetleri yapýlandýrma
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>
    ().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();
builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();
builder.Services.AddScoped<IAppUserService, AppUserManager>();
builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();
// Kimlik hizmetlerini veritabaný baðlamýyla iliþkilendirme
builder.Services.AddControllersWithViews();
builder.Services.AddMvc
(opt =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        "areas",
        "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        "areas",
        "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.Run();