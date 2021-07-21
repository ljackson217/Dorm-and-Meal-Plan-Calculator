
namespace Dorm_and_Meal_Plan_Calculator
{
    partial class subtotalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hallLabel = new System.Windows.Forms.Label();
            this.hallOutput = new System.Windows.Forms.Label();
            this.mealPlanLabel = new System.Windows.Forms.Label();
            this.mealPlanOutput = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Location = new System.Drawing.Point(31, 21);
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(31, 15);
            this.hallLabel.TabIndex = 0;
            this.hallLabel.Text = "Hall:";
            // 
            // hallOutput
            // 
            this.hallOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hallOutput.Location = new System.Drawing.Point(108, 20);
            this.hallOutput.Name = "hallOutput";
            this.hallOutput.Size = new System.Drawing.Size(131, 23);
            this.hallOutput.TabIndex = 1;
            // 
            // mealPlanLabel
            // 
            this.mealPlanLabel.AutoSize = true;
            this.mealPlanLabel.Location = new System.Drawing.Point(31, 56);
            this.mealPlanLabel.Name = "mealPlanLabel";
            this.mealPlanLabel.Size = new System.Drawing.Size(62, 15);
            this.mealPlanLabel.TabIndex = 2;
            this.mealPlanLabel.Text = "Meal Plan:";
            // 
            // mealPlanOutput
            // 
            this.mealPlanOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mealPlanOutput.Location = new System.Drawing.Point(108, 55);
            this.mealPlanOutput.Name = "mealPlanOutput";
            this.mealPlanOutput.Size = new System.Drawing.Size(131, 23);
            this.mealPlanOutput.TabIndex = 3;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(31, 91);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(54, 15);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subtotalOutput.Location = new System.Drawing.Point(108, 90);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(131, 23);
            this.subtotalOutput.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(83, 139);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // subtotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 189);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.mealPlanOutput);
            this.Controls.Add(this.mealPlanLabel);
            this.Controls.Add(this.hallOutput);
            this.Controls.Add(this.hallLabel);
            this.Name = "subtotalForm";
            this.Text = "Subtotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hallLabel;
        private System.Windows.Forms.Label mealPlanLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label hallOutput;
        public System.Windows.Forms.Label mealPlanOutput;
        public System.Windows.Forms.Label subtotalOutput;
    }
}