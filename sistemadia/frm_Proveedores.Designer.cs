namespace sistemadia
{
    partial class frm_Proveedores
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
            this.txtbox_Nombre = new System.Windows.Forms.TextBox();
            this.txtbox_Direccion = new System.Windows.Forms.TextBox();
            this.txtbox_Telefono = new System.Windows.Forms.TextBox();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limipiar = new System.Windows.Forms.Button();
            this.txt_idproveedor = new System.Windows.Forms.TextBox();
            this.dtView_proveedores = new System.Windows.Forms.DataGridView();
            this.btn_eliminarProveedores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_Nombre
            // 
            this.txtbox_Nombre.Location = new System.Drawing.Point(90, 115);
            this.txtbox_Nombre.Name = "txtbox_Nombre";
            this.txtbox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Nombre.TabIndex = 0;
            // 
            // txtbox_Direccion
            // 
            this.txtbox_Direccion.Location = new System.Drawing.Point(90, 151);
            this.txtbox_Direccion.Name = "txtbox_Direccion";
            this.txtbox_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Direccion.TabIndex = 1;
            // 
            // txtbox_Telefono
            // 
            this.txtbox_Telefono.Location = new System.Drawing.Point(90, 186);
            this.txtbox_Telefono.Name = "txtbox_Telefono";
            this.txtbox_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Telefono.TabIndex = 2;
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.Location = new System.Drawing.Point(90, 222);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Email.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(31, 115);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(23, 154);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(31, 222);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(28, 193);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 7;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(99, 274);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_limipiar);
            this.panel1.Controls.Add(this.txt_idproveedor);
            this.panel1.Controls.Add(this.txtbox_Nombre);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.txtbox_Direccion);
            this.panel1.Controls.Add(this.lbl_Telefono);
            this.panel1.Controls.Add(this.txtbox_Telefono);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.txtbox_Email);
            this.panel1.Controls.Add(this.lbl_Direccion);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Location = new System.Drawing.Point(681, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 321);
            this.panel1.TabIndex = 9;
            // 
            // btn_limipiar
            // 
            this.btn_limipiar.Location = new System.Drawing.Point(34, 33);
            this.btn_limipiar.Name = "btn_limipiar";
            this.btn_limipiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limipiar.TabIndex = 10;
            this.btn_limipiar.Text = "Limpiar";
            this.btn_limipiar.UseVisualStyleBackColor = true;
            this.btn_limipiar.Click += new System.EventHandler(this.btn_limipiar_Click);
            // 
            // txt_idproveedor
            // 
            this.txt_idproveedor.Location = new System.Drawing.Point(90, 71);
            this.txt_idproveedor.Name = "txt_idproveedor";
            this.txt_idproveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_idproveedor.TabIndex = 9;
            // 
            // dtView_proveedores
            // 
            this.dtView_proveedores.AllowUserToAddRows = false;
            this.dtView_proveedores.AllowUserToDeleteRows = false;
            this.dtView_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView_proveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtView_proveedores.Location = new System.Drawing.Point(42, 55);
            this.dtView_proveedores.Name = "dtView_proveedores";
            this.dtView_proveedores.Size = new System.Drawing.Size(594, 226);
            this.dtView_proveedores.TabIndex = 10;
            this.dtView_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_proveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtView_proveedores_OnCellDoubleClick);
            this.dtView_proveedores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtView_proveedores_OnCambiodevalor);
            // 
            // btn_eliminarProveedores
            // 
            this.btn_eliminarProveedores.Enabled = false;
            this.btn_eliminarProveedores.Location = new System.Drawing.Point(430, 303);
            this.btn_eliminarProveedores.Name = "btn_eliminarProveedores";
            this.btn_eliminarProveedores.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarProveedores.TabIndex = 11;
            this.btn_eliminarProveedores.Text = "Eliminar";
            this.btn_eliminarProveedores.UseVisualStyleBackColor = true;
            this.btn_eliminarProveedores.Click += new System.EventHandler(this.btn_eliminarProveedores_Click);
            // 
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.btn_eliminarProveedores);
            this.Controls.Add(this.dtView_proveedores);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Proveedores";
            this.Text = "frm_Proveedores";
            this.Load += new System.EventHandler(this.frm_Proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_Nombre;
        private System.Windows.Forms.TextBox txtbox_Direccion;
        private System.Windows.Forms.TextBox txtbox_Telefono;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtView_proveedores;
        private System.Windows.Forms.Button btn_eliminarProveedores;
        private System.Windows.Forms.TextBox txt_idproveedor;
        private System.Windows.Forms.Button btn_limipiar;
    }
}