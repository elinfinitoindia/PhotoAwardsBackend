using PhotoAwards.Context;

namespace PhotoAwardsApi.Repository
{
    public class BaseRepository
    {
        public BaseRepository() { }

        public AppDbContext context;
        public BaseRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        

        //public void SaveChanges(AppDbContext context)
        //{   
        //    context.SaveChangesAsync();
        //}

    }
}