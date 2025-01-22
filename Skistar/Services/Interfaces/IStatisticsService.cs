using Skistar.ViewModels;

namespace Skistar.Services.Interfaces;

public interface IStatisticsService
{
    Task<StatisticsViewModel> GetUserStatistics();
}
