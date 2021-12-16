
namespace Calculator.WindowsFormsApp
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
            this.tbScreen = new System.Windows.Forms.TextBox();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbScreen
            // 
            this.tbScreen.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbScreen.Location = new System.Drawing.Point(13, 13);
            this.tbScreen.Name = "tbScreen";
            this.tbScreen.Size = new System.Drawing.Size(514, 70);
            this.tbScreen.TabIndex = 0;
            this.tbScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightGreen;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(117, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(98, 83);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightGreen;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(221, 109);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(98, 83);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightGreen;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(13, 194);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(98, 83);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightGreen;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(117, 194);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(98, 83);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightGreen;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(221, 194);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(98, 83);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGreen;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 279);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 83);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGreen;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(117, 279);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(98, 83);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGreen;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(221, 279);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(98, 83);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightGreen;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(13, 364);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(202, 83);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DarkGray;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(325, 109);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(98, 83);
            this.btnDivision.TabIndex = 11;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.DarkGray;
            this.btnMultiplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplication.Location = new System.Drawing.Point(325, 194);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(98, 83);
            this.btnMultiplication.TabIndex = 12;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubstraction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubstraction.Location = new System.Drawing.Point(325, 279);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(98, 83);
            this.btnSubstraction.TabIndex = 13;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.LightGreen;
            this.btnComma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComma.Location = new System.Drawing.Point(221, 364);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(98, 83);
            this.btnComma.TabIndex = 14;
            this.btnComma.Text = ".";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(325, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 83);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.OnButtonClearClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(429, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 168);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(429, 279);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(98, 168);
            this.btnResult.TabIndex = 17;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.OnButtonResultClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightGreen;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 109);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(98, 83);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(547, 470);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.tbScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbScreen;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btn7;
    }
}

