using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Admin.CheckOnline;
using WFClassic.Web.Logic.Bonus.Rewards;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Economics.Purchase;
using WFClassic.Web.Logic.Economics.Sell;
using WFClassic.Web.Logic.Exp.Artifact;
using WFClassic.Web.Logic.Exp.Training;
using WFClassic.Web.Logic.Foundry.Claim;
using WFClassic.Web.Logic.Foundry.Pending;
using WFClassic.Web.Logic.Foundry.Rush;
using WFClassic.Web.Logic.Foundry.Start;
using WFClassic.Web.Logic.Friendship.Add;
using WFClassic.Web.Logic.Friendship.AddPending;
using WFClassic.Web.Logic.Friendship.Get;
using WFClassic.Web.Logic.Friendship.Remove;
using WFClassic.Web.Logic.Inventory.Attach.Modifications;
using WFClassic.Web.Logic.Inventory.Attach.Orokin;
using WFClassic.Web.Logic.Inventory.Get;
using WFClassic.Web.Logic.Inventory.Starting;
using WFClassic.Web.Logic.Inventory.Update;
using WFClassic.Web.Logic.Stats.Leaderboard;
using WFClassic.Web.Logic.Stats.ProfileStats;
using WFClassic.Web.Logic.Stats.Upload;
using WFClassic.Web.Logic.Taunt;
using WFClassic.Web.Logic.Universe.GetState;
using WFClassic.Web.Logic.WFAuth.Initialize;
using WFClassic.Web.Logic.WFAuth.WFLogin;
using WFClassic.Web.Logic.WFAuth.WFLogout;
using WFClassic.Web.Logic.Sys.SystemLogout;
using WFClassic.Web.Logic.Sys.Scheduled;
using Coravel;
using WFClassic.Web.Logic.Bonus.Daily;
using WFClassic.Web.Logic.Friendship.Icon;
using WFClassic.Web.Logic.Economics.Revives;
using Serilog;
using WFClassic.Web.Logic.Economics.Slots;



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
builder.Services.AddTransient<GetLeaderboardStatsHandler>();
builder.Services.AddTransient<GetProfileStatsHandler>();
builder.Services.AddTransient<CheckPendingRecipesQueryHandler>();
builder.Services.AddTransient<StartRecipeBuildHandler>();
builder.Services.AddTransient<ClaimCompletedRecipeHandler>();
builder.Services.AddTransient<UpdateLoadoutHandler>();
builder.Services.AddTransient<GetLoginRewardsHandler>();
builder.Services.AddTransient<RushRecipeHandler>();
builder.Services.AddTransient<SellItemHandler>();
builder.Services.AddTransient<GetWorldStateHandler>();
builder.Services.AddTransient<PurchaseItemHandler>();
builder.Services.AddTransient<AttachOrokinModHandler>();
builder.Services.AddScoped<MassLogoutUsersHandler>();
builder.Services.AddScoped<ResetWarframeRevivesHandler>();
builder.Services.AddTransient<MassLogoutUsersHandler>();
builder.Services.AddTransient<ResetWarframeRevivesHandler>();
builder.Services.AddTransient<GetDailyMissionBonusHandler>();
builder.Services.AddTransient<SetAvatarIconRequestHandler>();
builder.Services.AddTransient<PurchaseRevivesHandler>();
builder.Services.AddTransient<PurchaseSlotsHandler>();



builder.Services.AddScheduler();
builder.Services.AddControllersWithViews();

var loggerConfig = new LoggerConfiguration();
loggerConfig.WriteTo.Console();

if (builder.Configuration.GetValue<bool>("LogToDisk"))
{
    loggerConfig.WriteTo.File("./logs/wfclassic.log", rollOnFileSizeLimit: true);
}

Log.Logger = loggerConfig.CreateLogger();

builder.Services.AddSerilog();

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

//logout all users during server restart. 


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var serviceScope = app.Services.CreateScope())
{
    // this will either create or migrate the db, depending on whether or not it exists. 
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    if (dbContext.Database.GetPendingMigrations().Any())
    {
        dbContext.Database.Migrate();
    }

    serviceScope.ServiceProvider.GetRequiredService<MassLogoutUsersHandler>().Handle();
    serviceScope.ServiceProvider.GetRequiredService<ResetWarframeRevivesHandler>().Handle(new ResetWarframeRevives() { ResetReason = "System Startup", ResetRegardless = false });
}

app.Services.UseScheduler(
    scheduler =>
    {
        scheduler.Schedule<MassLogoutUsersHandler>().DailyAtHour(0);
        scheduler.ScheduleWithParams<ResetWarframeRevivesHandler>(new ResetWarframeRevives() { ResetReason = "System Startup", ResetRegardless = false }).DailyAtHour(0);
    });



app.Run();
