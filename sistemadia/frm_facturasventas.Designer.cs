﻿namespace sistemadia
{
    partial class frm_facturasventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturasventas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODIGO_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoprotxt = new System.Windows.Forms.TextBox();
            this.productotxt = new System.Windows.Forms.TextBox();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtnombre = new System.Windows.Forms.Label();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.colocar = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadotxt = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_PROD,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(46, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(615, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CODIGO_PROD
            // 
            this.CODIGO_PROD.HeaderText = "COD_PRODUCTO";
            this.CODIGO_PROD.Name = "CODIGO_PROD";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODCUTO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CANTIDAD";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRECIO";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column8.HeaderText = "IMPORTE";
            this.Column8.Name = "Column8";
            // 
            // codigoprotxt
            // 
            this.codigoprotxt.Location = new System.Drawing.Point(46, 171);
            this.codigoprotxt.Name = "codigoprotxt";
            this.codigoprotxt.Size = new System.Drawing.Size(87, 20);
            this.codigoprotxt.TabIndex = 1;
            // 
            // productotxt
            // 
            this.productotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productotxt.Location = new System.Drawing.Point(168, 171);
            this.productotxt.Name = "productotxt";
            this.productotxt.Size = new System.Drawing.Size(81, 20);
            this.productotxt.TabIndex = 2;
            this.productotxt.TextChanged += new System.EventHandler(this.productotxt_TextChanged);
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(284, 171);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(81, 20);
            this.cantidadtxt.TabIndex = 3;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(395, 171);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(78, 20);
            this.preciotxt.TabIndex = 4;
            // 
            // fechatxt
            // 
            this.fechatxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechatxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(122)))), ((int)(((byte)(126)))));
            this.fechatxt.Location = new System.Drawing.Point(696, 52);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(118, 23);
            this.fechatxt.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnombre.Location = new System.Drawing.Point(17, 85);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.Text = "label1";
            this.txtnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtnombre.Visible = false;
            // 
            // clientetxt
            // 
            this.clientetxt.Location = new System.Drawing.Point(20, 43);
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(92, 20);
            this.clientetxt.TabIndex = 7;
            this.clientetxt.TextChanged += new System.EventHandler(this.clientetxt_TextChanged);
            // 
            // colocar
            // 
            this.colocar.BackColor = System.Drawing.Color.Green;
            this.colocar.FlatAppearance.BorderSize = 0;
            this.colocar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colocar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colocar.Image = ((System.Drawing.Image)(resources.GetObject("colocar.Image")));
            this.colocar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colocar.Location = new System.Drawing.Point(102, 173);
            this.colocar.Name = "colocar";
            this.colocar.Size = new System.Drawing.Size(166, 32);
            this.colocar.TabIndex = 9;
            this.colocar.Text = "Colocar[Enter]";
            this.colocar.UseVisualStyleBackColor = false;
            this.colocar.Click += new System.EventHandler(this.colocar_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.Green;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_vender.Image = ((System.Drawing.Image)(resources.GetObject("btn_vender.Image")));
            this.btn_vender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vender.Location = new System.Drawing.Point(102, 312);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(166, 32);
            this.btn_vender.TabIndex = 11;
            this.btn_vender.Text = "TICKET[Fin]";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Green;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.Location = new System.Drawing.Point(102, 242);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(166, 32);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "Eliminar[F4]";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(439, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultadotxt
            // 
            this.resultadotxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultadotxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultadotxt.Location = new System.Drawing.Point(556, 543);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.Size = new System.Drawing.Size(69, 23);
            this.resultadotxt.TabIndex = 12;
            this.resultadotxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Navy;
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.btn_vender);
            this.bunifuCards1.Controls.Add(this.eliminar);
            this.bunifuCards1.Controls.Add(this.colocar);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(696, 197);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(343, 397);
            this.bunifuCards1.TabIndex = 13;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(98, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(150, 19);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Colocar Productos";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(168, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Facturas
            // 
            this.AcceptButton = this.colocar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1119, 642);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.fechatxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.cantidadtxt);
            this.Controls.Add(this.productotxt);
            this.Controls.Add(this.codigoprotxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Facturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox codigoprotxt;
        private System.Windows.Forms.TextBox productotxt;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.Button colocar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultadotxt;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button btn_vender;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}