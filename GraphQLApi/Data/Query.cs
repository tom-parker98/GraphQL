using GraphQLApi.Models;

namespace GraphQLApi.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheros([Service] ApplicationDbContext context) => context.Superheroes;
    }
}
