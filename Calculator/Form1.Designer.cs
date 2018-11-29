namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.resultDisplay = new System.Windows.Forms.TextBox();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnPow = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnChangeSign = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.BackColor = System.Drawing.Color.White;
            this.resultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultDisplay.Enabled = false;
            this.resultDisplay.Font = new System.Drawing.Font("Mipgost", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultDisplay.ForeColor = System.Drawing.Color.Black;
            this.resultDisplay.Location = new System.Drawing.Point(0, 18);
            this.resultDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.ReadOnly = true;
            this.resultDisplay.Size = new System.Drawing.Size(286, 51);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.Text = "0";
            this.resultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnC.ForeColor = System.Drawing.Color.White;
            this.BtnC.Location = new System.Drawing.Point(0, 87);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(75, 65);
            this.BtnC.TabIndex = 1;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqrt.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSqrt.ForeColor = System.Drawing.Color.White;
            this.BtnSqrt.Location = new System.Drawing.Point(75, 87);
            this.BtnSqrt.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(75, 65);
            this.BtnSqrt.TabIndex = 1;
            this.BtnSqrt.Text = "√";
            this.BtnSqrt.UseVisualStyleBackColor = false;
            this.BtnSqrt.Click += new System.EventHandler(this.Operators_OnClick);
            // 
            // BtnPow
            // 
            this.BtnPow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnPow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnPow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPow.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPow.ForeColor = System.Drawing.Color.White;
            this.BtnPow.Location = new System.Drawing.Point(150, 87);
            this.BtnPow.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPow.Name = "BtnPow";
            this.BtnPow.Size = new System.Drawing.Size(75, 65);
            this.BtnPow.TabIndex = 1;
            this.BtnPow.Text = "x²";
            this.BtnPow.UseVisualStyleBackColor = false;
            this.BtnPow.Click += new System.EventHandler(this.Operators_OnClick);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.BtnDivide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(85)))), ((int)(((byte)(188)))));
            this.BtnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivide.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDivide.ForeColor = System.Drawing.Color.White;
            this.BtnDivide.Location = new System.Drawing.Point(225, 87);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(75, 65);
            this.BtnDivide.TabIndex = 1;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.Operators_OnClick);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeven.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSeven.ForeColor = System.Drawing.Color.White;
            this.BtnSeven.Location = new System.Drawing.Point(0, 152);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(75, 65);
            this.BtnSeven.TabIndex = 1;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = false;
            this.BtnSeven.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnEight.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEight.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEight.ForeColor = System.Drawing.Color.White;
            this.BtnEight.Location = new System.Drawing.Point(75, 152);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(75, 65);
            this.BtnEight.TabIndex = 1;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = false;
            this.BtnEight.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnNine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNine.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNine.ForeColor = System.Drawing.Color.White;
            this.BtnNine.Location = new System.Drawing.Point(150, 152);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(75, 65);
            this.BtnNine.TabIndex = 1;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = false;
            this.BtnNine.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.BtnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(85)))), ((int)(((byte)(188)))));
            this.BtnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMultiply.ForeColor = System.Drawing.Color.White;
            this.BtnMultiply.Location = new System.Drawing.Point(225, 152);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(75, 65);
            this.BtnMultiply.TabIndex = 1;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.Operators_OnClick);
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnFour.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFour.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFour.ForeColor = System.Drawing.Color.White;
            this.BtnFour.Location = new System.Drawing.Point(0, 217);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(75, 65);
            this.BtnFour.TabIndex = 1;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = false;
            this.BtnFour.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnFive.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFive.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFive.ForeColor = System.Drawing.Color.White;
            this.BtnFive.Location = new System.Drawing.Point(75, 217);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(75, 65);
            this.BtnFive.TabIndex = 1;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = false;
            this.BtnFive.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnSix.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSix.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSix.ForeColor = System.Drawing.Color.White;
            this.BtnSix.Location = new System.Drawing.Point(150, 217);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(75, 65);
            this.BtnSix.TabIndex = 1;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = false;
            this.BtnSix.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.BtnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(85)))), ((int)(((byte)(188)))));
            this.BtnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMinus.ForeColor = System.Drawing.Color.White;
            this.BtnMinus.Location = new System.Drawing.Point(225, 217);
            this.BtnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(75, 65);
            this.BtnMinus.TabIndex = 1;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.Operators_OnClick);
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnOne.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOne.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOne.ForeColor = System.Drawing.Color.White;
            this.BtnOne.Location = new System.Drawing.Point(0, 282);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(75, 65);
            this.BtnOne.TabIndex = 1;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwo.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTwo.ForeColor = System.Drawing.Color.White;
            this.BtnTwo.Location = new System.Drawing.Point(75, 282);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(75, 65);
            this.BtnTwo.TabIndex = 1;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnThree.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThree.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnThree.ForeColor = System.Drawing.Color.White;
            this.BtnThree.Location = new System.Drawing.Point(150, 282);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(0);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(75, 65);
            this.BtnThree.TabIndex = 1;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = false;
            this.BtnThree.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(75)))), ((int)(((byte)(182)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(85)))), ((int)(((byte)(188)))));
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(225, 282);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 65);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.Operators_OnClick);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnZero.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZero.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnZero.ForeColor = System.Drawing.Color.White;
            this.BtnZero.Location = new System.Drawing.Point(0, 347);
            this.BtnZero.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(75, 65);
            this.BtnZero.TabIndex = 1;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = false;
            this.BtnZero.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnChangeSign
            // 
            this.BtnChangeSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnChangeSign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnChangeSign.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnChangeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeSign.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChangeSign.ForeColor = System.Drawing.Color.White;
            this.BtnChangeSign.Location = new System.Drawing.Point(75, 347);
            this.BtnChangeSign.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangeSign.Name = "BtnChangeSign";
            this.BtnChangeSign.Size = new System.Drawing.Size(75, 65);
            this.BtnChangeSign.TabIndex = 1;
            this.BtnChangeSign.Text = "±";
            this.BtnChangeSign.UseVisualStyleBackColor = false;
            this.BtnChangeSign.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BtnDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.BtnDot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDot.ForeColor = System.Drawing.Color.White;
            this.BtnDot.Location = new System.Drawing.Point(150, 347);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(75, 65);
            this.BtnDot.TabIndex = 1;
            this.BtnDot.Text = ",";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.Numbers_OnClick);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.BtnEquals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(85)))), ((int)(((byte)(188)))));
            this.BtnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Mipgost", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEquals.ForeColor = System.Drawing.Color.Black;
            this.BtnEquals.Location = new System.Drawing.Point(225, 347);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(74, 65);
            this.BtnEquals.TabIndex = 1;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 411);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnPow);
            this.Controls.Add(this.BtnChangeSign);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.resultDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 18, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultDisplay;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnPow;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnChangeSign;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnEquals;
    }
}

