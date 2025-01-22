using Skistar.Dtos;
using Skistar.Services.Interfaces;
using Skistar.ViewModels;

namespace Skistar.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ApiEngine _apiEngine;

        public StatisticsService(ApiEngine apiEngine)
        {
            _apiEngine = apiEngine;
        }
        public async Task<StatisticsViewModel> GetUserStatistics()
        {
            var genres = await _apiEngine.GetAsync<List<GenreDto>>("https://dsvkurs.miun.se/api/Genres", "key1");
            var weathers = await _apiEngine.GetAsync<List<WeatherDto>>("https://localhost:7159/api/WeatherForecast");
            // hämta från api
            return null;
        }
    }
}
