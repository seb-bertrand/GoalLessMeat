using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using GoalLessMeat.AppLogic.Features.DailyMeal.Commands.AddTodaysMeal;
using GoalLessMeat.Domain.Enums;
using MediatR;

namespace GoalLessMeat.ViewModels
{
    public partial class DailyEncodingViewModel : ObservableObject
    {
        private readonly IMediator _mediator;

        public DailyEncodingViewModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        [RelayCommand]
        private async Task AddMeal(MealType mealType)
        {
            var request = new AddTodaysMealCommand { MealType = mealType };
            await _mediator.Send(request);
        }

        
    }
}
