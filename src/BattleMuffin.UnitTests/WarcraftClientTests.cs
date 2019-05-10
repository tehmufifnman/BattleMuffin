using System.Linq;
using System.Net;
using BattleMuffin.Clients;
using BattleMuffin.Enums;
using BattleMuffin.UnitTests.Attributes;
using RichardSzalay.MockHttp;
using Xunit;

namespace BattleMuffin.UnitTests
{
    public class WarcraftClientTests
    {
        [Theory]
        [JsonData("achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId, string achievementResponse)
        {
            var warcraftClient = BuildMockClient(
                $"https://us.api.blizzard.com/wow/achievement/{achievementId}?locale=en_US",
                achievementResponse);

            var result = await warcraftClient.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }
        
        [Theory]
        [JsonData("auction.json")]
        public async void GetAuctionAsyncTest(string realm, string auctionResponse)
        {
            var warcraftClient = BuildMockClient(
                $"https://us.api.blizzard.com/wow/auction/data/{realm}?locale=en_US",
                auctionResponse);

            var result = await warcraftClient.GetAuctionAsync(realm);
            Assert.NotNull(result.Value);
        }
        
        [Theory]
        [JsonData("auction_snapshot.json")]
        public async void GetAuctionSnapshotAsyncTest(string auctionSnapshotUrl, string auctionSnapshotResponse)
        {
            var warcraftClient = BuildMockClient(
                auctionSnapshotUrl,
                auctionSnapshotResponse);

            var result = await warcraftClient.GetAuctionHouseSnapshotAsync(auctionSnapshotUrl);
            Assert.NotNull(result.Value);
        }        

        private static IWarcraftClient BuildMockClient(string requestUri, string responseContent,
            HttpStatusCode? statusCode = null)
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp
                .When("https://us.battle.net/oauth/token")
                .Respond(
                    "application/json",
                    @"{""access_token"": ""ACCESS-TOKEN"", ""token_type"": ""bearer"", ""expires_in"": 12345, ""scope"": ""test.scope""}");

            if (statusCode == null)
            {
                mockHttp
                    .When(requestUri)
                    .Respond(
                        "application/json",
                        responseContent);
            }
            else
            {
                mockHttp
                    .When(requestUri)
                    .Respond(
                        statusCode.Value,
                        "application/json",
                        responseContent);
            }

            return new WarcraftClient(
                "clientIdHere",
                "clientSecretHere",
                Region.US,
                Locale.en_US,
                mockHttp.ToHttpClient());
        }
    }
}
