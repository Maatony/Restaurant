using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROSS
{
    public class Dessert : Meal
    {
        public Dessert()
        {
            Price = 30;
            NutritionLevel = 15;
            MealQuality = QualityOfFood.Average;
        }

        public Dessert(QualityOfFood mealQuality)
        {
            Price = 30;
            NutritionLevel = 15;
            MealQuality = mealQuality;
        }
    }
}