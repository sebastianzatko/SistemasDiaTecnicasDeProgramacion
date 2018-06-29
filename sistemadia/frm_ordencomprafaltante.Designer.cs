namespace sistemadia
{
    partial class frm_ordencomprafaltante
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
            this.dtView_ordenesdecomprafaltantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_ordenesdecomprafaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtView_ordenesdecomprafaltantes
            // 
            this.dtView_ordenesdecomprafaltantes.AllowUserToAddRows = false;
            this.dtView_ordenesdecomprafaltantes.AllowUserToDeleteRows = false;
            this.dtView_ordenesdecomprafaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView_ordenesdecomprafaltantes.Location = new System.Drawing.Point(87, 47);
            this.dtView_ordenesdecomprafaltantes.Name = "dtView_ordenesdecomprafaltantes";
            this.dtView_ordenesdecomprafaltantes.ReadOnly = true;
            this.dtView_ordenesdecomprafaltantes.Size = new System.Drawing.Size(408, 317);
            this.dtView_ordenesdecomprafaltantes.TabIndex = 0;
            this.dtView_ordenesdecomprafaltantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionclick);
            this.dtView_ordenesdecomprafaltantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionclick);
            // 
            // frm_ordencomprafaltante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtView_ordenesdecomprafaltantes);
            this.Name = "frm_ordencomprafaltante";
            this.Text = "frm_ordencomprafaltante";
            this.Load += new System.EventHandler(this.frm_ordencomprafaltante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_ordenesdecomprafaltantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtView_ordenesdecomprafaltantes;
    }
}