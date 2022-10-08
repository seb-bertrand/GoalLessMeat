using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalLessMeat.AppLogic.Contracts.Persistence;
using GoalLessMeat.Domain.Enums;

namespace GoalLessMeat.AppLogic.Features.DailyMeal.Commands.AddTodaysMeal
{
    public class AddTodaysMealCommand : IRequest<AddTodaysMealCommandResponse>
    {
        public MealType MealType { get; set; }
    }

    public class AddTodaysMealCommandHandler : IRequestHandler<AddTodaysMealCommand, AddTodaysMealCommandResponse>
    {
        private readonly IAsyncRepository<Domain.Entities.DailyMeal> _dailyMealRepository;

        public AddTodaysMealCommandHandler(IAsyncRepository<Domain.Entities.DailyMeal> dailyMealRepository)
        {
            _dailyMealRepository = dailyMealRepository;
        }

        public async Task<AddTodaysMealCommandResponse> Handle(AddTodaysMealCommand request, CancellationToken cancellationToken)
        {
            var response = new AddTodaysMealCommandResponse();
            var dailyMeal = new Domain.Entities.DailyMeal(request.MealType);
            
            //TODO Validate that Today's meal does not already exists in the DB

            await _dailyMealRepository.AddAsync(dailyMeal).ConfigureAwait(false);
            return response;
        }
    }
}
