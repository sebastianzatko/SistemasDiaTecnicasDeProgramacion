namespace sistemadia
{
    partial class frm_Clientes
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
            this.dtView_Clientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cmbox_tipo = new System.Windows.Forms.ComboBox();
            this.txtbox_apellido = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_idCliente = new System.Windows.Forms.TextBox();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.btn_eliminarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtView_Clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtView_Clientes
            // 
            this.dtView_Clientes.AllowUserToAddRows = false;
            this.dtView_Clientes.AllowUserToDeleteRows = false;
            this.dtView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView_Clientes.Location = new System.Drawing.Point(53, 56);
            this.dtView_Clientes.Name = "dtView_Clientes";
            this.dtView_Clientes.Size = new System.Drawing.Size(482, 314);
            this.dtView_Clientes.TabIndex = 0;
            this.dtView_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.terminaredit);
            this.dtView_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCelldobleclick);
            this.dtView_Clientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtView_Clientes_OnCambiodevalor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_nuevoCliente);
            this.panel1.Controls.Add(this.lbl_tipo);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_apellido);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.cmbox_tipo);
            this.panel1.Controls.Add(this.txtbox_apellido);
            this.panel1.Controls.Add(this.txtbox_email);
            this.panel1.Controls.Add(this.txtbox_idCliente);
            this.panel1.Controls.Add(this.txtBox_nombre);
            this.panel1.Location = new System.Drawing.Point(554, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 314);
            this.panel1.TabIndex = 1;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(157, 3);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limipiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.Location = new System.Drawing.Point(51, 239);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevoCliente.TabIndex = 9;
            this.btn_nuevoCliente.Text = "Agregar";
            this.btn_nuevoCliente.UseVisualStyleBackColor = true;
            this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoUsuario_Click);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(6, 178);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 8;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 132);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(6, 106);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 6;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 80);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre";
            // 
            // cmbox_tipo
            // 
            this.cmbox_tipo.FormattingEnabled = true;
            this.cmbox_tipo.Location = new System.Drawing.Point(51, 170);
            this.cmbox_tipo.Name = "cmbox_tipo";
            this.cmbox_tipo.Size = new System.Drawing.Size(121, 21);
            this.cmbox_tipo.TabIndex = 4;
            // 
            // txtbox_apellido
            // 
            this.txtbox_apellido.Location = new System.Drawing.Point(51, 106);
            this.txtbox_apellido.Name = "txtbox_apellido";
            this.txtbox_apellido.Size = new System.Drawing.Size(100, 20);
            this.txtbox_apellido.TabIndex = 3;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(51, 132);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(100, 20);
            this.txtbox_email.TabIndex = 2;
            // 
            // txtbox_idCliente
            // 
            this.txtbox_idCliente.Location = new System.Drawing.Point(51, 19);
            this.txtbox_idCliente.Name = "txtbox_idCliente";
            this.txtbox_idCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbox_idCliente.TabIndex = 1;
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(51, 80);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nombre.TabIndex = 0;
            // 
            // btn_eliminarCliente
            // 
            this.btn_eliminarCliente.Enabled = false;
            this.btn_eliminarCliente.Location = new System.Drawing.Point(460, 405);
            this.btn_eliminarCliente.Name = "btn_eliminarCliente";
            this.btn_eliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarCliente.TabIndex = 2;
            this.btn_eliminarCliente.Text = "Eliminar";
            this.btn_eliminarCliente.UseVisualStyleBackColor = true;
            this.btn_eliminarCliente.Click += new System.EventHandler(this.btn_eliminarCliente_Click);
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtView_Clientes);
            this.Name = "frm_Clientes";
            this.Text = "frm_Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView_Clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtView_Clientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox cmbox_tipo;
        private System.Windows.Forms.TextBox txtbox_apellido;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_idCliente;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.Button btn_eliminarCliente;
    }
}