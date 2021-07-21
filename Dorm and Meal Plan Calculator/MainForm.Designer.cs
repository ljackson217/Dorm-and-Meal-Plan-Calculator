
namespace Dorm_and_Meal_Plan_Calculator
{
    partial class mealPlanCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dormitoryGroup = new System.Windows.Forms.GroupBox();
            this.universitySuitesRadio = new System.Windows.Forms.RadioButton();
            this.farthingHallRadio = new System.Windows.Forms.RadioButton();
            this.pikeHallRadio = new System.Windows.Forms.RadioButton();
            this.allenHallRadio = new System.Windows.Forms.RadioButton();
            this.mealPlanGroup = new System.Windows.Forms.GroupBox();
            this.unlimitedRadio = new System.Windows.Forms.RadioButton();
            this.fourteenMealsRadio = new System.Windows.Forms.RadioButton();
            this.sevenMealsRadio = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dormitoryGroup.SuspendLayout();
            this.mealPlanGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dormitoryGroup
            // 
            this.dormitoryGroup.Controls.Add(this.universitySuitesRadio);
            this.dormitoryGroup.Controls.Add(this.farthingHallRadio);
            this.dormitoryGroup.Controls.Add(this.pikeHallRadio);
            this.dormitoryGroup.Controls.Add(this.allenHallRadio);
            this.dormitoryGroup.Location = new System.Drawing.Point(31, 35);
            this.dormitoryGroup.Name = "dormitoryGroup";
            this.dormitoryGroup.Size = new System.Drawing.Size(235, 136);
            this.dormitoryGroup.TabIndex = 1;
            this.dormitoryGroup.TabStop = false;
            this.dormitoryGroup.Text = "Dormitory";
            // 
            // universitySuitesRadio
            // 
            this.universitySuitesRadio.AutoSize = true;
            this.universitySuitesRadio.Location = new System.Drawing.Point(7, 98);
            this.universitySuitesRadio.Name = "universitySuitesRadio";
            this.universitySuitesRadio.Size = new System.Drawing.Size(225, 19);
            this.universitySuitesRadio.TabIndex = 3;
            this.universitySuitesRadio.Text = "University Suites - $2,500 per semester";
            this.universitySuitesRadio.UseVisualStyleBackColor = true;
            // 
            // farthingHallRadio
            // 
            this.farthingHallRadio.AutoSize = true;
            this.farthingHallRadio.Location = new System.Drawing.Point(7, 73);
            this.farthingHallRadio.Name = "farthingHallRadio";
            this.farthingHallRadio.Size = new System.Drawing.Size(207, 19);
            this.farthingHallRadio.TabIndex = 2;
            this.farthingHallRadio.Text = "Farthing Hall - $1,800 per semester";
            this.farthingHallRadio.UseVisualStyleBackColor = true;
            // 
            // pikeHallRadio
            // 
            this.pikeHallRadio.AutoSize = true;
            this.pikeHallRadio.Location = new System.Drawing.Point(7, 48);
            this.pikeHallRadio.Name = "pikeHallRadio";
            this.pikeHallRadio.Size = new System.Drawing.Size(185, 19);
            this.pikeHallRadio.TabIndex = 1;
            this.pikeHallRadio.Text = "Pike Hall - $1,600 per semester";
            this.pikeHallRadio.UseVisualStyleBackColor = true;
            // 
            // allenHallRadio
            // 
            this.allenHallRadio.AutoSize = true;
            this.allenHallRadio.Checked = true;
            this.allenHallRadio.Location = new System.Drawing.Point(7, 23);
            this.allenHallRadio.Name = "allenHallRadio";
            this.allenHallRadio.Size = new System.Drawing.Size(190, 19);
            this.allenHallRadio.TabIndex = 0;
            this.allenHallRadio.TabStop = true;
            this.allenHallRadio.Text = "Allen Hall - $1,500 per semester";
            this.allenHallRadio.UseVisualStyleBackColor = true;
            // 
            // mealPlanGroup
            // 
            this.mealPlanGroup.Controls.Add(this.unlimitedRadio);
            this.mealPlanGroup.Controls.Add(this.fourteenMealsRadio);
            this.mealPlanGroup.Controls.Add(this.sevenMealsRadio);
            this.mealPlanGroup.Location = new System.Drawing.Point(289, 35);
            this.mealPlanGroup.Name = "mealPlanGroup";
            this.mealPlanGroup.Size = new System.Drawing.Size(247, 104);
            this.mealPlanGroup.TabIndex = 2;
            this.mealPlanGroup.TabStop = false;
            this.mealPlanGroup.Text = "Meal Plan";
            // 
            // unlimitedRadio
            // 
            this.unlimitedRadio.AutoSize = true;
            this.unlimitedRadio.Location = new System.Drawing.Point(7, 73);
            this.unlimitedRadio.Name = "unlimitedRadio";
            this.unlimitedRadio.Size = new System.Drawing.Size(225, 19);
            this.unlimitedRadio.TabIndex = 2;
            this.unlimitedRadio.Text = "Unlimited meals - $1,700 per semester";
            this.unlimitedRadio.UseVisualStyleBackColor = true;
            // 
            // fourteenMealsRadio
            // 
            this.fourteenMealsRadio.AutoSize = true;
            this.fourteenMealsRadio.Location = new System.Drawing.Point(7, 48);
            this.fourteenMealsRadio.Name = "fourteenMealsRadio";
            this.fourteenMealsRadio.Size = new System.Drawing.Size(235, 19);
            this.fourteenMealsRadio.TabIndex = 1;
            this.fourteenMealsRadio.Text = "14 meals per week - $1,200 per semester";
            this.fourteenMealsRadio.UseVisualStyleBackColor = true;
            // 
            // sevenMealsRadio
            // 
            this.sevenMealsRadio.AutoSize = true;
            this.sevenMealsRadio.Checked = true;
            this.sevenMealsRadio.Location = new System.Drawing.Point(7, 23);
            this.sevenMealsRadio.Name = "sevenMealsRadio";
            this.sevenMealsRadio.Size = new System.Drawing.Size(220, 19);
            this.sevenMealsRadio.TabIndex = 0;
            this.sevenMealsRadio.TabStop = true;
            this.sevenMealsRadio.Text = "7 meals per week - $600 per semester";
            this.sevenMealsRadio.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(289, 147);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(101, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(461, 148);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mealPlanCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 211);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mealPlanGroup);
            this.Controls.Add(this.dormitoryGroup);
            this.Name = "mealPlanCalculatorForm";
            this.Text = "Dormitory and Meal Plan Selection";
            this.dormitoryGroup.ResumeLayout(false);
            this.dormitoryGroup.PerformLayout();
            this.mealPlanGroup.ResumeLayout(false);
            this.mealPlanGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dormitoryGroup;
        private System.Windows.Forms.RadioButton universitySuitesRadio;
        private System.Windows.Forms.RadioButton farthingHallRadio;
        private System.Windows.Forms.RadioButton pikeHallRadio;
        private System.Windows.Forms.RadioButton allenHallRadio;
        private System.Windows.Forms.GroupBox mealPlanGroup;
        private System.Windows.Forms.RadioButton unlimitedRadio;
        private System.Windows.Forms.RadioButton fourteenMealsRadio;
        private System.Windows.Forms.RadioButton sevenMealsRadio;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

