namespace FuncionesAsincronas_ProcesamientoParalelo
{
    partial class frmImagenes
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
            btnProcesar = new Button();
            pbImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(431, 41);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(445, 151);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "PROCESAR IMAGEN";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // pbImagen
            // 
            pbImagen.Dock = DockStyle.Bottom;
            pbImagen.Location = new Point(0, 232);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(1248, 599);
            pbImagen.TabIndex = 1;
            pbImagen.TabStop = false;
            // 
            // frmImagenes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 831);
            Controls.Add(pbImagen);
            Controls.Add(btnProcesar);
            Name = "frmImagenes";
            Text = "frmImagenes";
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcesar;
        private PictureBox pbImagen;
    }
}