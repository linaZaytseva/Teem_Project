namespace TeemProject
{
    partial class Form2
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
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.Location = new System.Drawing.Point(28, 34);
            this.btnBreakfast.Margin = new System.Windows.Forms.Padding(4);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(100, 28);
            this.btnBreakfast.TabIndex = 0;
            this.btnBreakfast.Text = "Breakfast";
            this.btnBreakfast.UseVisualStyleBackColor = true;
            this.btnBreakfast.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(163, 34);
            this.btnLunch.Margin = new System.Windows.Forms.Padding(4);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(100, 28);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dinner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Supper";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSupper_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 85);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Afternoon snack\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAfternoonSnack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 187);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnBreakfast);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Eating Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}