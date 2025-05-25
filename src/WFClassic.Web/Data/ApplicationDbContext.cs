using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<LoginTrackingItem> LoginTrackingItems { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<BankAccountTransaction> BankAccountsTransaction { get; set; }

    public DbSet<InventoryBin> InventoryBins { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<InventoryItemAttachment> InventoryItemAttachments { get; set; }
    public DbSet<Mission> Missions { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<TauntHistoryItem> TauntHistoryItems { get; set; }
    public DbSet<MetricItem> MetricItems { get; set; }

    public DbSet<FriendshipRequest> FriendshipRequests { get; set; }

    public DbSet<PersonRelationship> PersonRelationships { get; set; }

    public DbSet<PendingRecipe> PendingRecipes { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeItem> RecipeItems { get; set; }
    public DbSet<MissionReport> MissionReports { get; set; }
    public DbSet<PlayerReport> PlayerReports { get; set; }
    public DbSet<DailyRewardDefinition> DailyRewardDefinitions { get; set; }

    public DbSet<AlertConfiguration> AlertConfigurations { get; set; }
    public DbSet<AlertEnemyConfiguration> AlertEnemyConfigurations { get; set; }
    public DbSet<AlertRewardConfiguration> AlertRewardConfigurations { get; set; }
    public DbSet<WorldStateEventMessage> WorldStateEventMessages { get; set; }


    public DbSet<MarketPackageDefinition> MarketPackageDefinitions { get; set; }
    public DbSet<MarketPackageItemDefinition> MarketPackageItemDefintions { get; set; }

    public DbSet<SystemTaskHistory> SystemTaskHistory { get; set; }

}