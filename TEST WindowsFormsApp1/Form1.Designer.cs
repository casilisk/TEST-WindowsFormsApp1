namespace TEST_WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdultBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ChildBox = new System.Windows.Forms.TextBox();
            this.SeniorBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.RefundBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Adult";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdultBox
            // 
            this.AdultBox.Location = new System.Drawing.Point(260, 155);
            this.AdultBox.Name = "AdultBox";
            this.AdultBox.Size = new System.Drawing.Size(227, 20);
            this.AdultBox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Child";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 74);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Senior";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(593, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(243, 91);
            this.button5.TabIndex = 5;
            this.button5.Text = "Checkout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChildBox
            // 
            this.ChildBox.Location = new System.Drawing.Point(255, 261);
            this.ChildBox.Name = "ChildBox";
            this.ChildBox.Size = new System.Drawing.Size(231, 20);
            this.ChildBox.TabIndex = 6;
            // 
            // SeniorBox
            // 
            this.SeniorBox.Location = new System.Drawing.Point(263, 366);
            this.SeniorBox.Name = "SeniorBox";
            this.SeniorBox.Size = new System.Drawing.Size(223, 20);
            this.SeniorBox.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(592, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 103);
            this.button6.TabIndex = 8;
            this.button6.Text = "Refund";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // RefundBox
            // 
            this.RefundBox.Location = new System.Drawing.Point(859, 94);
            this.RefundBox.Name = "RefundBox";
            this.RefundBox.Size = new System.Drawing.Size(132, 20);
            this.RefundBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 468);
            this.Controls.Add(this.RefundBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.SeniorBox);
            this.Controls.Add(this.ChildBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AdultBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ticket Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AdultBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox ChildBox;
        private System.Windows.Forms.TextBox SeniorBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox RefundBox;
    }
}

