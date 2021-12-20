using System.Collections.Generic;
using System.Threading.Tasks;
using HyruleHelper.DataAccess.Models;
using HyruleHelper.DataAccess.Repositories.Interfaces;
using MongoDB.Driver;

namespace HyruleHelper.DataAccess.Repositories
{
    public class MongoRepository<TResource> : IMongoRepository<TResource> where TResource : ResourceBase
    {
        private readonly IMongoClient _mongoClient;

        public MongoRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }
        
        public async Task<IEnumerable<TResource>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<TResource> GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TResource> Create(TResource data)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TResource> Update(string id, TResource data)
        {
            throw new System.NotImplementedException();
        }

        public async Task Delete(string id, bool hardDelete = false)
        {
            throw new System.NotImplementedException();
        }
    }
}