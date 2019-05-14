using System.Threading.Tasks;
using BattleMuffin.Models;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    public interface IClient
    {
        Task<OAuthAccessToken> GetOAuthToken();
        Task<RequestResult<T>> Get<T>(string requestUri, string? arrayName = null) where T : class;
    }
}
