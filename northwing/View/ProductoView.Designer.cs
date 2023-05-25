namespace northwing
{
    partial class ProductoView
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
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbsupplierID = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.lbunitPrice = new System.Windows.Forms.Label();
            this.textBoxproductID = new System.Windows.Forms.TextBox();
            this.textBoxproductName = new System.Windows.Forms.TextBox();
            this.textBoxsupplierID = new System.Windows.Forms.TextBox();
            this.textBoxcategoryID = new System.Windows.Forms.TextBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxprecioxunidad = new System.Windows.Forms.TextBox();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btañadirproducto = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.bteliminarproducto = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbsubtitulo = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.lbmensajemodificar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbinstruccion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProductID.Location = new System.Drawing.Point(59, 143);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(88, 21);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProductName.Location = new System.Drawing.Point(22, 97);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(114, 21);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product Name:";
            // 
            // lbsupplierID
            // 
            this.lbsupplierID.AutoSize = true;
            this.lbsupplierID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsupplierID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsupplierID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsupplierID.Location = new System.Drawing.Point(22, 153);
            this.lbsupplierID.Name = "lbsupplierID";
            this.lbsupplierID.Size = new System.Drawing.Size(90, 21);
            this.lbsupplierID.TabIndex = 2;
            this.lbsupplierID.Text = "Supplier ID:";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCategoryID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCategoryID.Location = new System.Drawing.Point(22, 209);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(94, 21);
            this.lbCategoryID.TabIndex = 3;
            this.lbCategoryID.Text = "Category ID:";
            // 
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbcantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcantidad.Location = new System.Drawing.Point(22, 267);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(118, 21);
            this.lbcantidad.TabIndex = 4;
            this.lbcantidad.Text = "Quantity x unit:";
            // 
            // lbunitPrice
            // 
            this.lbunitPrice.AutoSize = true;
            this.lbunitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbunitPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbunitPrice.Location = new System.Drawing.Point(22, 375);
            this.lbunitPrice.Name = "lbunitPrice";
            this.lbunitPrice.Size = new System.Drawing.Size(82, 21);
            this.lbunitPrice.TabIndex = 5;
            this.lbunitPrice.Text = "Unit price:";
            // 
            // textBoxproductID
            // 
            this.textBoxproductID.Location = new System.Drawing.Point(208, 144);
            this.textBoxproductID.Name = "textBoxproductID";
            this.textBoxproductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxproductID.TabIndex = 6;
            this.textBoxproductID.TextChanged += new System.EventHandler(this.textBoxproductID_TextChanged);
            this.textBoxproductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxproductID_KeyPress);
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Location = new System.Drawing.Point(217, 98);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(280, 20);
            this.textBoxproductName.TabIndex = 7;
            // 
            // textBoxsupplierID
            // 
            this.textBoxsupplierID.Location = new System.Drawing.Point(217, 154);
            this.textBoxsupplierID.Name = "textBoxsupplierID";
            this.textBoxsupplierID.Size = new System.Drawing.Size(280, 20);
            this.textBoxsupplierID.TabIndex = 8;
            // 
            // textBoxcategoryID
            // 
            this.textBoxcategoryID.Location = new System.Drawing.Point(390, 211);
            this.textBoxcategoryID.Name = "textBoxcategoryID";
            this.textBoxcategoryID.Size = new System.Drawing.Size(107, 20);
            this.textBoxcategoryID.TabIndex = 9;
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(217, 268);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(280, 20);
            this.textBoxcantidad.TabIndex = 10;
            // 
            // textBoxprecioxunidad
            // 
            this.textBoxprecioxunidad.Location = new System.Drawing.Point(217, 376);
            this.textBoxprecioxunidad.Name = "textBoxprecioxunidad";
            this.textBoxprecioxunidad.Size = new System.Drawing.Size(280, 20);
            this.textBoxprecioxunidad.TabIndex = 11;
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(405, 144);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(99, 23);
            this.btConsulta.TabIndex = 12;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btañadirproducto
            // 
            this.btañadirproducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btañadirproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btañadirproducto.Location = new System.Drawing.Point(64, 670);
            this.btañadirproducto.Name = "btañadirproducto";
            this.btañadirproducto.Size = new System.Drawing.Size(99, 46);
            this.btañadirproducto.TabIndex = 13;
            this.btañadirproducto.Text = "Añadir producto";
            this.btañadirproducto.UseVisualStyleBackColor = false;
            this.btañadirproducto.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(631, 144);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 23);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Borrar Datos";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(810, 670);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(99, 46);
            this.btSalir.TabIndex = 15;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // bteliminarproducto
            // 
            this.bteliminarproducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bteliminarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminarproducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bteliminarproducto.Location = new System.Drawing.Point(309, 670);
            this.bteliminarproducto.Name = "bteliminarproducto";
            this.bteliminarproducto.Size = new System.Drawing.Size(99, 46);
            this.bteliminarproducto.TabIndex = 16;
            this.bteliminarproducto.Text = "Eliminar Producto";
            this.bteliminarproducto.UseVisualStyleBackColor = false;
            this.bteliminarproducto.Click += new System.EventHandler(this.bteliminarproducto_Click);
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(217, 210);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbCategorias.TabIndex = 17;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulo.Location = new System.Drawing.Point(59, 21);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(223, 35);
            this.lbtitulo.TabIndex = 18;
            this.lbtitulo.Text = "Gestión productos";
            // 
            // lbsubtitulo
            // 
            this.lbsubtitulo.AutoSize = true;
            this.lbsubtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsubtitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsubtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsubtitulo.Location = new System.Drawing.Point(59, 83);
            this.lbsubtitulo.Name = "lbsubtitulo";
            this.lbsubtitulo.Size = new System.Drawing.Size(445, 28);
            this.lbsubtitulo.TabIndex = 19;
            this.lbsubtitulo.Text = "Introduzca el ID del producto y pulse CONSULTAR:";
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(557, 670);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(99, 46);
            this.btModificar.TabIndex = 20;
            this.btModificar.Text = "Modificar Datos";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // lbmensajemodificar
            // 
            this.lbmensajemodificar.AutoSize = true;
            this.lbmensajemodificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmensajemodificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajemodificar.Location = new System.Drawing.Point(22, 322);
            this.lbmensajemodificar.Name = "lbmensajemodificar";
            this.lbmensajemodificar.Size = new System.Drawing.Size(597, 21);
            this.lbmensajemodificar.TabIndex = 22;
            this.lbmensajemodificar.Text = "Si fuera necesario puede modificar el  precio del producto y pulsar MODIFICAR DAT" +
    "OS";
            this.lbmensajemodificar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbinstruccion);
            this.panel1.Controls.Add(this.lbmensajemodificar);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.textBoxproductName);
            this.panel1.Controls.Add(this.lbsupplierID);
            this.panel1.Controls.Add(this.textBoxsupplierID);
            this.panel1.Controls.Add(this.cbCategorias);
            this.panel1.Controls.Add(this.lbCategoryID);
            this.panel1.Controls.Add(this.textBoxcategoryID);
            this.panel1.Controls.Add(this.lbcantidad);
            this.panel1.Controls.Add(this.textBoxcantidad);
            this.panel1.Controls.Add(this.textBoxprecioxunidad);
            this.panel1.Controls.Add(this.lbunitPrice);
            this.panel1.Location = new System.Drawing.Point(59, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 434);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // lbinstruccion
            // 
            this.lbinstruccion.AutoSize = true;
            this.lbinstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbinstruccion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinstruccion.Location = new System.Drawing.Point(22, 30);
            this.lbinstruccion.Name = "lbinstruccion";
            this.lbinstruccion.Size = new System.Drawing.Size(631, 28);
            this.lbinstruccion.TabIndex = 0;
            this.lbinstruccion.Text = "Siga las instrucciones para añadir producto y pulse AÑADIR PRODUCTO:";
            this.lbinstruccion.Visible = false;
            // 
            // ProductoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(973, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbsubtitulo);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.textBoxproductID);
            this.Controls.Add(this.bteliminarproducto);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.btañadirproducto);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ProductoView";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbsupplierID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbcantidad;
        private System.Windows.Forms.Label lbunitPrice;
        private System.Windows.Forms.TextBox textBoxproductID;
        private System.Windows.Forms.TextBox textBoxproductName;
        private System.Windows.Forms.TextBox textBoxsupplierID;
        private System.Windows.Forms.TextBox textBoxcategoryID;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxprecioxunidad;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btañadirproducto;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button bteliminarproducto;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbsubtitulo;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label lbmensajemodificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbinstruccion;
    }
}