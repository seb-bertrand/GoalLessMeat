using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.AppLogic.Contracts.Persistence;
using GoalLessMeat.Domain.Entities;
using GoalLessMeat.Persistence.Repositories;

namespace GoalLessMeat.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IAsyncRepository<DailyMeal>, AsyncRepository<DailyMeal>>();
            return services;
        }
    }
}
