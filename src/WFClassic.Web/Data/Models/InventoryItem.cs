using System.Security.Policy;
using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class InventoryItem : EntityBase
    {
        public InternalInventoryItemType InternalInventoryItemType { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }    
        public int ItemCount { get; set; }

        public int UpgradeVer { get; set; }
        public int XP { get; set; }
        public int UnlockLevel { get; set; }
        public int ExtraCapacity { get; set; }
        public int ExtraRemaining { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Charge { get; set; }
        public DateTime ExpiryDate { get; set; }



    }
}

/*
  ItemType: string;
    ItemName?: string;
    Configs: IItemConfig[];
    UpgradeVer?: number;
    XP?: number;
    Features?: number;
    Polarized?: number;
    Polarity?: IPolarity[];
    FocusLens?: string;
    ModSlotPurchases?: number;
    CustomizationSlotPurchases?: number;
    UpgradeType?: string;
    UpgradeFingerprint?: string;
    InfestationDate?: IMongoDate;
    InfestationDays?: number;
    InfestationType?: string;
    ModularParts?: string[];
    UnlockLevel?: number;
    Expiry?: IMongoDate;
    SkillTree?: string;
    ArchonCrystalUpgrades?: IArchonCrystalUpgrade[];
    _id: Types.ObjectId;
 
 
 */



/*
 
const inventorySchema = new Schema<IInventoryDatabase, InventoryDocumentProps>(
    {
        accountOwnerId: Schema.Types.ObjectId,
        SubscribedToEmails: Number,
        Created: Date,
        RewardSeed: Number,

        //Credit
        RegularCredits: Number,
        //Platinum
        PremiumCredits: Number,


        //Slots
        SuitBin: slotsBinSchema,
        WeaponBin: slotsBinSchema,
        SentinelBin: slotsBinSchema,

       

        //Achievement
        ChallengeProgress: [challengeProgressSchema],

        //Account Item like Ferrite,Form,Kuva etc
        MiscItems: [typeCountSchema],

        //Upgrade Mods\Riven\Arcane Example:"UpgradeFingerprint"+"ItemType"+""
        Upgrades: [upgradesSchema],

        //Warframe
        Suits: [EquipmentSchema],
        //Primary    Weapon
        LongGuns: [EquipmentSchema],
        //Secondary  Weapon
        Pistols: [EquipmentSchema],
        //Melee      Weapon
        Melee: [EquipmentSchema],




        //Sentinel(like Helios or modular)
        Sentinels: [EquipmentSchema],

        //Any /Sentinels/SentinelWeapons/ (like warframe weapon)
        SentinelWeapons: [Schema.Types.Mixed],

        //Item for EquippedGear example:Scaner,LoadoutTechSummon etc
        Consumables: [typeCountSchema],


        ReceivedStartingGear: Boolean,

        //Complete Mission
        Missions: [Schema.Types.Mixed],

        //Cosmetics like profile glyphs\Kavasa Prime Kubrow Collar\Game Theme etc
        FlavourItems: [FlavourItemSchema],

        //Mastery Rank*(Need item XPInfo to rank up)
        PlayerLevel: Number,
        //Item Mastery Rank exp
        XPInfo: [TypeXPItemSchema],
        //Mastery Rank next availability
        TrainingDate: Date,

        //Blueprints for Foundry
        Recipes: [typeCountSchema],
        //Crafting Blueprint(Item Name + CompletionDate)
        PendingRecipes: [pendingRecipeSchema],

        TauntHistory: { type: [tauntSchema], default: undefined },

        //Skins for Suits, Weapons etc.
        WeaponSkins: [weaponSkinsSchema],

        //noShow2FA,VisitPrimeVault etc
        WebFlags: Schema.Types.Mixed,
        //Id CompletedAlerts
        CompletedAlerts: [String],

        //Resource,Credit,Affinity etc or Bless any boosters
        Boosters: [boosterSchema],

        //New Quest Email
        EmailItems: [TypeXPItemSchema],

        //Active profile ico
        ActiveAvatarImageType: String,

        //You first Dialog with NPC or use new Item
        NodeIntrosCompleted: [String],

        //Current guild id, if applicable.
        GuildId: { type: Schema.Types.ObjectId, ref: "Guild" },

        //TradingRulesConfirmed,ShowFriendInvNotifications(Option->Social)
        Settings: settingsSchema,

        //Modulars lvl and exp(Railjack|Duviri)
        //https://warframe.fandom.com/wiki/Intrinsics
        PlayerSkills: playerSkillsSchema,

        //TradeBannedUntil data
        TradeBannedUntil: Schema.Types.Mixed,

        //Unknown and system
        Mailbox: MailboxSchema,
        HandlerPoints: Number,
        ChallengesFixVersion: Number,
        PlayedParkourTutorial: Boolean,
        SubscribedToEmailsPersonalized: Number,
        LastInventorySync: Schema.Types.Mixed,
        Robotics: [Schema.Types.Mixed],
        HasResetAccount: Boolean,

        //Discount Coupon
        PendingCoupon: Schema.Types.Mixed,
        //Like BossAladV,BossCaptainVor come for you on missions % chance
        DeathMarks: [String],
        //Zanuka
        Harvestable: Boolean,
        //Grustag three
        DeathSquadable: Boolean
    },
    { timestamps: { createdAt: "Created" } }
);
 
 */