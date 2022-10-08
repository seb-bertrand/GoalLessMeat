using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.Domain.Entities;

namespace GoalLessMeat.AppLogic.Contracts.Persistence
{
    public interface IDailyMealRepository
    {
        Task<DailyMeal> GetTodaysMealAsync();
    }
}
