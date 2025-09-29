


useful if we need to calc the gameModeId server side. 




```text

// algorithm for obtaining region/alert/node from gameModeId

if gameModeId >10000000 
  gameModeId -= 10000000
  isAlert= true

if gameModeId > 10000
  region = Math.Floor(gameModeId/10000)
  gameModeId = gameModeId %10000

nodeId = gameModeId.ToString().Reverse();


```



```lua
-- regionVal =  get the start chart region, multiply by 10000
-- alertFlag = if isAlert then 10000000 else 0
-- split the node namde into solNode and the node number. keep the node number as a string
-- initialize nodeVal = 0
-- initialize multiplier =10
-- loop over each digit
-- nodeval += digit*multiplier
-- multiplier *=10
-- essentially we are reversing the node number and then multilying by 10
-- add regionVal,nodeVal, and alertFlag 



function BuildGameModeIdForNode(nodeName)
  local starChart = gRegion:GetGameRules():GetStarChart()
  
  if not IsNull(starChart) and nodeName ~= nil and nodeName ~= "" then
    local alertFlag = 0
    local alertTagIdx = string.find(nodeName, _T.ALERT_TAG)

    if alertTagIdx ~= nil then
      nodeName = string.sub(nodeName, 1, alertTagIdx - 1)
      alertFlag = _T.ALERT_FLAG
    end
    
    local node = starChart:GetNodeForMission(Symbol(nodeName), 0)
    
    if not IsNull(node) then
      local regionVal = (node.region + 1) * PACKED_GAMEMODE_REGION_OFFSET
      if nodeName ~= nil then
        local nodeVal = 0
        local mult = 1
        for i = string.len(nodeName), 1, -1 do
          local digit = tonumber(string.sub(nodeName, i, i))
          if digit ~= nil then
            nodeVal = nodeVal + digit * mult
            mult = mult * 10
          else
            break
          end
        end
        return regionVal + nodeVal + alertFlag
      end
    end
  
  end

  local regionId = _T.gSelectedRegionId
  
  if regionId <= 0 then
    regionId = 1
  end
  
  return regionId * PACKED_GAMEMODE_REGION_OFFSET
end

```