namespace Calculator
{
    partial class Calculator
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
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            NegativeBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            ModuloBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI Black", 20F);
            TxtBox.Location = new Point(12, 12);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(432, 44);
            TxtBox.TabIndex = 4;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(12, 71);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(75, 75);
            SevenBtn.TabIndex = 5;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(12, 152);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(75, 75);
            FourBtn.TabIndex = 6;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F);
            OneBtn.Location = new Point(12, 233);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(75, 75);
            OneBtn.TabIndex = 7;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(12, 314);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(75, 75);
            ZeroBtn.TabIndex = 8;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F);
            DotBtn.Location = new Point(93, 314);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(75, 75);
            DotBtn.TabIndex = 12;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(93, 233);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(75, 75);
            TwoBtn.TabIndex = 11;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(93, 152);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(75, 75);
            FiveBtn.TabIndex = 10;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(93, 71);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(75, 75);
            EightBtn.TabIndex = 9;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F);
            EqualBtn.Location = new Point(174, 314);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(75, 75);
            EqualBtn.TabIndex = 16;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(174, 233);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(75, 75);
            ThreeBtn.TabIndex = 15;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(174, 152);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(75, 75);
            SixBtn.TabIndex = 14;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(174, 71);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(75, 75);
            NineBtn.TabIndex = 13;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // NegativeBtn
            // 
            NegativeBtn.Font = new Font("Segoe UI", 12F);
            NegativeBtn.Location = new Point(288, 314);
            NegativeBtn.Name = "NegativeBtn";
            NegativeBtn.Size = new Size(75, 75);
            NegativeBtn.TabIndex = 20;
            NegativeBtn.Text = "-/+";
            NegativeBtn.UseVisualStyleBackColor = true;
            NegativeBtn.Click += NegativeBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 12F);
            DivideBtn.Location = new Point(288, 233);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(75, 75);
            DivideBtn.TabIndex = 19;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F);
            MinusBtn.Location = new Point(288, 152);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(75, 75);
            MinusBtn.TabIndex = 18;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // ModuloBtn
            // 
            ModuloBtn.Font = new Font("Segoe UI", 12F);
            ModuloBtn.Location = new Point(369, 314);
            ModuloBtn.Name = "ModuloBtn";
            ModuloBtn.Size = new Size(75, 75);
            ModuloBtn.TabIndex = 24;
            ModuloBtn.Text = "%";
            ModuloBtn.UseVisualStyleBackColor = true;
            ModuloBtn.Click += ModuloBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F);
            MultiplyBtn.Location = new Point(369, 233);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(75, 75);
            MultiplyBtn.TabIndex = 23;
            MultiplyBtn.Text = "X";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F);
            PlusBtn.Location = new Point(369, 152);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(75, 75);
            PlusBtn.TabIndex = 22;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(288, 71);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(156, 75);
            ClearBtn.TabIndex = 21;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 400);
            Controls.Add(ModuloBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(NegativeBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Name = "Calculator";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button NegativeBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button ModuloBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button ClearBtn;
    }
}
