namespace SınavNotlarıHesaplama
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
            radioAddition = new RadioButton();
            radioSubtraction = new RadioButton();
            radioMultiplication = new RadioButton();
            radioDivision = new RadioButton();
            labNumber1 = new Label();
            labNumber2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            tbxResult = new TextBox();
            labResult = new Label();
            tbxNumber2 = new TextBox();
            tbxNumber1 = new TextBox();
            btnClear = new Button();
            btnCalculate = new Button();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // radioAddition
            // 
            radioAddition.AutoSize = true;
            radioAddition.Location = new Point(33, 55);
            radioAddition.Name = "radioAddition";
            radioAddition.Size = new Size(106, 29);
            radioAddition.TabIndex = 0;
            radioAddition.TabStop = true;
            radioAddition.Text = "Addition";
            radioAddition.UseVisualStyleBackColor = true;
            radioAddition.CheckedChanged += radioAddition_CheckedChanged;
            // 
            // radioSubtraction
            // 
            radioSubtraction.AutoSize = true;
            radioSubtraction.Location = new Point(33, 90);
            radioSubtraction.Name = "radioSubtraction";
            radioSubtraction.Size = new Size(128, 29);
            radioSubtraction.TabIndex = 1;
            radioSubtraction.TabStop = true;
            radioSubtraction.Text = "Subtraction";
            radioSubtraction.UseVisualStyleBackColor = true;
            radioSubtraction.CheckedChanged += radioSubtraction_CheckedChanged;
            // 
            // radioMultiplication
            // 
            radioMultiplication.AutoSize = true;
            radioMultiplication.Location = new Point(33, 125);
            radioMultiplication.Name = "radioMultiplication";
            radioMultiplication.Size = new Size(144, 29);
            radioMultiplication.TabIndex = 2;
            radioMultiplication.TabStop = true;
            radioMultiplication.Text = "Multiplication";
            radioMultiplication.UseVisualStyleBackColor = true;
            radioMultiplication.CheckedChanged += radioMultiplication_CheckedChanged;
            // 
            // radioDivision
            // 
            radioDivision.AutoSize = true;
            radioDivision.Location = new Point(33, 160);
            radioDivision.Name = "radioDivision";
            radioDivision.Size = new Size(100, 29);
            radioDivision.TabIndex = 3;
            radioDivision.TabStop = true;
            radioDivision.Text = "Division";
            radioDivision.UseVisualStyleBackColor = true;
            radioDivision.CheckedChanged += radioDivision_CheckedChanged;
            // 
            // labNumber1
            // 
            labNumber1.AutoSize = true;
            labNumber1.Location = new Point(24, 59);
            labNumber1.Name = "labNumber1";
            labNumber1.Size = new Size(92, 25);
            labNumber1.TabIndex = 4;
            labNumber1.Text = "Number 1";
            // 
            // labNumber2
            // 
            labNumber2.AutoSize = true;
            labNumber2.Location = new Point(24, 138);
            labNumber2.Name = "labNumber2";
            labNumber2.Size = new Size(92, 25);
            labNumber2.TabIndex = 5;
            labNumber2.Text = "Number 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxResult);
            groupBox1.Controls.Add(labResult);
            groupBox1.Controls.Add(tbxNumber2);
            groupBox1.Controls.Add(tbxNumber1);
            groupBox1.Controls.Add(labNumber1);
            groupBox1.Controls.Add(labNumber2);
            groupBox1.Location = new Point(55, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 316);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numbers";
            // 
            // tbxResult
            // 
            tbxResult.Location = new Point(137, 207);
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.Size = new Size(150, 31);
            tbxResult.TabIndex = 9;
            // 
            // labResult
            // 
            labResult.AutoSize = true;
            labResult.Location = new Point(24, 213);
            labResult.Name = "labResult";
            labResult.Size = new Size(59, 25);
            labResult.TabIndex = 8;
            labResult.Text = "Result";
            // 
            // tbxNumber2
            // 
            tbxNumber2.Location = new Point(137, 135);
            tbxNumber2.Name = "tbxNumber2";
            tbxNumber2.Size = new Size(150, 31);
            tbxNumber2.TabIndex = 7;
            tbxNumber2.TextChanged += textBox2_TextChanged;
            // 
            // tbxNumber1
            // 
            tbxNumber1.Location = new Point(137, 55);
            tbxNumber1.Name = "tbxNumber1";
            tbxNumber1.Size = new Size(150, 31);
            tbxNumber1.TabIndex = 6;
            tbxNumber1.TextChanged += textBox1_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(517, 471);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(269, 471);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Enter";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioAddition);
            groupBox2.Controls.Add(radioSubtraction);
            groupBox2.Controls.Add(radioDivision);
            groupBox2.Controls.Add(radioMultiplication);
            groupBox2.Location = new Point(527, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 316);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operations";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.Crimson;
            panel1.Location = new Point(2, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 114);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(240, 28);
            label3.Name = "label3";
            label3.Size = new Size(459, 46);
            label3.TabIndex = 0;
            label3.Text = "BASIC CALCULATOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 538);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "4 işlem zamazingo";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioAddition;
        private RadioButton radioSubtraction;
        private RadioButton radioMultiplication;
        private RadioButton radioDivision;
        private Label labNumber1;
        private Label labNumber2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private TextBox tbxNumber2;
        private TextBox tbxNumber1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label3;
        private Button btnClear;
        private Button btnCalculate;
        private TextBox tbxResult;
        private Label labResult;
    }
}