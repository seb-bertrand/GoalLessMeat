using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.AppLogic.Contracts.Persistence;
using MediatR;

namespace GoalLessMeat.AppLogic.Features.DailyMeal.Queries.GetTodaysMealQuery
{
    public class GetTodaysMealQuery : IRequest<GetTodaysMealQueryResponse>
    {

    }

    public class GetTodaysMealQueryHandler : IRequestHandler<GetTodaysMealQuery, GetTodaysMealQueryResponse>
    {
        private readonly IDailyMealRepository _dailyMealRepository;

        public GetTodaysMealQueryHandler(IDailyMealRepository dailyMealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
        }
        public async Task<GetTodaysMealQueryResponse> Handle(GetTodaysMealQuery request, CancellationToken cancellationToken)
        {
            var result = await _dailyMealRepository.GetTodaysMealAsync().ConfigureAwait(false);
            var response = new GetTodaysMealQueryResponse(result);
            return response;
        }
    }
}
