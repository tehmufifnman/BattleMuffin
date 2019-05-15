# BattleMuffin Blizzard API Client
Battle is a .NET Core 3.0 (preview 5 currently) wrapper for the [Blizzard Community & Game Data APIs](https://develop.battle.net/) written in C# 8.0.

## Requirements

You must have a set of Blizzard API client credentials to use their API.  Please see their [getting startard](https://develop.battle.net/documentation/guides/getting-started) page for more information.

## Installing via NuGet

```
 Install-Package BattleMuffin
```

## Installing via .NET CLI

```
 dotnet add package BattleMuffin
```

## Using the BattleMuffin API Client

``` cs
var clientId = "CLIENT_ID";
var clientSecret = "CLIENT_SECRET";
var warcraftClient = new WarcraftClient(clientId, clientSecret);
// or to specify a region and locale.
// var warcraftClient = new WarcraftClient(clientId, clientSecret, Region.EU, "Locale.en_GB");

var result = await warcraftClient.GetItemAsync(72092); 
Console.WriteLine("Iten Name - " + result.Value.Name); // Ghost Iron Ore
```

# API Implementation Plan
## World of Warcraft Community APIs
| Name                              | Route                                 | Implemented? | 
|-----------------------------------|---------------------------------------|--------------| 
| World of Warcraft OAuth Profile   | /wow/user/characters                  | No           | 
| Achievement                       | /wow/achievement/:id                  | Yes          | 
| Auction Data Status               | /wow/auction/data/:realm              | Yes          | 
| Boss Master List                  | /wow/boss/                            | Yes          | 
| Boss                              | /wow/boss/:bossid                     | Yes          | 
| Challenge Mode Realm Leaderboard  | /wow/challenge/:realm                 | Yes          | 
| Challenge Mode Region Leaderboard | /wow/challenge/region                 | Yes          | 
| Character Profile                 | /wow/character/:realm/:characterName  | Yes          | 
| Guild Profile                     | /wow/guild/:realm/:guildName          | Yes          | 
| Item                              | wow/item/:itemId                      | Yes          | 
| Item Set                          | /wow/item/set/:setId                  | Yes          | 
| Mount Master List                 | /wow/mount/                           | Yes          | 
| Pet Master List                   | /wow/pet/                             | Yes          | 
| Pet Ability                       | /wow/pet/ability/:abilityID           | Yes          | 
| Pet Species                       | /wow/pet/species/:speciesID           | Yes          | 
| Pet Stats                         | /wow/pet/stats/:speciesID             | Yes          | 
| PvP Leaderboard                   | /wow/leaderboard/:bracket             | Yes          | 
| Quest                             | /wow/quest/:questId                   | Yes          | 
| Realm Status                      | /wow/realm/status                     | Yes          | 
| Recipe                            | /wow/recipe/:recipeId                 | Yes          | 
| Spell                             | /wow/spell/:spellId                   | Yes          | 
| Zone Master List                  | /wow/zone/                            | Yes          | 
| Zone                              | /wow/zone/:zoneid                     | Yes          | 
| Battlegroups                      | /wow/data/battlegroups/               | Yes          | 
| Character Races                   | /wow/data/character/races             | Yes          | 
| Character Classes                 | /wow/data/character/classes           | Yes          | 
| Character Achievements            | /wow/data/character/achievements      | Yes          | 
| Guild Rewards                     | /wow/data/guild/rewards               | Yes          | 
| Guild Perks                       | /wow/data/guild/perks                 | Yes          | 
| Guild Achievements                | /wow/data/guild/achievements          | Yes          | 
| Item Classes                      | /wow/data/item/classes                | Yes          | 
| Talents                           | /wow/data/talents                     | Yes          | 
| Pet Types                         | /wow/data/pet/types                   | Yes          | 

## World of Warcraft Game Data APIs
NYI

## World of Warcraft Profile APIs
NYI

## Diablo 3 Community APIs
NYI

## Diablo 3 Game Date APIs
NYI

## Startcraft 2 Community APIs
NYI

## Starcraft 2 Game Data APIs
NYI

## OAuth APIs
NYI
