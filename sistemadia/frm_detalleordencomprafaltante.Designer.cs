namespace sistemadia
{
    partial class frm_detalleordencomprafaltante
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
            this.dtView_detallefaltante = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_relizarnuevaordencompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_detallefaltante)).BeginInit();
            this.SuspendLayout();
            // 
            // dtView_detallefaltante
            // 
            this.dtView_detallefaltante.AllowUserToAddRows = false;
            this.dtView_detallefaltante.AllowUserToDeleteRows = false;
            this.dtView_detallefaltante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView_detallefaltante.Location = new System.Drawing.Point(61, 12);
            this.dtView_detallefaltante.Name = "dtView_detallefaltante";
            this.dtView_detallefaltante.ReadOnly = true;
            this.dtView_detallefaltante.Size = new System.Drawing.Size(430, 332);
            this.dtView_detallefaltante.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(133, 376);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_relizarnuevaordencompra
            // 
            this.btn_relizarnuevaordencompra.Location = new System.Drawing.Point(344, 375);
            this.btn_relizarnuevaordencompra.Name = "btn_relizarnuevaordencompra";
            this.btn_relizarnuevaordencompra.Size = new System.Drawing.Size(75, 23);
            this.btn_relizarnuevaordencompra.TabIndex = 2;
            this.btn_relizarnuevaordencompra.Text = "Comprar";
            this.btn_relizarnuevaordencompra.UseVisualStyleBackColor = true;
            this.btn_relizarnuevaordencompra.Click += new System.EventHandler(this.btn_relizarnuevaordencompra_Click);
            // 
            // frm_detalleordencomprafaltante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_relizarnuevaordencompra);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dtView_detallefaltante);
            this.Name = "frm_detalleordencomprafaltante";
            this.Text = "frm_detalleordencomprafaltante";
            this.Load += new System.EventHandler(this.frm_detalleordencomprafaltante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_detallefaltante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtView_detallefaltante;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_relizarnuevaordencompra;
    }
}