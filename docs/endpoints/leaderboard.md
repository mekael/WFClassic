
// Get the top 10 on the leaderboard

 GET /stats/leaderboard.php?field=Kills&before=4&after=6&accountId=67fca41ccd48d7d4f5537013 


// get user specific rank within leaderboard

 GET http://localhost/stats/leaderboard.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=8729948052073698920&steamId=0&field=Kills&before=4&after=6&pivotAccountId=c64c1e01-34d6-4311-ae40-7baa5eba3016 HTTP/1.1


```json
{

""players"" :[
{
""DisplayName"" :""mekael"",
""score"":124,
""rank"":111
},
{
""DisplayName"" :""bixby"",
""score"":1000000,
""rank"":1
}
]

}
```