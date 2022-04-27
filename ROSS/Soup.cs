using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROSS
{
    public class Soup : Meal
    {
        public Soup()
        {
            Price = 25;
            NutritionLevel = 20;
            MealQuality = QualityOfFood.Average;
        }

        public Soup(QualityOfFood mealQuality)
        {
            Price = 25;
            NutritionLevel = 20;
            MealQuality = mealQuality;
        }
    }
}