using Skistar.Services.Interfaces;
using Skistar.ViewModels;

namespace Skistar.Services
{
    public class FakeStatisticsService : IStatisticsService
    {
        public StatisticsViewModel GetUserStatistics()
        {
            return new StatisticsViewModel
            {
                TotalMeters = 123,
                TotalRides = 12
            };
        }
    }
}
