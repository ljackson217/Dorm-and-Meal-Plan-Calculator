// Lindsay Allen (Jackson)
// CIS162AD #31778
// 4/19/21
// Meal Plan Calculator

using System;
using System.Collections.Generic;
using System.Text;

namespace Dorm_and_Meal_Plan_Calculator
{
    class Dormitory
    {
        private decimal allenHall;
        private decimal pikeHall;
        private decimal farthingHall;
        private decimal universitySuites;

        // Constructor
        public Dormitory()
        {
            // sets cost value of each property
            allenHall = 1500;
            pikeHall = 1600;
            farthingHall = 1800;
            universitySuites = 2500;
    }

        // gets allen hall cost
        public decimal AllenHallCost
        {
            get { return allenHall; }
        }

        // gets pike hall cost
        public decimal PikeHallCost
        {
            get { return pikeHall; }
        }

        // gets farthing hall cost
        public decimal FarthingHallCost
        {
            get { return farthingHall; }
        }

        // gets university suites cost
        public decimal UniversitySuitesCost
        {
            get { return universitySuites; }
        }

    }
}
