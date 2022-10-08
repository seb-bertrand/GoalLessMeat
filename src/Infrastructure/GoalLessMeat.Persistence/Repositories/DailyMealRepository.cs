using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.AppLogic.Contracts.Persistence;
using GoalLessMeat.Domain.Entities;
using LiteDB;

namespace GoalLessMeat.Persistence.Repositories
{
    public class DailyMealRepository : IDailyMealRepository
    {
        private string DB_PATH = Path.Combine(FileSystem.AppDataDirectory, "GoalLessMeat.db");
        private const string _collectionName = nameof(DailyMeal) + "s";
        public async Task<DailyMeal> GetTodaysMealAsync()
        {
            using var db = new LiteDatabase(DB_PATH);
            var collection = db.GetCollection<DailyMeal>(_collectionName);
            collection.EnsureIndex(dm => dm.DateOfConsumption);
            var filter = DateOnly.FromDateTime(DateTime.Now);
            var result = collection.Query().Where(dm => dm.DateOfConsumption == filter).FirstOrDefault();
            return result;
        }
    }
}
