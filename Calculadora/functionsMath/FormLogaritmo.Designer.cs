﻿namespace Calculadora.functionsMath
{
    partial class FormLogaritmo
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
            LabelResult = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            calcular = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LabelResult
            // 
            LabelResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelResult.AutoSize = true;
            LabelResult.BackColor = SystemColors.Control;
            LabelResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelResult.ForeColor = Color.MediumSeaGreen;
            LabelResult.Location = new Point(12, 260);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(0, 31);
            LabelResult.TabIndex = 11;
            LabelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(93, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 34);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(93, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 7;
            label1.Text = "Numero 1";
            // 
            // calcular
            // 
            calcular.Font = new Font("Segoe UI", 12F);
            calcular.Location = new Point(113, 319);
            calcular.Name = "calcular";
            calcular.Size = new Size(190, 47);
            calcular.TabIndex = 6;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(93, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 34);
            textBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(93, 142);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 12;
            label2.Text = "Base";
            // 
            // FormLogaritmo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 400);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(LabelResult);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(calcular);
            Name = "FormLogaritmo";
            Text = "FormLogaritmo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelResult;
        private TextBox textBox1;
        private Label label1;
        private Button calcular;
        private TextBox textBox2;
        private Label label2;
    }
}