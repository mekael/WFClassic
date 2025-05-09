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
}