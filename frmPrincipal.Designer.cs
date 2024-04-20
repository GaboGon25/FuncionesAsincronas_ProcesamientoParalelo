namespace FuncionesAsincronas_ProcesamientoParalelo
{
    partial class frmPrincipal
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
            btnTextos = new Button();
            btnImagenes = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnTextos
            // 
            btnTextos.Location = new Point(161, 222);
            btnTextos.Name = "btnTextos";
            btnTextos.Size = new Size(371, 270);
            btnTextos.TabIndex = 0;
            btnTextos.Text = "CONVERSION DE ARCHIVOS DE TEXTOS GRANDES A MAYUSCULA";
            btnTextos.UseVisualStyleBackColor = true;
            btnTextos.Click += btnTextos_Click;
            // 
            // btnImagenes
            // 
            btnImagenes.Location = new Point(628, 222);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(371, 270);
            btnImagenes.TabIndex = 1;
            btnImagenes.Text = "CARGAR IMAGENES PARA PASARLA A ESCALA DE GRISES";
            btnImagenes.UseVisualStyleBackColor = true;
            btnImagenes.Click += btnImagenes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 140);
            label1.Name = "label1";
            label1.Size = new Size(395, 32);
            label1.TabIndex = 2;
            label1.Text = "ELIGA EL EJERCICIO QUE DESEA VER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 512);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 3;
            label2.Text = "EJERCICIO 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(858, 512);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 4;
            label3.Text = "EJERCICIO 2";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 652);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnImagenes);
            Controls.Add(btnTextos);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTextos;
        private Button btnImagenes;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}