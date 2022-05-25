using System;
using GoalLessMeat.Domain.Enums;

namespace GoalLessMeat.Domain.Entities
{
	public class DailyMeal
	{
		public int? Id { get; set; }
		public DateOnly DateOfConsumption { get; set; }
		public MealType? MealType { get; set; }

        public DailyMeal()
        {
			DateOfConsumption = DateOnly.FromDateTime(DateTime.Now);
        } 
	}
}

