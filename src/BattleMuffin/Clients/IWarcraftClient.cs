using System.Threading.Tasks;
using BattleMuffin.Models;

namespace BattleMuffin.Clients
{
    public interface IWarcraftClient
    {
        Task<AchievementCategoriesIndex> GetAchievementCategoriesIndexAsync();
    }
}
