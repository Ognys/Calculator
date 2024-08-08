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
            ClearLabel = new Button();
            SetPlusMinus = new Button();
            Percent = new Button();
            OperDiv = new Button();
            NumSeven = new Button();
            NumEight = new Button();
            NumNine = new Button();
            OperMul = new Button();
            NumFour = new Button();
            NumFive = new Button();
            NumSix = new Button();
            OperSub = new Button();
            NumOne = new Button();
            NumTwo = new Button();
            NumThree = new Button();
            NumZero = new Button();
            NumDec = new Button();
            OperSum = new Button();
            OperEqu = new Button();
            InputPanel = new Label();
            SuspendLayout();
            // 
            // ClearLabel
            // 
            ClearLabel.BackColor = SystemColors.ButtonShadow;
            ClearLabel.FlatStyle = FlatStyle.Popup;
            ClearLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClearLabel.Location = new Point(12, 105);
            ClearLabel.Name = "ClearLabel";
            ClearLabel.Size = new Size(55, 49);
            ClearLabel.TabIndex = 0;
            ClearLabel.Text = "AC";
            ClearLabel.UseVisualStyleBackColor = false;
            ClearLabel.Click += ClearLabel_Click;
            // 
            // SetPlusMinus
            // 
            SetPlusMinus.BackColor = SystemColors.ButtonShadow;
            SetPlusMinus.FlatStyle = FlatStyle.Popup;
            SetPlusMinus.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SetPlusMinus.Location = new Point(73, 105);
            SetPlusMinus.Name = "SetPlusMinus";
            SetPlusMinus.Size = new Size(55, 49);
            SetPlusMinus.TabIndex = 1;
            SetPlusMinus.Text = "+/-";
            SetPlusMinus.UseVisualStyleBackColor = false;
            SetPlusMinus.Click += SetPlusMinus_Click;
            // 
            // Percent
            // 
            Percent.BackColor = SystemColors.ButtonShadow;
            Percent.FlatStyle = FlatStyle.Popup;
            Percent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Percent.Location = new Point(134, 104);
            Percent.Name = "Percent";
            Percent.Size = new Size(55, 49);
            Percent.TabIndex = 2;
            Percent.Text = "%";
            Percent.UseVisualStyleBackColor = false;
            Percent.Click += Percent_Click;
            // 
            // OperDiv
            // 
            OperDiv.BackColor = Color.Orange;
            OperDiv.FlatStyle = FlatStyle.Popup;
            OperDiv.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OperDiv.ForeColor = Color.White;
            OperDiv.Location = new Point(195, 105);
            OperDiv.Name = "OperDiv";
            OperDiv.Size = new Size(55, 49);
            OperDiv.TabIndex = 3;
            OperDiv.Text = "/";
            OperDiv.UseVisualStyleBackColor = false;
            // 
            // NumSeven
            // 
            NumSeven.BackColor = SystemColors.ControlDarkDark;
            NumSeven.FlatStyle = FlatStyle.Popup;
            NumSeven.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumSeven.Location = new Point(12, 160);
            NumSeven.Name = "NumSeven";
            NumSeven.Size = new Size(55, 49);
            NumSeven.TabIndex = 4;
            NumSeven.Text = "7";
            NumSeven.UseVisualStyleBackColor = false;
            NumSeven.Click += NumSeven_Click;
            // 
            // NumEight
            // 
            NumEight.BackColor = SystemColors.ControlDarkDark;
            NumEight.FlatStyle = FlatStyle.Popup;
            NumEight.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumEight.Location = new Point(73, 160);
            NumEight.Name = "NumEight";
            NumEight.Size = new Size(55, 49);
            NumEight.TabIndex = 5;
            NumEight.Text = "8";
            NumEight.UseVisualStyleBackColor = false;
            NumEight.Click += NumEight_Click;
            // 
            // NumNine
            // 
            NumNine.BackColor = SystemColors.ControlDarkDark;
            NumNine.FlatStyle = FlatStyle.Popup;
            NumNine.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumNine.Location = new Point(134, 160);
            NumNine.Name = "NumNine";
            NumNine.Size = new Size(55, 49);
            NumNine.TabIndex = 6;
            NumNine.Text = "9";
            NumNine.UseVisualStyleBackColor = false;
            NumNine.Click += NumNine_Click;
            // 
            // OperMul
            // 
            OperMul.BackColor = Color.Orange;
            OperMul.FlatStyle = FlatStyle.Popup;
            OperMul.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OperMul.ForeColor = Color.White;
            OperMul.Location = new Point(195, 160);
            OperMul.Name = "OperMul";
            OperMul.Size = new Size(55, 49);
            OperMul.TabIndex = 7;
            OperMul.Text = "x";
            OperMul.UseVisualStyleBackColor = false;
            // 
            // NumFour
            // 
            NumFour.BackColor = SystemColors.ControlDarkDark;
            NumFour.FlatStyle = FlatStyle.Popup;
            NumFour.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumFour.Location = new Point(12, 215);
            NumFour.Name = "NumFour";
            NumFour.Size = new Size(55, 49);
            NumFour.TabIndex = 8;
            NumFour.Text = "4";
            NumFour.UseVisualStyleBackColor = false;
            NumFour.Click += NumFour_Click;
            // 
            // NumFive
            // 
            NumFive.BackColor = SystemColors.ControlDarkDark;
            NumFive.FlatStyle = FlatStyle.Popup;
            NumFive.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumFive.Location = new Point(73, 215);
            NumFive.Name = "NumFive";
            NumFive.Size = new Size(55, 49);
            NumFive.TabIndex = 9;
            NumFive.Text = "5";
            NumFive.UseVisualStyleBackColor = false;
            NumFive.Click += NumFive_Click;
            // 
            // NumSix
            // 
            NumSix.BackColor = SystemColors.ControlDarkDark;
            NumSix.FlatStyle = FlatStyle.Popup;
            NumSix.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumSix.Location = new Point(134, 215);
            NumSix.Name = "NumSix";
            NumSix.Size = new Size(55, 49);
            NumSix.TabIndex = 10;
            NumSix.Text = "6";
            NumSix.UseVisualStyleBackColor = false;
            NumSix.Click += NumSix_Click;
            // 
            // OperSub
            // 
            OperSub.BackColor = Color.Orange;
            OperSub.FlatStyle = FlatStyle.Popup;
            OperSub.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OperSub.ForeColor = Color.White;
            OperSub.Location = new Point(195, 215);
            OperSub.Name = "OperSub";
            OperSub.Size = new Size(55, 49);
            OperSub.TabIndex = 11;
            OperSub.Text = "-";
            OperSub.UseVisualStyleBackColor = false;
            // 
            // NumOne
            // 
            NumOne.BackColor = SystemColors.ControlDarkDark;
            NumOne.FlatStyle = FlatStyle.Popup;
            NumOne.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumOne.Location = new Point(12, 270);
            NumOne.Name = "NumOne";
            NumOne.Size = new Size(55, 49);
            NumOne.TabIndex = 12;
            NumOne.Text = "1";
            NumOne.UseVisualStyleBackColor = false;
            NumOne.Click += NumOne_Click;
            // 
            // NumTwo
            // 
            NumTwo.BackColor = SystemColors.ControlDarkDark;
            NumTwo.FlatStyle = FlatStyle.Popup;
            NumTwo.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumTwo.Location = new Point(73, 270);
            NumTwo.Name = "NumTwo";
            NumTwo.Size = new Size(55, 49);
            NumTwo.TabIndex = 13;
            NumTwo.Text = "2";
            NumTwo.UseVisualStyleBackColor = false;
            NumTwo.Click += NumTwo_Click;
            // 
            // NumThree
            // 
            NumThree.BackColor = SystemColors.ControlDarkDark;
            NumThree.FlatStyle = FlatStyle.Popup;
            NumThree.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumThree.Location = new Point(134, 270);
            NumThree.Name = "NumThree";
            NumThree.Size = new Size(55, 49);
            NumThree.TabIndex = 14;
            NumThree.Text = "3";
            NumThree.UseVisualStyleBackColor = false;
            NumThree.Click += NumThree_Click;
            // 
            // NumZero
            // 
            NumZero.BackColor = SystemColors.ControlDarkDark;
            NumZero.FlatStyle = FlatStyle.Popup;
            NumZero.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumZero.Location = new Point(12, 325);
            NumZero.Name = "NumZero";
            NumZero.Size = new Size(116, 49);
            NumZero.TabIndex = 15;
            NumZero.Text = "0";
            NumZero.UseVisualStyleBackColor = false;
            NumZero.Click += NumZero_Click;
            // 
            // NumDec
            // 
            NumDec.BackColor = SystemColors.ControlDarkDark;
            NumDec.FlatStyle = FlatStyle.Popup;
            NumDec.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumDec.Location = new Point(134, 325);
            NumDec.Name = "NumDec";
            NumDec.Size = new Size(55, 49);
            NumDec.TabIndex = 16;
            NumDec.Text = ",";
            NumDec.UseVisualStyleBackColor = false;
            // 
            // OperSum
            // 
            OperSum.BackColor = Color.Orange;
            OperSum.FlatStyle = FlatStyle.Popup;
            OperSum.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OperSum.ForeColor = Color.White;
            OperSum.Location = new Point(195, 270);
            OperSum.Name = "OperSum";
            OperSum.Size = new Size(55, 49);
            OperSum.TabIndex = 17;
            OperSum.Text = "+";
            OperSum.UseVisualStyleBackColor = false;
            OperSum.Click += OperSum_Click;
            // 
            // OperEqu
            // 
            OperEqu.BackColor = Color.Orange;
            OperEqu.FlatStyle = FlatStyle.Popup;
            OperEqu.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OperEqu.ForeColor = Color.White;
            OperEqu.Location = new Point(195, 325);
            OperEqu.Name = "OperEqu";
            OperEqu.Size = new Size(55, 49);
            OperEqu.TabIndex = 18;
            OperEqu.Text = "=";
            OperEqu.UseVisualStyleBackColor = false;
            OperEqu.Click += OperEqu_Click;
            // 
            // InputPanel
            // 
            InputPanel.FlatStyle = FlatStyle.Popup;
            InputPanel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputPanel.ForeColor = Color.White;
            InputPanel.ImageAlign = ContentAlignment.BottomRight;
            InputPanel.Location = new Point(-2, 9);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(252, 81);
            InputPanel.TabIndex = 19;
            InputPanel.Text = "0";
            InputPanel.TextAlign = ContentAlignment.BottomRight;
            InputPanel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(265, 407);
            Controls.Add(InputPanel);
            Controls.Add(OperEqu);
            Controls.Add(OperSum);
            Controls.Add(NumDec);
            Controls.Add(NumZero);
            Controls.Add(NumThree);
            Controls.Add(NumTwo);
            Controls.Add(NumOne);
            Controls.Add(OperSub);
            Controls.Add(NumSix);
            Controls.Add(NumFive);
            Controls.Add(NumFour);
            Controls.Add(OperMul);
            Controls.Add(NumNine);
            Controls.Add(NumEight);
            Controls.Add(NumSeven);
            Controls.Add(OperDiv);
            Controls.Add(Percent);
            Controls.Add(SetPlusMinus);
            Controls.Add(ClearLabel);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.MenuText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сalculator";
            ResumeLayout(false);
        }

        #endregion

        private Button ClearLabel;
        private Button SetPlusMinus;
        private Button Percent;
        private Button OperDiv;
        private Button NumSeven;
        private Button NumEight;
        private Button NumNine;
        private Button OperMul;
        private Button NumFour;
        private Button NumFive;
        private Button NumSix;
        private Button OperSub;
        private Button NumOne;
        private Button NumTwo;
        private Button NumThree;
        private Button NumZero;
        private Button NumDec;
        private Button OperSum;
        private Button OperEqu;
        private Label InputPanel;
    }
}
