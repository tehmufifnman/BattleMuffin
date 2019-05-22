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
| Mythic Raid Leaderboard            | /data/wow/leaderboard/hall-of-fame/{raid}/{faction}                                          | No           | 
| Mounts Index                       | /data/wow/mount/index                                                                        | No           | 
| Mount                              | /data/wow/mount/{mountId}                                                                    | No           | 
| Mythic Keystones Dungeons Index    | /data/wow/mythic-keystone/dungeon/index                                                      | No           | 
| Mythic Keystone Dungeon            | /data/wow/mythic-keystone/dungeon/{dungeonId}                                                | No           | 
| Mythic Keystone Index              | /data/wow/mythic-keystone/index                                                              | No           | 
| Mythic Keystone Periods Index      | /data/wow/mythic-keystone/period/index                                                       | No           | 
| Mythic Keystone Period             | /data/wow/mythic-keystone/period/{periodId}                                                  | No           | 
| Mythic Keystone Seasons Index      | /data/wow/mythic-keystone/season/index                                                       | No           | 
| Mythic Keystone Season             | /data/wow/mythic-keystone/season/{seasonId}                                                  | No           | 
| Mythic Keystone Leaderboards Index | /data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/index                        | No           | 
| Mythic Keystone Leaderboard        | /data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/{dungeonId}/period/{period}  | No           | 
| Pets Index                         | /data/wow/pet/index                                                                          | No           | 
| Pet                                | /data/wow/pet/{petId}                                                                        | No           | 
| Playable Class Index               | /data/wow/playable-class/index                                                               | No           | 
| Playable Class                     | /data/wow/playable-class/{classId}                                                           | No           | 
| PvP Talent Slots                   | /data/wow/playable-class/{classId}/pvp-talent-slots                                          | No           | 
| Playable Specializations Index     | /data/wow/playable-specialization/index                                                      | No           | 
| Playable Specialization            | /data/wow/playable-specialization/{specId}                                                   | No           | 
| Power Types Index                  | /data/wow/power-type/index                                                                   | No           | 
| Power Type                         | /data/wow/power-type/{powerTypeId}                                                           | No           | 
| PvP Seasons Index                  | /data/wow/pvp-season/index                                                                   | No           | 
| PvP Season                         | /data/wow/pvp-season/{pvpSeasonId}                                                           | No           | 
| PvP Leaderboards Index             | /data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/index                                     | No           | 
| PvP Leaderboard                    | /data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/{pvpBracket}                              | No           | 
| PvP Rewards Index                  | /data/wow/pvp-season/{pvpSeasonId}/pvp-reward/index                                          | No           | 
| PvP Tier Media                     | /data/wow/media/pvp-tier/{pvpTierId}                                                         | No           | 
| PvP Tiers Index                    | /data/wow/pvp-tier/index                                                                     | No           | 
| PvP Tier                           | /data/wow/pvp-tier/{pvpTierId}                                                               | No           | 
| Realms Index                       | /data/wow/realm/index                                                                        | No           | 
| Realm                              | /data/wow/realm/{realmSlug}                                                                  | No           | 
| Regions Index                      | /data/wow/region/index                                                                       | No           | 
| Region                             | /data/wow/region/{regionId}                                                                  | No           | 
| WoW Token Index                    | /data/wow/token/index                                                                        | No           | 

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
