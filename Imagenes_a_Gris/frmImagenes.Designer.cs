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
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(395, 67);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(445, 151);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "PROCESAR IMAGEN";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // frmImagenes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 300);
            Controls.Add(btnProcesar);
            Name = "frmImagenes";
            Text = "frmImagenes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcesar;
    }
}