// Lindsay Allen (Jackson)
// CIS162AD #31778
// 4/19/21
// Meal Plan Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class mealPlanCalculatorForm : Form
    {
        public mealPlanCalculatorForm()
        {
            InitializeComponent();
        }

        MealPlan meal = new MealPlan();
        Dormitory dorm = new Dormitory();

        // Creates instance of subtotal form
        subtotalForm subtotalForm = new subtotalForm();

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // display outputs on subtotal form
            DisplaySubtotal();
            DisplayHall();
            DisplayMealPlan();

            // Displays the form
            subtotalForm.ShowDialog();

        }

        // calculates the subtotal based on users dorm and meal plan selections
        private decimal CalculateSubtotal()
        {
            if (allenHallRadio.Checked)
            {
                if (sevenMealsRadio.Checked)
                {
                    return dorm.AllenHallCost + meal.SevenMealsCost;
                }
                else if (fourteenMealsRadio.Checked)
                {
                    return dorm.AllenHallCost + meal.FourteenMealsCost;
                }
                else
                {
                    return dorm.AllenHallCost + meal.UnlimitedMealsCost;
                }
            }
            else if (pikeHallRadio.Checked)
            {
                if (sevenMealsRadio.Checked)
                {
                    return dorm.PikeHallCost + meal.SevenMealsCost;
                }
                else if (fourteenMealsRadio.Checked)
                {
                    return dorm.PikeHallCost + meal.FourteenMealsCost;
                }
                else
                {
                    return dorm.PikeHallCost + meal.UnlimitedMealsCost;

                }
            }
            else if (farthingHallRadio.Checked)
            {
                if (sevenMealsRadio.Checked)
                {
                    return dorm.FarthingHallCost + meal.SevenMealsCost;
                }
                else if (fourteenMealsRadio.Checked)
                {
                    return dorm.FarthingHallCost + meal.FourteenMealsCost;
                }
                else
                {
                    return dorm.FarthingHallCost + meal.UnlimitedMealsCost;

                }
            }
            else
            {
                if (sevenMealsRadio.Checked)
                {
                    return dorm.UniversitySuitesCost + meal.SevenMealsCost;
                }
                else if (fourteenMealsRadio.Checked)
                {
                    return dorm.UniversitySuitesCost + meal.FourteenMealsCost;
                }
                else
                {
                    return dorm.UniversitySuitesCost + meal.UnlimitedMealsCost;

                }
            }

        }

        // displays subtotal on subtotal form
        private void DisplaySubtotal()
        {
            subtotalForm.subtotalOutput.Text = CalculateSubtotal().ToString("C");
        }

        // displays users chosen dorm on subtotal form
        private void DisplayHall()
        {
            if (allenHallRadio.Checked)
            {
                subtotalForm.hallOutput.Text = "Allen Hall";
            }
            else if (pikeHallRadio.Checked)
            {
                subtotalForm.hallOutput.Text = "Pike Hall";
            }
            else if (farthingHallRadio.Checked)
            {
                subtotalForm.hallOutput.Text = "Farthing Hall";
            }
            else
            {
                subtotalForm.hallOutput.Text = "University Suites";
            }
        }

        // displays users chosen meal plan on subtotal form
        private void DisplayMealPlan()
        {
            if (sevenMealsRadio.Checked)
            {
                subtotalForm.mealPlanOutput.Text = "7 per week";
            }
            else if (fourteenMealsRadio.Checked)
            {
                subtotalForm.mealPlanOutput.Text = "14 per week";
            }
            else
            {
                subtotalForm.mealPlanOutput.Text = "Unlimited meals";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
