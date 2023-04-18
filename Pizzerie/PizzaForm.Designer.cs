namespace Pizzerie
{
    partial class PizzaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.margeritaRButton = new System.Windows.Forms.RadioButton();
            this.prosciuttoRButton = new System.Windows.Forms.RadioButton();
            this.capriciosaRButton = new System.Windows.Forms.RadioButton();
            this.carbonaraRButton = new System.Windows.Forms.RadioButton();
            this.pepperoniRButton = new System.Windows.Forms.RadioButton();
            this.pizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.largeRButton = new System.Windows.Forms.RadioButton();
            this.mediumRButton = new System.Windows.Forms.RadioButton();
            this.smallRButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.tomatoCBox = new System.Windows.Forms.CheckBox();
            this.mushroomCBox = new System.Windows.Forms.CheckBox();
            this.greenPepperCBox = new System.Windows.Forms.CheckBox();
            this.blackOlivesCBox = new System.Windows.Forms.CheckBox();
            this.toppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pizzaGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.toppingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(205, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Hut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // margeritaRButton
            // 
            this.margeritaRButton.AutoSize = true;
            this.margeritaRButton.Location = new System.Drawing.Point(6, 25);
            this.margeritaRButton.Name = "margeritaRButton";
            this.margeritaRButton.Size = new System.Drawing.Size(101, 24);
            this.margeritaRButton.TabIndex = 0;
            this.margeritaRButton.TabStop = true;
            this.margeritaRButton.Text = "Margerita";
            this.margeritaRButton.UseVisualStyleBackColor = true;
            // 
            // prosciuttoRButton
            // 
            this.prosciuttoRButton.AutoSize = true;
            this.prosciuttoRButton.Location = new System.Drawing.Point(6, 55);
            this.prosciuttoRButton.Name = "prosciuttoRButton";
            this.prosciuttoRButton.Size = new System.Drawing.Size(152, 24);
            this.prosciuttoRButton.TabIndex = 1;
            this.prosciuttoRButton.TabStop = true;
            this.prosciuttoRButton.Text = "Prosciutto Crudo";
            this.prosciuttoRButton.UseVisualStyleBackColor = true;
            // 
            // capriciosaRButton
            // 
            this.capriciosaRButton.AutoSize = true;
            this.capriciosaRButton.Location = new System.Drawing.Point(6, 85);
            this.capriciosaRButton.Name = "capriciosaRButton";
            this.capriciosaRButton.Size = new System.Drawing.Size(108, 24);
            this.capriciosaRButton.TabIndex = 2;
            this.capriciosaRButton.TabStop = true;
            this.capriciosaRButton.Text = "Capriciosa";
            this.capriciosaRButton.UseVisualStyleBackColor = true;
            // 
            // carbonaraRButton
            // 
            this.carbonaraRButton.AutoSize = true;
            this.carbonaraRButton.Location = new System.Drawing.Point(6, 116);
            this.carbonaraRButton.Name = "carbonaraRButton";
            this.carbonaraRButton.Size = new System.Drawing.Size(109, 24);
            this.carbonaraRButton.TabIndex = 3;
            this.carbonaraRButton.TabStop = true;
            this.carbonaraRButton.Text = "Carbonara";
            this.carbonaraRButton.UseVisualStyleBackColor = true;
            // 
            // pepperoniRButton
            // 
            this.pepperoniRButton.AutoSize = true;
            this.pepperoniRButton.Location = new System.Drawing.Point(6, 146);
            this.pepperoniRButton.Name = "pepperoniRButton";
            this.pepperoniRButton.Size = new System.Drawing.Size(106, 24);
            this.pepperoniRButton.TabIndex = 4;
            this.pepperoniRButton.TabStop = true;
            this.pepperoniRButton.Text = "Pepperoni";
            this.pepperoniRButton.UseVisualStyleBackColor = true;
            // 
            // pizzaGroupBox
            // 
            this.pizzaGroupBox.Controls.Add(this.pepperoniRButton);
            this.pizzaGroupBox.Controls.Add(this.carbonaraRButton);
            this.pizzaGroupBox.Controls.Add(this.capriciosaRButton);
            this.pizzaGroupBox.Controls.Add(this.prosciuttoRButton);
            this.pizzaGroupBox.Controls.Add(this.margeritaRButton);
            this.pizzaGroupBox.Location = new System.Drawing.Point(12, 186);
            this.pizzaGroupBox.Name = "pizzaGroupBox";
            this.pizzaGroupBox.Size = new System.Drawing.Size(217, 181);
            this.pizzaGroupBox.TabIndex = 0;
            this.pizzaGroupBox.TabStop = false;
            this.pizzaGroupBox.Text = "Pizza";
            // 
            // largeRButton
            // 
            this.largeRButton.AutoSize = true;
            this.largeRButton.Location = new System.Drawing.Point(7, 26);
            this.largeRButton.Name = "largeRButton";
            this.largeRButton.Size = new System.Drawing.Size(75, 24);
            this.largeRButton.TabIndex = 0;
            this.largeRButton.TabStop = true;
            this.largeRButton.Text = "Large";
            this.largeRButton.UseVisualStyleBackColor = true;
            // 
            // mediumRButton
            // 
            this.mediumRButton.AutoSize = true;
            this.mediumRButton.Location = new System.Drawing.Point(7, 57);
            this.mediumRButton.Name = "mediumRButton";
            this.mediumRButton.Size = new System.Drawing.Size(90, 24);
            this.mediumRButton.TabIndex = 1;
            this.mediumRButton.TabStop = true;
            this.mediumRButton.Text = "Medium";
            this.mediumRButton.UseVisualStyleBackColor = true;
            // 
            // smallRButton
            // 
            this.smallRButton.AutoSize = true;
            this.smallRButton.Location = new System.Drawing.Point(7, 87);
            this.smallRButton.Name = "smallRButton";
            this.smallRButton.Size = new System.Drawing.Size(73, 24);
            this.smallRButton.TabIndex = 2;
            this.smallRButton.TabStop = true;
            this.smallRButton.Text = "Small";
            this.smallRButton.UseVisualStyleBackColor = true;
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.smallRButton);
            this.sizeGroupBox.Controls.Add(this.mediumRButton);
            this.sizeGroupBox.Controls.Add(this.largeRButton);
            this.sizeGroupBox.Location = new System.Drawing.Point(262, 186);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(170, 130);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // tomatoCBox
            // 
            this.tomatoCBox.AutoSize = true;
            this.tomatoCBox.Location = new System.Drawing.Point(6, 25);
            this.tomatoCBox.Name = "tomatoCBox";
            this.tomatoCBox.Size = new System.Drawing.Size(89, 24);
            this.tomatoCBox.TabIndex = 0;
            this.tomatoCBox.Text = "Tomato";
            this.tomatoCBox.UseVisualStyleBackColor = true;
            // 
            // mushroomCBox
            // 
            this.mushroomCBox.AutoSize = true;
            this.mushroomCBox.Location = new System.Drawing.Point(6, 54);
            this.mushroomCBox.Name = "mushroomCBox";
            this.mushroomCBox.Size = new System.Drawing.Size(110, 24);
            this.mushroomCBox.TabIndex = 1;
            this.mushroomCBox.Text = "Mushroom";
            this.mushroomCBox.UseVisualStyleBackColor = true;
            // 
            // greenPepperCBox
            // 
            this.greenPepperCBox.AutoSize = true;
            this.greenPepperCBox.Location = new System.Drawing.Point(6, 84);
            this.greenPepperCBox.Name = "greenPepperCBox";
            this.greenPepperCBox.Size = new System.Drawing.Size(135, 24);
            this.greenPepperCBox.TabIndex = 2;
            this.greenPepperCBox.Text = "Green Pepper";
            this.greenPepperCBox.UseVisualStyleBackColor = true;
            // 
            // blackOlivesCBox
            // 
            this.blackOlivesCBox.AutoSize = true;
            this.blackOlivesCBox.Location = new System.Drawing.Point(6, 114);
            this.blackOlivesCBox.Name = "blackOlivesCBox";
            this.blackOlivesCBox.Size = new System.Drawing.Size(120, 24);
            this.blackOlivesCBox.TabIndex = 3;
            this.blackOlivesCBox.Text = "Black Olives";
            this.blackOlivesCBox.UseVisualStyleBackColor = true;
            // 
            // toppingsGroupBox
            // 
            this.toppingsGroupBox.Controls.Add(this.blackOlivesCBox);
            this.toppingsGroupBox.Controls.Add(this.greenPepperCBox);
            this.toppingsGroupBox.Controls.Add(this.mushroomCBox);
            this.toppingsGroupBox.Controls.Add(this.tomatoCBox);
            this.toppingsGroupBox.Location = new System.Drawing.Point(461, 186);
            this.toppingsGroupBox.Name = "toppingsGroupBox";
            this.toppingsGroupBox.Size = new System.Drawing.Size(200, 153);
            this.toppingsGroupBox.TabIndex = 3;
            this.toppingsGroupBox.TabStop = false;
            this.toppingsGroupBox.Text = "Extra Toppings";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Maroon;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doneButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.doneButton.Location = new System.Drawing.Point(461, 389);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(180, 59);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose your pizza:";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.toppingsGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pizzaGroupBox);
            this.Name = "PizzaForm";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.PizzaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pizzaGroupBox.ResumeLayout(false);
            this.pizzaGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.toppingsGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton margeritaRButton;
        private System.Windows.Forms.RadioButton prosciuttoRButton;
        private System.Windows.Forms.RadioButton capriciosaRButton;
        private System.Windows.Forms.RadioButton carbonaraRButton;
        private System.Windows.Forms.RadioButton pepperoniRButton;
        private System.Windows.Forms.GroupBox pizzaGroupBox;
        private System.Windows.Forms.RadioButton largeRButton;
        private System.Windows.Forms.RadioButton mediumRButton;
        private System.Windows.Forms.RadioButton smallRButton;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.CheckBox tomatoCBox;
        private System.Windows.Forms.CheckBox mushroomCBox;
        private System.Windows.Forms.CheckBox greenPepperCBox;
        private System.Windows.Forms.CheckBox blackOlivesCBox;
        private System.Windows.Forms.GroupBox toppingsGroupBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label3;
    }
}

