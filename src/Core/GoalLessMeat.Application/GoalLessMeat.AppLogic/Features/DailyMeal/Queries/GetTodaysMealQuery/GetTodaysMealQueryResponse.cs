using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.AppLogic.Responses;

namespace GoalLessMeat.AppLogic.Features.DailyMeal.Queries.GetTodaysMealQuery
{
    public class GetTodaysMealQueryResponse : BaseResponse
    {
        public GetTodaysMealQueryResponse(Domain.Entities.DailyMeal todaysMeal)
        {
            TodaysMeal = todaysMeal;
        }

        public Domain.Entities.DailyMeal TodaysMeal { get; }
    }
}
