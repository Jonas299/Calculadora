namespace Calculadora.functionsMath
{
    partial class FormSuma
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
            calcular = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            LabelResult = new Label();
            SuspendLayout();
            // 
            // calcular
            // 
            calcular.Font = new Font("Segoe UI", 12F);
            calcular.Location = new Point(80, 367);
            calcular.Name = "calcular";
            calcular.Size = new Size(190, 47);
            calcular.TabIndex = 0;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(48, 65);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 1;
            label1.Text = "Numero 1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(48, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(48, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 34);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 170);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 3;
            label2.Text = "Numero 2";
            // 
            // LabelResult
            // 
            LabelResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelResult.AutoSize = true;
            LabelResult.BackColor = SystemColors.Control;
            LabelResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelResult.ForeColor = Color.MediumSeaGreen;
            LabelResult.Location = new Point(60, 295);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(0, 31);
            LabelResult.TabIndex = 5;
            LabelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSuma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(LabelResult);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(calcular);
            Name = "FormSuma";
            Text = "FormSuma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcular;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label LabelResult;
    }
}