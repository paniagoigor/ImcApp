namespace ImcApp
{
    partial class frmCalculaIMC
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
            panel1 = new Panel();
            BtnCalcular = new Button();
            NumPeso = new NumericUpDown();
            NumAltura = new NumericUpDown();
            Resultado = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumAltura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 46);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 137);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Altura(m):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 214);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Peso(Kg):";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BtnCalcular);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NumPeso);
            panel1.Controls.Add(NumAltura);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 448);
            panel1.TabIndex = 3;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(65, 338);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(112, 34);
            BtnCalcular.TabIndex = 2;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // NumPeso
            // 
            NumPeso.DecimalPlaces = 2;
            NumPeso.Location = new Point(65, 242);
            NumPeso.Name = "NumPeso";
            NumPeso.Size = new Size(180, 31);
            NumPeso.TabIndex = 1;
            NumPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // NumAltura
            // 
            NumAltura.DecimalPlaces = 2;
            NumAltura.Location = new Point(65, 165);
            NumAltura.Name = "NumAltura";
            NumAltura.Size = new Size(180, 31);
            NumAltura.TabIndex = 0;
            NumAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Resultado.Location = new Point(588, 176);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(20, 21);
            Resultado.TabIndex = 4;
            Resultado.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 138);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 5;
            label4.Text = "Resultado:";
            // 
            // frmCalculaIMC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Resultado);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmCalculaIMC";
            Text = "Calculadora de IMC";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumAltura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button BtnCalcular;
        private NumericUpDown NumPeso;
        private NumericUpDown NumAltura;
        private Label Resultado;
        private Label label4;
    }
}