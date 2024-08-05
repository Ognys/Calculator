namespace Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NumOne = new TextBox();
            Sum = new Button();
            Sub = new Button();
            Mul = new Button();
            Div = new Button();
            Cos = new Button();
            Sin = new Button();
            AddField = new Button();
            Result = new TextBox();
            NumTwo = new TextBox();
            SuspendLayout();
            // 
            // NumOne
            // 
            NumOne.Location = new Point(13, 45);
            NumOne.Name = "NumOne";
            NumOne.Size = new Size(100, 21);
            NumOne.TabIndex = 0;
            // 
            // Sum
            // 
            Sum.Location = new Point(38, 159);
            Sum.Name = "Sum";
            Sum.Size = new Size(75, 23);
            Sum.TabIndex = 2;
            Sum.Text = "Сложение";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(38, 210);
            Sub.Name = "Sub";
            Sub.Size = new Size(75, 23);
            Sub.TabIndex = 4;
            Sub.Text = "Вычитание";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Mul
            // 
            Mul.Location = new Point(139, 159);
            Mul.Name = "Mul";
            Mul.Size = new Size(75, 23);
            Mul.TabIndex = 5;
            Mul.Text = "Умножение";
            Mul.UseVisualStyleBackColor = true;
            Mul.Click += Mul_Click;
            // 
            // Div
            // 
            Div.Location = new Point(139, 210);
            Div.Name = "Div";
            Div.Size = new Size(75, 23);
            Div.TabIndex = 6;
            Div.Text = "Деление";
            Div.UseVisualStyleBackColor = true;
            Div.Click += Div_Click;
            // 
            // Cos
            // 
            Cos.Location = new Point(241, 159);
            Cos.Name = "Cos";
            Cos.Size = new Size(75, 23);
            Cos.TabIndex = 7;
            Cos.Text = "Косинус";
            Cos.UseVisualStyleBackColor = true;
            Cos.Click += Cos_Click;
            // 
            // Sin
            // 
            Sin.Location = new Point(241, 210);
            Sin.Name = "Sin";
            Sin.Size = new Size(75, 23);
            Sin.TabIndex = 8;
            Sin.Text = "Синус";
            Sin.UseVisualStyleBackColor = true;
            Sin.Click += Sin_Click;
            // 
            // AddField
            // 
            AddField.Location = new Point(347, 12);
            AddField.Name = "AddField";
            AddField.Size = new Size(25, 23);
            AddField.TabIndex = 9;
            AddField.Text = "+";
            AddField.UseVisualStyleBackColor = true;
            AddField.Click += AddField_Click;
            // 
            // Result
            // 
            Result.Location = new Point(125, 307);
            Result.Name = "Result";
            Result.Size = new Size(100, 21);
            Result.TabIndex = 3;
            // 
            // NumTwo
            // 
            NumTwo.Location = new Point(229, 45);
            NumTwo.Name = "NumTwo";
            NumTwo.Size = new Size(100, 21);
            NumTwo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 450);
            Controls.Add(AddField);
            Controls.Add(Sin);
            Controls.Add(Cos);
            Controls.Add(Div);
            Controls.Add(Mul);
            Controls.Add(Sub);
            Controls.Add(Result);
            Controls.Add(Sum);
            Controls.Add(NumTwo);
            Controls.Add(NumOne);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.MenuText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Сalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumOne;
        private Button Sum;
        private Button Sub;
        private Button Mul;
        private Button Div;
        private Button Cos;
        private Button Sin;
        private Button AddField;
        private TextBox Result;
        private TextBox NumTwo;
    }
}
