using Skistar.Models;

namespace Skistar.Dtos
{
    public record GenreDto
    {
        public int Id { get; init; } 
        public string Name { get; init; }
    }
}
