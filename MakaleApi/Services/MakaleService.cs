using MakaleApi.Models;

namespace MakaleApi.Services.MongoRepository
{
    public class MakaleService : BaseMongoRepository<Makale>
    {
        //private readonly IMongoCollection<Makale> _makaleler;

        public MakaleService(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
       
    
}
}
