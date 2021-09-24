
namespace Kpavlakex1e
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTest1Results = new System.Windows.Forms.TextBox();
            this.txtTest2Results = new System.Windows.Forms.TextBox();
            this.txtTest3Results = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test 2:";
            // 
            // txtTest1
            // 
            this.txtTest1.AutoSize = true;
            this.txtTest1.Location = new System.Drawing.Point(116, 155);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(40, 13);
            this.txtTest1.TabIndex = 8;
            this.txtTest1.Text = "Test 3:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(244, 99);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 22);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 20);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTest1Results
            // 
            this.txtTest1Results.Location = new System.Drawing.Point(172, 102);
            this.txtTest1Results.Name = "txtTest1Results";
            this.txtTest1Results.Size = new System.Drawing.Size(43, 20);
            this.txtTest1Results.TabIndex = 0;
            this.txtTest1Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest2Results
            // 
            this.txtTest2Results.Location = new System.Drawing.Point(172, 128);
            this.txtTest2Results.Name = "txtTest2Results";
            this.txtTest2Results.Size = new System.Drawing.Size(43, 20);
            this.txtTest2Results.TabIndex = 1;
            this.txtTest2Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest3Results
            // 
            this.txtTest3Results.Location = new System.Drawing.Point(172, 152);
            this.txtTest3Results.Name = "txtTest3Results";
            this.txtTest3Results.Size = new System.Drawing.Size(43, 20);
            this.txtTest3Results.TabIndex = 2;
            this.txtTest3Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Average:";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(172, 183);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(43, 20);
            this.txtAverage.TabIndex = 10;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 267);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTest3Results);
            this.Controls.Add(this.txtTest2Results);
            this.Controls.Add(this.txtTest1Results);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTest1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTest1Results;
        private System.Windows.Forms.TextBox txtTest2Results;
        private System.Windows.Forms.TextBox txtTest3Results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAverage;
    }
}

