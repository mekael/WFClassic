
# Upload

Stats per mission are uploaded to this endpoint. Used for leaderboard stuff. 


## POST

/stats/upload.php?accountId=67fca41ccd48d7d4f5537013&nonce=2199449583075114


### Example body
``` json
{
  displayName: 'sdfasd',
  counters: [
    { event: 'MISSION_COMPLETE', counter: 1, object: 'GS_SUCCESS' },
    { event: 'PLAYER_COUNT', counter: 1, object: '1P Public' },
    {
      event: 'PICKUP_ITEM',
      counter: 2,
      object: '/Lotus/Types/PickUps/EnergyIncreaseSmallItem'
    },
    {
      event: 'PICKUP_ITEM',
      counter: 1,
      object: '/Lotus/Types/PickUps/Credits/10Credits'
    },
    {
      event: 'FIRE_WEAPON',
      counter: 23,
      object: '/Lotus/Weapons/Tenno/Bows/HuntingBow'
    },
    {
      event: 'HIT_ENTITY',
      counter: 3,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/BladeSawmanAvatar'
    },
    {
      event: 'HIT_ENTITY',
      counter: 2,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/FemaleGrineerAvatar'
    },
    {
      event: 'HIT_ENTITY',
      counter: 7,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/RifleLancerAvatar'
    },
    {
      event: 'HIT_ENTITY',
      counter: 3,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/ShotgunLancerAvatar'
    },
    {
      event: 'HIT_ENTITY_ITEM',
      counter: 15,
      object: '/Lotus/Weapons/Tenno/Bows/HuntingBow'
    },
    {
      event: 'KILL_ENEMY',
      counter: 3,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/BladeSawmanAvatar'
    },
    {
      event: 'KILL_ENEMY',
      counter: 1,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/FemaleGrineerAvatar'
    },
    {
      event: 'KILL_ENEMY',
      counter: 6,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/RifleLancerAvatar'
    },
    {
      event: 'KILL_ENEMY',
      counter: 3,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/ShotgunLancerAvatar'
    },
    {
      event: 'KILL_ENEMY_ITEM',
      counter: 12,
      object: '/Lotus/Weapons/Tenno/Bows/Arrow'
    },
    {
      event: 'KILL_ENEMY_ITEM',
      counter: 1,
      object: '/Lotus/Weapons/Tenno/Bows/WeakArrow'
    },
    {
      event: 'DEAL_DAMAGE',
      counter: 90,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/BladeSawmanAvatar'
    },
    {
      event: 'DEAL_DAMAGE',
      counter: 60,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/FemaleGrineerAvatar'
    },
    {
      event: 'DEAL_DAMAGE',
      counter: 406,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/RifleLancerAvatar'
    },
    {
      event: 'DEAL_DAMAGE',
      counter: 180,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/ShotgunLancerAvatar'
    },
    {
      event: 'DEAL_DAMAGE_ITEM',
      counter: 586,
      object: '/Lotus/Weapons/Tenno/Bows/Arrow'
    },
    {
      event: 'DEAL_DAMAGE_ITEM',
      counter: 150,
      object: '/Lotus/Weapons/Tenno/Bows/WeakArrow'
    },
    {
      event: 'TAKE_DAMAGE',
      counter: 135,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/FemaleGrineerAvatar'
    },
    {
      event: 'TAKE_DAMAGE',
      counter: 257,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/RifleLancerAvatar'
    },
    {
      event: 'TAKE_DAMAGE',
      counter: 64,
      object: '/Lotus/Types/Enemies/Grineer/AIWeek/Avatars/ShotgunLancerAvatar'
    },
    {
      event: 'TAKE_DAMAGE_ITEM',
      counter: 135,
      object: '/Lotus/Weapons/Tenno/Rifle/GrnSniperRifle'
    },
    {
      event: 'TAKE_DAMAGE_ITEM',
      counter: 257,
      object: '/Lotus/Weapons/Grineer/GrineerRifle/Rifle'
    },
    {
      event: 'TAKE_DAMAGE_ITEM',
      counter: 64,
      object: '/Lotus/Weapons/Grineer/GrineerShotgun/Shotgun'
    },
    { event: 'PLAYER_XP', counter: 94204, set: true },
    {
      event: 'WEAPON_XP',
      counter: 1603998,
      object: '/Lotus/Powersuits/Saryn/Saryn',
      set: true
    },
    {
      event: 'WEAPON_XP',
      counter: 1602586,
      object: '/Lotus/Weapons/Tenno/Bows/HuntingBow',
      set: true
    },
    { event: 'INCOME', counter: 1010 },
    { event: 'ELO_RATING', counter: 30, set: true },
    { event: 'RANK', counter: 6, set: true }
  ],
  timers: [
    {
      event: 'EQUIP_WEAPON',
      object: '/Lotus/Powersuits/Saryn/Saryn',
      seconds: 222.86014
    },
    {
      event: 'EQUIP_WEAPON',
      object: '/Lotus/Powersuits/Excalibur/Excalibur',
      seconds: 0.00028030001
    },
    {
      event: 'EQUIP_WEAPON',
      object: '/Lotus/Weapons/Tenno/Bows/HuntingBow',
      seconds: 222.86014
    },
    { event: 'MISSION_TIME', object: 'en', seconds: 221.00108 }
  ],
  events: []
}
```