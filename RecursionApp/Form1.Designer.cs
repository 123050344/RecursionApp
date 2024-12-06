namespace RecursionApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFactorial = new TextBox();
            txtFibonacci = new TextBox();
            txtSuma = new TextBox();
            btnCalcularFactorial = new Button();
            btnCalcularFibonacci = new Button();
            btnCalcularSuma = new Button();
            lblResultadoFactorial = new Label();
            lblResultadoFibonacci = new Label();
            lblResultadoSuma = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 104);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Factorial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 196);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Fibonacci";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 288);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Suma";
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(56, 122);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(186, 23);
            txtFactorial.TabIndex = 3;
            // 
            // txtFibonacci
            // 
            txtFibonacci.Location = new Point(56, 214);
            txtFibonacci.Name = "txtFibonacci";
            txtFibonacci.Size = new Size(186, 23);
            txtFibonacci.TabIndex = 4;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(56, 306);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(186, 23);
            txtSuma.TabIndex = 5;
            // 
            // btnCalcularFactorial
            // 
            btnCalcularFactorial.Location = new Point(289, 108);
            btnCalcularFactorial.Name = "btnCalcularFactorial";
            btnCalcularFactorial.Size = new Size(162, 48);
            btnCalcularFactorial.TabIndex = 6;
            btnCalcularFactorial.Text = "Calcular";
            btnCalcularFactorial.UseVisualStyleBackColor = true;
            btnCalcularFactorial.Click += btnCalcularFactorial_Click;
            // 
            // btnCalcularFibonacci
            // 
            btnCalcularFibonacci.Location = new Point(289, 200);
            btnCalcularFibonacci.Name = "btnCalcularFibonacci";
            btnCalcularFibonacci.Size = new Size(162, 48);
            btnCalcularFibonacci.TabIndex = 7;
            btnCalcularFibonacci.Text = "Calcular";
            btnCalcularFibonacci.UseVisualStyleBackColor = true;
            btnCalcularFibonacci.Click += btnCalcularFibonacci_Click;
            // 
            // btnCalcularSuma
            // 
            btnCalcularSuma.Location = new Point(289, 292);
            btnCalcularSuma.Name = "btnCalcularSuma";
            btnCalcularSuma.Size = new Size(162, 48);
            btnCalcularSuma.TabIndex = 8;
            btnCalcularSuma.Text = "Calcular";
            btnCalcularSuma.UseVisualStyleBackColor = true;
            btnCalcularSuma.Click += btnCalcularSuma_Click;
            // 
            // lblResultadoFactorial
            // 
            lblResultadoFactorial.AutoSize = true;
            lblResultadoFactorial.Location = new Point(526, 122);
            lblResultadoFactorial.Name = "lblResultadoFactorial";
            lblResultadoFactorial.Size = new Size(38, 15);
            lblResultadoFactorial.TabIndex = 9;
            lblResultadoFactorial.Text = "label4";
            // 
            // lblResultadoFibonacci
            // 
            lblResultadoFibonacci.AutoSize = true;
            lblResultadoFibonacci.Location = new Point(526, 214);
            lblResultadoFibonacci.Name = "lblResultadoFibonacci";
            lblResultadoFibonacci.Size = new Size(38, 15);
            lblResultadoFibonacci.TabIndex = 10;
            lblResultadoFibonacci.Text = "label5";
            // 
            // lblResultadoSuma
            // 
            lblResultadoSuma.AutoSize = true;
            lblResultadoSuma.Location = new Point(526, 306);
            lblResultadoSuma.Name = "lblResultadoSuma";
            lblResultadoSuma.Size = new Size(38, 15);
            lblResultadoSuma.TabIndex = 11;
            lblResultadoSuma.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoSuma);
            Controls.Add(lblResultadoFibonacci);
            Controls.Add(lblResultadoFactorial);
            Controls.Add(btnCalcularSuma);
            Controls.Add(btnCalcularFibonacci);
            Controls.Add(btnCalcularFactorial);
            Controls.Add(txtSuma);
            Controls.Add(txtFibonacci);
            Controls.Add(txtFactorial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFactorial;
        private TextBox txtFibonacci;
        private TextBox txtSuma;
        private Button btnCalcularFactorial;
        private Button btnCalcularFibonacci;
        private Button btnCalcularSuma;
        private Label lblResultadoFactorial;
        private Label lblResultadoFibonacci;
        private Label lblResultadoSuma;
    }
}
