


INSERT INTO WorldStateEventMessages
(Id, Message, MessageType, Property, MessageDate, MessageExpirationDate, IsActive, CreationTimestamp, LastModificationTimestamp)
VALUES('31DACE59-46AA-4491-B1CD-9E98147B0D08', 'Check out the SNS Discord', 1, 'https://discord.gg/dhPJYkgK', '2025-05-13 20:10:58.3970551-05:00', '2999-05-13 20:10:58.3970551-05:00', 1, '2025-05-13 20:10:58.3970551-05:00', '2025-05-13 20:10:58.3970551-05:00'),
('1AA2E9CD-85E5-4292-BF47-0CE92DB6ED7E', 'Remember to be a cat', 1, '', '2025-05-13 20:10:58.3970551-05:00', '2999-05-13 20:10:58.3970551-05:00', 1, '2025-05-13 20:10:58.3970551-05:00', '2025-05-13 20:10:58.3970551-05:00');



INSERT INTO AlertConfigurations
(Id, IsActive, StartDate, EndDate, AllowReplay, 
MissionType, Faction, UniqueName, Icon, Unlocked, 
Completions, Seed, Difficulty, Description, IntroText, 
CompletionText, Location, LevelOverride, EnemySpec, VIPAgent, 
MinEnemyLevel, MaxEnemyLevel, CompleteTag, CreationTimestamp, LastModificationTimestamp)
VALUES('1AA2E9CD-85E5-4292-BF47-0CE92DB6ED7E', 1, '2025-05-13 20:10:58.3970551-05:00', '2909-05-13 20:10:58.3970551-05:00', 1, 
'MT_RAID', 'FC_GRINEER', 'Kill all the things', '/Lotus/Interface/Icons/Npcs/GrineerFemale.png', 1, 
1, 94368, 0.59836683270987, 'Murder things. Make sure not to become a corpse.', 'Do all the murders!',
'You did a murder', 'SolNode94', '/Lotus/Levels/Proc/Corpus/CrpOutpostLevel', '/Lotus/Types/Game/GrineerSquadOne', '', 
1, 999, 'Completed', '2025-05-13 20:10:58.3970551-05:00', '2025-05-13 20:10:58.3970551-05:00');


 
INSERT INTO AlertRewardConfigurations
(Id, AlertConfigurationId, RewardProvidedAtLocation, Credits, Xp, RandomizedItems, ItemsArray, CreationTimestamp, LastModificationTimestamp)
VALUES('1AA2E9CD-85E5-4292-BF47-0CE92DB6ED7E', '1AA2E9CD-85E5-4292-BF47-0CE92DB6ED7E',0 , 999, 10000, '/Lotus/Types/Game/MissionDecks/BossMissionRewards/NyxRewards', '/Lotus/Types/Game/StoreItem/OrokinReactorBlueprint', '2025-05-13 20:10:58.3970551-05:00', '2025-05-13 20:10:58.3970551-05:00');
