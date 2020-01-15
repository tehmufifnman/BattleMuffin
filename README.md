# BattleMuffin Blizzard API Client
Battle is a .NET Core 3.1 wrapper for the [Blizzard Community & Game Data APIs](https://develop.battle.net/) written in C# 8.0.

## Requirements

You must have a set of Blizzard API client credentials to use their API.  Please see their [getting started](https://develop.battle.net/documentation/guides/getting-started) page for more information.

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
//Warcraft Community API Example
var clientId = "CLIENT_ID";
var clientSecret = "CLIENT_SECRET";
var client = new WarcraftCommunityClient(clientId, clientSecret);
// or to specify a region and locale.
// var client = new WarcraftCommunityClient(clientId, clientSecret, Region.EU, "Locale.en_GB");

var result = await client.GetItemAsync(72092); 
Console.WriteLine("Iten Name - " + result.Value.Name); // Ghost Iron Ore
```

``` cs
//Warcraft GameData API Example
var clientId = "CLIENT_ID";
var clientSecret = "CLIENT_SECRET";
var client = new WarcraftGameDataClient(clientId, clientSecret);
// or to specify a region and locale.
// var client = new WarcraftGameDataClient(clientId, clientSecret, Region.EU, "Locale.en_GB");

var result = await client.GetRealmAsync("hyjal"); 
Console.WriteLine("Realm Timezone - " + result.Value.Timezone); // America/Los_Angeles
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
| Name                               | Route                                                                                        | Implemented? | 
|------------------------------------|----------------------------------------------------------------------------------------------|--------------| 
| Achievement Categories Index       | /data/wow/achievement-category/index                                                         | Yes          | 
| Achievement Category               | /data/wow/achievement-category/{achievementCategoryId}                                       | Yes          | 
| Achievements Index                 | /data/wow/achievement/index                                                                  | Yes          | 
| Achievement                        | /data/wow/achievement/{achievementId}                                                        | Yes          | 
| Achievement Media                  | /data/wow/media/achievement/{achievementId}                                                  | Yes          | 
| Connected Realms Index             | /data/wow/connected-realm/index                                                              | Yes          | 
| Connected Realm                    | /data/wow/connected-realm/{connectedRealmId}                                                 | Yes          | 
| Create Families Index              | /data/wow/creature-family/index                                                              | Yes          | 
| Creature Family                    | /data/wow/creature-family/{creatureFamilyId}                                                 | Yes          | 
| Creature Types Index               | /data/wow/creature-type/index                                                                | Yes          | 
| Creature Type                      | /data/wow/creature-type/{creatureTypeId}                                                     | Yes          | 
| Creature                           | /data/wow/creature/{creatureId}                                                              | Yes          | 
| Creature Display Media             | /data/wow/media/creature-display/{creatureDisplayId}                                         | Yes          | 
| Creature Family Media              | /data/wow/media/creature-family/{creatureFamilyId}                                           | Yes          | 
| Guild                              | /data/wow/guild/{realmSlug}/{nameSlug}                                                       | Yes          | 
| Guild Achievements                 | /data/wow/guild/{realmSlug}/{nameSlug}/achievements                                          | Yes          | 
| Guild Roster                       | /data/wow/guild/{realmSlug}/{nameSlug}/roster                                                | Yes          | 
| Guild Crest Components Index       | /data/wow/guild-crest/index                                                                  | Yes          | 
| Guild Crest Border Media           | /data/wow/media/guild-crest/border/{borderId}                                                | Yes          | 
| Guild Crest Emblem Media           | /data/wow/media/guild-crest/emblem/{emblemId}                                                | Yes          | 
| Mythic Keystone Affixes Index      | /data/wow/keystone-affix/index                                                               | Yes          | 
| Mythic Keystone Affix              | /data/wow/keystone-affix/{keystoneAffixId}                                                   | Yes          | 
| Mythic Raid Leaderboard            | /data/wow/leaderboard/hall-of-fame/{raid}/{faction}                                          | Yes          | 
| Mounts Index                       | /data/wow/mount/index                                                                        | Yes          | 
| Mount                              | /data/wow/mount/{mountId}                                                                    | Yes          | 
| Mythic Keystones Dungeons Index    | /data/wow/mythic-keystone/dungeon/index                                                      | Yes          | 
| Mythic Keystone Dungeon            | /data/wow/mythic-keystone/dungeon/{dungeonId}                                                | Yes          | 
| Mythic Keystone Index              | /data/wow/mythic-keystone/index                                                              | Yes          | 
| Mythic Keystone Periods Index      | /data/wow/mythic-keystone/period/index                                                       | Yes          | 
| Mythic Keystone Period             | /data/wow/mythic-keystone/period/{periodId}                                                  | Yes          | 
| Mythic Keystone Seasons Index      | /data/wow/mythic-keystone/season/index                                                       | Yes          | 
| Mythic Keystone Season             | /data/wow/mythic-keystone/season/{seasonId}                                                  | Yes          | 
| Mythic Keystone Leaderboards Index | /data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/index                        | Yes          | 
| Mythic Keystone Leaderboard        | /data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/{dungeonId}/period/{period}  | Yes          | 
| Pets Index                         | /data/wow/pet/index                                                                          | Yes          | 
| Pet                                | /data/wow/pet/{petId}                                                                        | Yes          | 
| Playable Class Index               | /data/wow/playable-class/index                                                               | Yes          | 
| Playable Class                     | /data/wow/playable-class/{classId}                                                           | Yes          | 
| PvP Talent Slots                   | /data/wow/playable-class/{classId}/pvp-talent-slots                                          | Yes          | 
| Playable Specializations Index     | /data/wow/playable-specialization/index                                                      | Yes          | 
| Playable Specialization            | /data/wow/playable-specialization/{specId}                                                   | Yes          | 
| Power Types Index                  | /data/wow/power-type/index                                                                   | Yes          | 
| Power Type                         | /data/wow/power-type/{powerTypeId}                                                           | Yes          | 
| PvP Seasons Index                  | /data/wow/pvp-season/index                                                                   | Yes          | 
| PvP Season                         | /data/wow/pvp-season/{pvpSeasonId}                                                           | Yes          | 
| PvP Leaderboards Index             | /data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/index                                     | Yes          | 
| PvP Leaderboard                    | /data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/{pvpBracket}                              | Yes          | 
| PvP Rewards Index                  | /data/wow/pvp-season/{pvpSeasonId}/pvp-reward/index                                          | Yes          | 
| PvP Tier Media                     | /data/wow/media/pvp-tier/{pvpTierId}                                                         | Yes          | 
| PvP Tiers Index                    | /data/wow/pvp-tier/index                                                                     | Yes          | 
| PvP Tier                           | /data/wow/pvp-tier/{pvpTierId}                                                               | Yes          | 
| Realms Index                       | /data/wow/realm/index                                                                        | Yes          | 
| Realm                              | /data/wow/realm/{realmSlug}                                                                  | Yes          | 
| Regions Index                      | /data/wow/region/index                                                                       | Yes          | 
| Region                             | /data/wow/region/{regionId}                                                                  | Yes          | 
| WoW Token Index                    | /data/wow/token/index                                                                        | Yes          | 

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
