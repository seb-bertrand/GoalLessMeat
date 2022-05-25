using System;
namespace GoalLessMeat.Domain.Entities
{
	public class User
	{
		public int? Id { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public List<DailyMeal> DailyMeals { get; set; }

        public User()
        {
			Firstname = String.Empty;
			Lastname = String.Empty;
			DailyMeals = new List<DailyMeal>();
        }
	}
}

