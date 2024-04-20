namespace FuncionesAsincronas_ProcesamientoParalelo
{
    partial class FrmConversor
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
            label1 = new Label();
            label2 = new Label();
            txtArchivo = new TextBox();
            btnIniciar = new Button();
            btnLimpiar = new Button();
            lbDetalle = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(247, 24);
            label1.Name = "label1";
            label1.Size = new Size(304, 22);
            label1.TabIndex = 0;
            label1.Text = "CONVERTIDOR A MAYUSCULAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 86);
            label2.Name = "label2";
            label2.Size = new Size(184, 18);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la ruta del archivo";
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(379, 81);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(257, 23);
            txtArchivo.TabIndex = 2;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(328, 136);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(169, 23);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "INICIAR PROCESO";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(531, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbDetalle
            // 
            lbDetalle.FormattingEnabled = true;
            lbDetalle.ItemHeight = 15;
            lbDetalle.Location = new Point(158, 216);
            lbDetalle.Name = "lbDetalle";
            lbDetalle.Size = new Size(478, 154);
            lbDetalle.TabIndex = 6;
            // 
            // FrmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(lbDetalle);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIniciar);
            Controls.Add(txtArchivo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmConversor";
            Text = "FrmConversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtArchivo;
        private Button btnIniciar;
        private Button btnLimpiar;
        private ListBox lbDetalle;
    }
}