namespace ROSS
{
    public abstract class Meal
    {
        public int Price { get; set; }
        protected QualityOfFood MealQuality { get; set; }
        protected int NutritionLevel { get; set; }
                        
        public double CalculateTip()
        {
            return ((double)MealQuality * 0.25);
        }

        public int GetNutritionLevel()
        {
            return NutritionLevel;
        }
    }
}