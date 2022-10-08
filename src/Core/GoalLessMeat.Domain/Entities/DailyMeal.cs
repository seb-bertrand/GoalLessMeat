using System;
using GoalLessMeat.Domain.Common;
using GoalLessMeat.Domain.Enums;

namespace GoalLessMeat.Domain.Entities
{
	public class DailyMeal : IAggregateRoot
{
		public Guid Id { get; set; }
		public DateOnly DateOfConsumption { get; set; }
		public MealType MealType { get; set; }

        public DailyMeal(MealType mealType)
        {
            MealType = mealType;
            DateOfConsumption = DateOnly.FromDateTime(DateTime.Now);
        } 
	}
}

