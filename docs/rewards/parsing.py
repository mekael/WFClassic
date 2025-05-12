import json
import pandas
import uuid

cats = pandas.read_json("./rewards/7.9_rewards_listing.json")
cats["Id"] = [uuid.uuid4() for _ in range(len(cats))]
cats["StreakStartDate"] =0
cats["StreakEndDate"] =0
cats["RandLowerBound"] =0
cats["RandUpperBound"] =0
cats["CreationTimestamp"]="2025-05-08 21:00:23.1978374-05:00"
cats["LastModificationTimestamp"]="2025-05-08 21:00:23.1978374-05:00"

cats = cats[['Id','RewardType','Icon','ItemType','ProductCategory','Amount','Tier','DisplayName',
             'Rarity','StreakStartDate','StreakEndDate','RandLowerBound','RandUpperBound','CreationTimestamp','LastModificationTimestamp']]

cats.to_csv("./rewards/7.9_rewards_listing.csv",index=False)
