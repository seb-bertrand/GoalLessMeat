using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.AppLogic.Contracts.Persistence;
using GoalLessMeat.Domain.Common;
using LiteDB;

namespace GoalLessMeat.Persistence.Repositories
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : IAggregateRoot
    {
        private string DB_PATH = Path.Combine(FileSystem.AppDataDirectory, "GoalLessMeat.db");
        public async Task<T> GetByIdAsync(Guid id)
        {
            using var db = new LiteDatabase(DB_PATH);
            var collectionName = nameof(T) + "s";
            var collection = db.GetCollection<T>(collectionName);
            var result = collection.Query().Where(entity => entity.Id == id).SingleOrDefault();
            return result;
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            using var db = new LiteDatabase(DB_PATH);
            var collectionName = nameof(T) + "s";
            var collection = db.GetCollection<T>(collectionName);
            var results = collection.Query().ToList();
            return results;
        }

        public async Task<T> AddAsync(T entity)
        {
            using var db = new LiteDatabase(DB_PATH);
            var collectionName = nameof(T) + "s";
            var collection = db.GetCollection<T>(collectionName);
            collection.Insert(entity);
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            using var db = new LiteDatabase(DB_PATH);
            var collectionName = nameof(T) + "s";
            var collection = db.GetCollection<T>(collectionName);
            collection.Update(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            using var db = new LiteDatabase(DB_PATH);
            var collectionName = nameof(T) + "s";
            var collection = db.GetCollection<T>(collectionName);
            collection.Delete(entity.Id);
        }
    }
}
