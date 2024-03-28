namespace Calculadora.functionsMath
{
    partial class FormCoseno
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
            LabelResult = new Label();
            SuspendLayout();
            // 
            // calcular
            // 
            calcular.Font = new Font("Segoe UI", 12F);
            calcular.Location = new Point(91, 253);
            calcular.Name = "calcular";
            calcular.Size = new Size(190, 47);
            calcular.TabIndex = 22;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 23;
            label1.Text = "Numero";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(50, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 34);
            textBox1.TabIndex = 24;
            // 
            // LabelResult
            // 
            LabelResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelResult.AutoSize = true;
            LabelResult.BackColor = SystemColors.Control;
            LabelResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelResult.ForeColor = Color.MediumSeaGreen;
            LabelResult.Location = new Point(67, 175);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(190, 31);
            LabelResult.TabIndex = 25;
            LabelResult.Text = "El coseno de X es";
            LabelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCoseno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 338);
            Controls.Add(LabelResult);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(calcular);
            Name = "FormCoseno";
            Text = "FormCoseno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcular;
        private Label label1;
        private TextBox textBox1;
        private Label LabelResult;
    }
}