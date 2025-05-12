INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, 
RecipeItemPrettyName, BuildTimeInMinutes, PriceInStandardCredits, SkipBuildPriceInPlatinum, 
CreationTimestamp, LastModificationTimestamp)
VALUES('AB6202AB-E586-4E12-B1E9-94AC656AD03E', 5, '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'Cronus', '/Lotus/Types/Recipes/CronusBlueprint',
'CronusBlueprint', 720, 15000, 25, 
'2025-05-09 10:44:56.198218-05:00', '0001-01-01 00:00:00');


INSERT INTO RecipeItems
(Id, RecipeId, ItemName, PrettyName, ItemCountNeeded, 
CreationTimestamp, LastModificationTimestamp)
VALUES('A860E516-3B4A-4CB1-866C-39FF9ADCF8F0', 'AB6202AB-E586-4E12-B1E9-94AC656AD03E', '/Lotus/Types/Items/MiscItems/Morphic', 'Morphics', 1,  '2025-05-09 10:44:56.198218-05:00', '0001-01-01 00:00:00'),
('DDE81756-AFC6-4768-9D37-D84D9CEC2F75', 'AB6202AB-E586-4E12-B1E9-94AC656AD03E', '/Lotus/Types/Items/MiscItems/Ferrite', 'Ferrite', 500,  '2025-05-09 10:44:56.198218-05:00', '0001-01-01 00:00:00'),
('BDFF4A68-1D79-479D-9A8E-A62CD381DEFC', 'AB6202AB-E586-4E12-B1E9-94AC656AD03E', '/Lotus/Types/Items/MiscItems/PolymerBundle', 'Polymer Bundle', 75,  '2025-05-09 10:44:56.198218-05:00', '0001-01-01 00:00:00');