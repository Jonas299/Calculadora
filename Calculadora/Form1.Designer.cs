namespace Calculadora
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.Location = new Point(22, 136);
            button1.Name = "button1";
            button1.Size = new Size(213, 55);
            button1.TabIndex = 1;
            button1.Text = "Sumar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F);
            button2.Location = new Point(22, 197);
            button2.Name = "button2";
            button2.Size = new Size(213, 55);
            button2.TabIndex = 2;
            button2.Text = "Resta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F);
            button3.Location = new Point(22, 258);
            button3.Name = "button3";
            button3.Size = new Size(213, 55);
            button3.TabIndex = 3;
            button3.Text = "Multiplicacion";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F);
            button4.Location = new Point(22, 319);
            button4.Name = "button4";
            button4.Size = new Size(213, 55);
            button4.TabIndex = 4;
            button4.Text = "Division";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16.2F);
            button5.Location = new Point(22, 380);
            button5.Name = "button5";
            button5.Size = new Size(213, 55);
            button5.TabIndex = 5;
            button5.Text = "Logaritmo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16.2F);
            button6.Location = new Point(253, 136);
            button6.Name = "button6";
            button6.Size = new Size(217, 55);
            button6.TabIndex = 6;
            button6.Text = "Potencia";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 54);
            label1.Name = "label1";
            label1.Size = new Size(360, 41);
            label1.TabIndex = 7;
            label1.Text = "Operaciones matematicas";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16.2F);
            button7.Location = new Point(253, 197);
            button7.Name = "button7";
            button7.Size = new Size(217, 55);
            button7.TabIndex = 8;
            button7.Text = "Raiz cuadrada";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16.2F);
            button8.Location = new Point(257, 258);
            button8.Name = "button8";
            button8.Size = new Size(213, 55);
            button8.TabIndex = 9;
            button8.Text = "Seno";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 16.2F);
            button9.Location = new Point(257, 319);
            button9.Name = "button9";
            button9.Size = new Size(213, 55);
            button9.TabIndex = 10;
            button9.Text = "Coseno";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 16.2F);
            button10.Location = new Point(257, 380);
            button10.Name = "button10";
            button10.Size = new Size(213, 55);
            button10.TabIndex = 11;
            button10.Text = "Valor absoluto";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 559);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
