using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROSS
{
    public class Guest
    {
        private int Hunger { get; set; }
        private List<Meal> MealList { get; set; }
        private bool Sober { get; set; }
        
        public Guest()
        {
            MealList = new List<Meal>();
            Hunger = 0;
            Sober = false;
        }

        public Guest(bool sober)
        {
            MealList = new List<Meal>();
            Hunger = 0;
            Sober = sober;
        }

        public void AddMeal(Meal meal)
        {
            MealList.Add(meal);
            Hunger += meal.GetNutritionLevel();
        }

        public void AddMenu()
        {
            MealList.Add(new Soup());
            MealList.Add(new MainDish());
            MealList.Add(new Dessert());
            for (int i = MealList.Count - 3; i < MealList.Count; i++)
            {
                Hunger += MealList[i].GetNutritionLevel();
            }
        }

        public int GetHunger()
        {            
            return Hunger;
        }

        public int GetSaturation()
        {
            // Ternary expression
            return Sober ? 100 : 150;
        }
        public int PayBill()
        {
            int bill = 0;
            double quality = 0;
            foreach (Meal meal in MealList)
            {
                bill += meal.Price;
                quality += meal.CalculateTip();
            }
            return (int)(bill + 0.1 * bill * (quality/MealList.Count));
        }

        public override string ToString()
        {
            string temp = string.Empty;
            if (MealList.Count > 0)
                for (int i = 0; i < MealList.Count; i++)
                {
                    temp += $"Meal {i+1}, price {MealList[i].Price}";
                    if (i < MealList.Count - 1)
                        temp += "\n";
                }
               
            else return "No meal ordered yet.";
            return temp;
        }
    }
}