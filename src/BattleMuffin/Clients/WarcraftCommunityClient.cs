using System.Net.Http;
using System.Threading.Tasks;
using BattleMuffin.Enums;
using BattleMuffin.Models.Warcraft.Community;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    /// <summary>
    ///     A client for the World of Warcraft Community & Game Data APIs.
    /// </summary>
    public class WarcraftCommunityClient : BaseClient, IWarcraftCommunityClient
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftCommunityClient" /> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the <see cref="Region" /> that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be localized in. Visit
        ///     https://develop.battle.net/documentation/guides/regionality-partitions-and-localization
        ///     to see a list of available locales.
        /// </param>
        /// <param name="client">The <see cref="HttpClient" /> to use for all API requests.</param>
        public WarcraftCommunityClient(string clientId, string clientSecret, Region region = Region.US,
            Locale locale = Locale.en_US, HttpClient? client = null) : base(clientId, clientSecret, region, locale,
            client)
        {
        }

        /// <summary>
        ///     This API resource provides a per-realm list of recently generated auction house data dumps.
        /// </summary>
        /// <remarks>
        ///     Auction APIs currently provide rolling batches of data about current auctions. Fetching auction dumps
        ///     is a two-step process that involves checking a per-realm index file to determine if a recent dump has
        ///     been generated and then fetching the most recently generated dump file (if necessary).
        /// </remarks>
        /// <param name="realm">The realm to request.</param>
        /// <returns>
        ///     The specified auction house status.
        /// </returns>
        public async Task<RequestResult<AuctionDataStatus>> GetAuctionDataStatusAsync(string realm)
        {
            return await Get<AuctionDataStatus>($"{Host}/wow/auction/data/{realm}?locale={Locale}");
        }

        /// <summary>
        ///     Get the auction house data dump from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house data dump.</param>
        /// <returns>
        ///     The auction house data dump from the specified file.
        /// </returns>
        public async Task<RequestResult<AuctionDataDump>> GetAuctionHouseDataDumpAsync(string url)
        {
            return await Get<AuctionDataDump>(url);
        }
    }
}
