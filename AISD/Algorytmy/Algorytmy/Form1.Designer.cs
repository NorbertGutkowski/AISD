namespace Algorytmy
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            button6 = new Button();
            label2 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(125, 293);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 0;
            button1.Text = "BS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 79);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 46);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 184);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 46);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 151);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Wynik:";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(263, 293);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 4;
            button2.Text = "SS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(391, 293);
            button3.Name = "button3";
            button3.Size = new Size(94, 50);
            button3.TabIndex = 5;
            button3.Text = "IS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(517, 293);
            button4.Name = "button4";
            button4.Size = new Size(94, 50);
            button4.TabIndex = 6;
            button4.Text = "MS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(634, 293);
            button5.Name = "button5";
            button5.Size = new Size(94, 50);
            button5.TabIndex = 7;
            button5.Text = "QS";
            button5.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(391, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Losowe liczby";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(557, 79);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 46);
            textBox3.TabIndex = 9;
            // 
            // button6
            // 
            button6.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(600, 148);
            button6.Name = "button6";
            button6.Size = new Size(111, 33);
            button6.TabIndex = 10;
            button6.Text = "GENERUJ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 210);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 11;
            label2.Text = "Czas:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(586, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Button button6;
        private Label label2;
        private TextBox textBox4;
    }
}