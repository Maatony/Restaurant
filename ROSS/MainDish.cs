using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROSS
{
    public class MainDish : Meal
    {
        public MainDish()
        {
            Price = 55;
            NutritionLevel = 55;
            MealQuality = QualityOfFood.Average;
        }

        public MainDish(QualityOfFood mealQuality)
        {
            Price = 55;
            NutritionLevel = 55;
            MealQuality = mealQuality;
        }
    }
}