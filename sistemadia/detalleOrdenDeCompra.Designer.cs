namespace sistemadia
{
    partial class detalleOrdenDeCompra
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
            this.dtView_DetalleOrdenCompra = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_DetalleOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtView_DetalleOrdenCompra
            // 
            this.dtView_DetalleOrdenCompra.AllowUserToAddRows = false;
            this.dtView_DetalleOrdenCompra.AllowUserToDeleteRows = false;
            this.dtView_DetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView_DetalleOrdenCompra.Location = new System.Drawing.Point(93, 38);
            this.dtView_DetalleOrdenCompra.Name = "dtView_DetalleOrdenCompra";
            this.dtView_DetalleOrdenCompra.Size = new System.Drawing.Size(632, 275);
            this.dtView_DetalleOrdenCompra.TabIndex = 0;
            this.dtView_DetalleOrdenCompra.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.comprobartabla);
            this.dtView_DetalleOrdenCompra.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(200, 384);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Location = new System.Drawing.Point(499, 384);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // detalleOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dtView_DetalleOrdenCompra);
            this.Name = "detalleOrdenDeCompra";
            this.Text = "detalleOrdenDeCompra";
            this.Load += new System.EventHandler(this.detalleOrdenDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_DetalleOrdenCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        public System.Windows.Forms.DataGridView dtView_DetalleOrdenCompra;
    }
}