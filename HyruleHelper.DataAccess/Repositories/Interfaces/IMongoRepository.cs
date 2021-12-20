using System.Collections.Generic;
using System.Threading.Tasks;
using HyruleHelper.DataAccess.Models;

namespace HyruleHelper.DataAccess.Repositories.Interfaces
{
    public interface IMongoRepository<T> where T : ResourceBase
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(string id);
        public Task<T> Create(T data);
        public Task<T> Update(string id, T data);
        public Task Delete(string id, bool hardDelete = false);
    }
}