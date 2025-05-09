using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Admin.CheckOnline;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Exp.Artifact;
using WFClassic.Web.Logic.Exp.Training;
using WFClassic.Web.Logic.Friendship.Add;
using WFClassic.Web.Logic.Friendship.AddPending;
using WFClassic.Web.Logic.Friendship.Get;
using WFClassic.Web.Logic.Friendship.Remove;
using WFClassic.Web.Logic.Inventory.Attach;
using WFClassic.Web.Logic.Inventory.Get;
using WFClassic.Web.Logic.Inventory.Starting;
using WFClassic.Web.Logic.Inventory.Update;
using WFClassic.Web.Logic.Stats.Upload;
using WFClassic.Web.Logic.Taunt;
using WFClassic.Web.Logic.WFAuth.Initialize;
using WFClassic.Web.Logic.WFAuth.WFLogin;
using WFClassic.Web.Logic.WFAuth.WFLogout;
 
 
 



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    
});
builder.Services.AddRequestDecompression();

builder.Services.AddTransient<WarframeLoginHandler>();
builder.Services.AddTransient<WarframeLogoutHandler>();
builder.Services.AddTransient<GiveStartingGearHandler>();
builder.Services.AddTransient<IsUserOnlineQueryHandler>();
builder.Services.AddTransient<GetCreditsHandler>();
builder.Services.AddTransient<CreatePlayerHandler>();
builder.Services.AddTransient<AddLevelBasedOnTrainingHandler>();
builder.Services.AddTransient<GetInventoryHandler>();
builder.Services.AddTransient<UploadStatsHandler>();
builder.Services.AddTransient<UpdateInventoryHandler>();
builder.Services.AddTransient<AddAccountTransactionHandler>();
builder.Services.AddTransient<AttachModsHandler>();
builder.Services.AddTransient<AddTauntHandler>();
builder.Services.AddTransient<UpgradeArtifactHandler>();
builder.Services.AddTransient<AddPendingFriendHandler>();
builder.Services.AddTransient<AcceptFriendRequestHandler>();
builder.Services.AddTransient<GetFriendsRequestHandler>();
builder.Services.AddTransient<RemoveFriendRequestHandler>();




builder.Services.AddControllersWithViews();

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

app.UseAuthorization();
app.UseRequestDecompression();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
