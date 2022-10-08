using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.ViewModels;
using GoalLessMeat.Views;

namespace GoalLessMeat
{
    public static class ViewServiceRegistration
    {
        public static IServiceCollection AddViewServices(this IServiceCollection services)
        {
            services.AddSingleton<AppShell>()
                .AddSingleton<DailyEncodingPage>()
                .AddSingleton<CalendarPage>()
                .AddSingleton<StatisticsPage>()
                .AddSingleton<DailyEncodingViewModel>();
            
            return services;
        }
    }
}
