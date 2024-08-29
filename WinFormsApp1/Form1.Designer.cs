namespace WinFormsApp1
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
            btnCalculateLoan = new Button();
            btnGenerateReciept = new Button();
            btnReset = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAmountofLoan = new TextBox();
            label5 = new Label();
            txtNumberofYears = new TextBox();
            txtInterestRate = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            lblMonthlyPayment = new Label();
            lblTotalPayment = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculateLoan
            // 
            btnCalculateLoan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnCalculateLoan.Location = new Point(42, 449);
            btnCalculateLoan.Name = "btnCalculateLoan";
            btnCalculateLoan.Size = new Size(187, 38);
            btnCalculateLoan.TabIndex = 0;
            btnCalculateLoan.Text = "Calculate Loan";
            btnCalculateLoan.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReciept
            // 
            btnGenerateReciept.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnGenerateReciept.Location = new Point(293, 449);
            btnGenerateReciept.Name = "btnGenerateReciept";
            btnGenerateReciept.Size = new Size(243, 46);
            btnGenerateReciept.TabIndex = 1;
            btnGenerateReciept.Text = "Generate Reciept";
            btnGenerateReciept.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnReset.Location = new Point(622, 449);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(243, 46);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnExit.Location = new Point(924, 449);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(243, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit ";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 111);
            label1.Name = "label1";
            label1.Size = new Size(222, 30);
            label1.TabIndex = 4;
            label1.Text = "Enter amount of Loan";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 305);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 5;
            label2.Text = "Monthly Payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 242);
            label3.Name = "label3";
            label3.Size = new Size(191, 30);
            label3.TabIndex = 6;
            label3.Text = "Enter Interest Rate";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 177);
            label4.Name = "label4";
            label4.Size = new Size(229, 30);
            label4.TabIndex = 7;
            label4.Text = "Enter Number of Years";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAmountofLoan
            // 
            txtAmountofLoan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmountofLoan.Location = new Point(308, 116);
            txtAmountofLoan.Name = "txtAmountofLoan";
            txtAmountofLoan.Size = new Size(228, 35);
            txtAmountofLoan.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 368);
            label5.Name = "label5";
            label5.Size = new Size(149, 30);
            label5.TabIndex = 9;
            label5.Text = "Total Payment";
            // 
            // txtNumberofYears
            // 
            txtNumberofYears.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumberofYears.Location = new Point(308, 191);
            txtNumberofYears.Name = "txtNumberofYears";
            txtNumberofYears.Size = new Size(228, 35);
            txtNumberofYears.TabIndex = 10;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtInterestRate.Location = new Point(308, 254);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(228, 35);
            txtInterestRate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(91, 22);
            label6.Name = "label6";
            label6.Size = new Size(683, 50);
            label6.TabIndex = 14;
            label6.Text = "Loan Management Systems Calculator";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(126, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 75);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(705, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(462, 304);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.BackColor = Color.White;
            lblMonthlyPayment.BorderStyle = BorderStyle.Fixed3D;
            lblMonthlyPayment.Location = new Point(308, 305);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(228, 30);
            lblMonthlyPayment.TabIndex = 17;
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.BackColor = Color.White;
            lblTotalPayment.BorderStyle = BorderStyle.Fixed3D;
            lblTotalPayment.Location = new Point(308, 368);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(228, 30);
            lblTotalPayment.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkTurquoise;
            groupBox2.Location = new Point(35, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 129);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 508);
            Controls.Add(lblTotalPayment);
            Controls.Add(lblMonthlyPayment);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Controls.Add(txtInterestRate);
            Controls.Add(txtNumberofYears);
            Controls.Add(label5);
            Controls.Add(txtAmountofLoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnGenerateReciept);
            Controls.Add(btnCalculateLoan);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Loan Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateLoan;
        private Button btnGenerateReciept;
        private Button btnReset;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAmountofLoan;
        private Label label5;
        private TextBox txtNumberofYears;
        private TextBox txtInterestRate;
        private Label label6;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Label lblMonthlyPayment;
        private Label lblTotalPayment;
        private GroupBox groupBox2;
    }
}
