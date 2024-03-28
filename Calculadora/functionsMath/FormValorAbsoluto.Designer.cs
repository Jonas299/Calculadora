namespace Calculadora.functionsMath
{
    partial class FormValorAbsoluto
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
            SuspendLayout();
            // 
            // LabelResult
            // 
            LabelResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelResult.AutoSize = true;
            LabelResult.BackColor = SystemColors.Control;
            LabelResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelResult.ForeColor = Color.MediumSeaGreen;
            LabelResult.Location = new Point(59, 172);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(263, 31);
            LabelResult.TabIndex = 29;
            LabelResult.Text = "El valor absoluto de X es";
            LabelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(50, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 34);
            textBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 27;
            label1.Text = "Numero";
            // 
            // calcular
            // 
            calcular.Font = new Font("Segoe UI", 12F);
            calcular.Location = new Point(91, 253);
            calcular.Name = "calcular";
            calcular.Size = new Size(190, 47);
            calcular.TabIndex = 26;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // FormValorAbsoluto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 338);
            Controls.Add(LabelResult);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(calcular);
            Name = "FormValorAbsoluto";
            Text = "FormValorAbsoluto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelResult;
        private TextBox textBox1;
        private Label label1;
        private Button calcular;
    }
}