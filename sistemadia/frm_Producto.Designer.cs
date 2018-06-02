namespace sistemadia
{
    partial class frm_Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Producto));
            this.GridVw_producto = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Guardar = new System.Windows.Forms.Button();
            this.tipotxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.disponibilidadtxt = new System.Windows.Forms.TextBox();
            this.nombreproductotxt = new System.Windows.Forms.TextBox();
            this.codigo_productotxt = new System.Windows.Forms.TextBox();
            this.lbl_disponibilidad = new System.Windows.Forms.Label();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Nuevo_Producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridVw_producto
            // 
            this.GridVw_producto.AllowUserToAddRows = false;
            this.GridVw_producto.AllowUserToOrderColumns = true;
            this.GridVw_producto.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.GridVw_producto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVw_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVw_producto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.GridVw_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVw_producto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVw_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridVw_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVw_producto.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridVw_producto.EnableHeadersVisualStyles = false;
            this.GridVw_producto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridVw_producto.Location = new System.Drawing.Point(66, 134);
            this.GridVw_producto.Name = "GridVw_producto";
            this.GridVw_producto.RowHeadersVisible = false;
            this.GridVw_producto.Size = new System.Drawing.Size(630, 283);
            this.GridVw_producto.TabIndex = 2;
            this.GridVw_producto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridVw_producto_CellFormatting);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbl_Nuevo_Producto);
            this.panel1.Controls.Add(this.lbl_Tipo);
            this.panel1.Controls.Add(this.lbl_Codigo_Producto);
            this.panel1.Controls.Add(this.lbl_Precio);
            this.panel1.Controls.Add(this.lbl_NombreProducto);
            this.panel1.Controls.Add(this.lbl_disponibilidad);
            this.panel1.Controls.Add(this.codigo_productotxt);
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.tipotxt);
            this.panel1.Controls.Add(this.preciotxt);
            this.panel1.Controls.Add(this.disponibilidadtxt);
            this.panel1.Controls.Add(this.nombreproductotxt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(769, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 540);
            this.panel1.TabIndex = 4;
           
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Green;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(67, 425);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(166, 32);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // tipotxt
            // 
            this.tipotxt.Location = new System.Drawing.Point(79, 385);
            this.tipotxt.Name = "tipotxt";
            this.tipotxt.Size = new System.Drawing.Size(134, 20);
            this.tipotxt.TabIndex = 7;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(79, 341);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(134, 20);
            this.preciotxt.TabIndex = 6;
            // 
            // disponibilidadtxt
            // 
            this.disponibilidadtxt.Location = new System.Drawing.Point(79, 296);
            this.disponibilidadtxt.Name = "disponibilidadtxt";
            this.disponibilidadtxt.Size = new System.Drawing.Size(134, 20);
            this.disponibilidadtxt.TabIndex = 5;
            // 
            // nombreproductotxt
            // 
            this.nombreproductotxt.Location = new System.Drawing.Point(79, 252);
            this.nombreproductotxt.Name = "nombreproductotxt";
            this.nombreproductotxt.Size = new System.Drawing.Size(134, 20);
            this.nombreproductotxt.TabIndex = 4;
            // 
            // codigo_productotxt
            // 
            this.codigo_productotxt.Location = new System.Drawing.Point(79, 209);
            this.codigo_productotxt.Name = "codigo_productotxt";
            this.codigo_productotxt.Size = new System.Drawing.Size(134, 20);
            this.codigo_productotxt.TabIndex = 9;
            
            // 
            // lbl_disponibilidad
            // 
            this.lbl_disponibilidad.AutoSize = true;
            this.lbl_disponibilidad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disponibilidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_disponibilidad.Location = new System.Drawing.Point(104, 275);
            this.lbl_disponibilidad.Name = "lbl_disponibilidad";
            this.lbl_disponibilidad.Size = new System.Drawing.Size(83, 13);
            this.lbl_disponibilidad.TabIndex = 11;
            this.lbl_disponibilidad.Text = "Disponibilidad";
       
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(95, 232);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(101, 13);
            this.lbl_NombreProducto.TabIndex = 12;
            this.lbl_NombreProducto.Text = "Nombre Producto";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Precio.Location = new System.Drawing.Point(123, 319);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(39, 13);
            this.lbl_Precio.TabIndex = 13;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Codigo_Producto
            // 
            this.lbl_Codigo_Producto.AutoSize = true;
            this.lbl_Codigo_Producto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Codigo_Producto.Location = new System.Drawing.Point(95, 182);
            this.lbl_Codigo_Producto.Name = "lbl_Codigo_Producto";
            this.lbl_Codigo_Producto.Size = new System.Drawing.Size(96, 13);
            this.lbl_Codigo_Producto.TabIndex = 14;
            this.lbl_Codigo_Producto.Text = "Codigo Producto";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Tipo.Location = new System.Drawing.Point(132, 364);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(30, 13);
            this.lbl_Tipo.TabIndex = 15;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // lbl_Nuevo_Producto
            // 
            this.lbl_Nuevo_Producto.AutoSize = true;
            this.lbl_Nuevo_Producto.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nuevo_Producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Nuevo_Producto.Location = new System.Drawing.Point(59, 9);
            this.lbl_Nuevo_Producto.Name = "lbl_Nuevo_Producto";
            this.lbl_Nuevo_Producto.Size = new System.Drawing.Size(174, 28);
            this.lbl_Nuevo_Producto.TabIndex = 16;
            this.lbl_Nuevo_Producto.Text = "Nuevo Producto";
           
            // 
            // frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridVw_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Producto";
            this.Text = "frm_Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVw_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVw_producto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tipotxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox disponibilidadtxt;
        private System.Windows.Forms.TextBox nombreproductotxt;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox codigo_productotxt;
        private System.Windows.Forms.Label lbl_disponibilidad;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Codigo_Producto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.Label lbl_Nuevo_Producto;
    }
}