// Lindsay Allen (Jackson)
// CIS162AD #31778
// 4/19/21
// Meal Plan Calculator

using System;
using System.Collections.Generic;
using System.Text;

namespace Dorm_and_Meal_Plan_Calculator
{
    class MealPlan
    {
        private decimal sevenMeals;
        private decimal fourteenMeals;
        private decimal unlimitedMeals;

        // Constructor
        public MealPlan()
        {
            // sets cost value of each property
            sevenMeals = 600;
            fourteenMeals = 1200;
            unlimitedMeals = 1700;
        }

        // gets price of 7 meal plan
        public decimal SevenMealsCost
        {
            get { return sevenMeals; }
        }

        // gets price of 14 meal plan
        public decimal FourteenMealsCost
        {
            get { return fourteenMeals; }
        }

        // gets price of unlimited meal plan
        public decimal UnlimitedMealsCost
        {
            get { return unlimitedMeals; }
        }

    }
}
