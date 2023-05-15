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
            this.btAlta = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.bteliminarproducto = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lbgestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.lbmensajemodificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProductID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProductID.Location = new System.Drawing.Point(59, 189);
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
            this.lbProductName.Location = new System.Drawing.Point(59, 236);
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
            this.lbsupplierID.Location = new System.Drawing.Point(58, 283);
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
            this.lbCategoryID.Location = new System.Drawing.Point(57, 328);
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
            this.lbcantidad.Location = new System.Drawing.Point(56, 372);
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
            this.lbunitPrice.Location = new System.Drawing.Point(57, 420);
            this.lbunitPrice.Name = "lbunitPrice";
            this.lbunitPrice.Size = new System.Drawing.Size(82, 21);
            this.lbunitPrice.TabIndex = 5;
            this.lbunitPrice.Text = "Unit price:";
            // 
            // textBoxproductID
            // 
            this.textBoxproductID.Location = new System.Drawing.Point(274, 182);
            this.textBoxproductID.Name = "textBoxproductID";
            this.textBoxproductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxproductID.TabIndex = 6;
            // 
            // textBoxproductName
            // 
            this.textBoxproductName.Location = new System.Drawing.Point(274, 229);
            this.textBoxproductName.Name = "textBoxproductName";
            this.textBoxproductName.Size = new System.Drawing.Size(280, 20);
            this.textBoxproductName.TabIndex = 7;
            // 
            // textBoxsupplierID
            // 
            this.textBoxsupplierID.Location = new System.Drawing.Point(274, 276);
            this.textBoxsupplierID.Name = "textBoxsupplierID";
            this.textBoxsupplierID.Size = new System.Drawing.Size(280, 20);
            this.textBoxsupplierID.TabIndex = 8;
            // 
            // textBoxcategoryID
            // 
            this.textBoxcategoryID.Location = new System.Drawing.Point(447, 320);
            this.textBoxcategoryID.Name = "textBoxcategoryID";
            this.textBoxcategoryID.Size = new System.Drawing.Size(107, 20);
            this.textBoxcategoryID.TabIndex = 9;
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(274, 372);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(280, 20);
            this.textBoxcantidad.TabIndex = 10;
            // 
            // textBoxprecioxunidad
            // 
            this.textBoxprecioxunidad.Location = new System.Drawing.Point(274, 420);
            this.textBoxprecioxunidad.Name = "textBoxprecioxunidad";
            this.textBoxprecioxunidad.Size = new System.Drawing.Size(280, 20);
            this.textBoxprecioxunidad.TabIndex = 11;
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(470, 182);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(75, 23);
            this.btConsulta.TabIndex = 12;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btAlta
            // 
            this.btAlta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlta.Location = new System.Drawing.Point(92, 514);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(99, 57);
            this.btAlta.TabIndex = 13;
            this.btAlta.Text = "Añadir producto";
            this.btAlta.UseVisualStyleBackColor = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(766, 514);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 57);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Borrar Datos";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(1023, 512);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(99, 63);
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
            this.bteliminarproducto.Location = new System.Drawing.Point(319, 514);
            this.bteliminarproducto.Name = "bteliminarproducto";
            this.bteliminarproducto.Size = new System.Drawing.Size(99, 57);
            this.bteliminarproducto.TabIndex = 16;
            this.bteliminarproducto.Text = "Eliminar Producto";
            this.bteliminarproducto.UseVisualStyleBackColor = false;
            this.bteliminarproducto.Click += new System.EventHandler(this.bteliminarproducto_Click);
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(274, 320);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbCategorias.TabIndex = 17;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // lbgestion
            // 
            this.lbgestion.AutoSize = true;
            this.lbgestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbgestion.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbgestion.Location = new System.Drawing.Point(59, 49);
            this.lbgestion.Name = "lbgestion";
            this.lbgestion.Size = new System.Drawing.Size(223, 35);
            this.lbgestion.TabIndex = 18;
            this.lbgestion.Text = "Gestión productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Introduzca el ID del producto:";
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(529, 514);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(99, 59);
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
            this.lbmensajemodificar.Location = new System.Drawing.Point(607, 421);
            this.lbmensajemodificar.Name = "lbmensajemodificar";
            this.lbmensajemodificar.Size = new System.Drawing.Size(597, 21);
            this.lbmensajemodificar.TabIndex = 22;
            this.lbmensajemodificar.Text = "Si fuera necesario puede modificar el  precio del producto y pulsar MODIFICAR DAT" +
    "OS";
            this.lbmensajemodificar.Visible = false;
            // 
            // ProductoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1222, 641);
            this.Controls.Add(this.lbmensajemodificar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbgestion);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.bteliminarproducto);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.textBoxprecioxunidad);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.textBoxcategoryID);
            this.Controls.Add(this.textBoxsupplierID);
            this.Controls.Add(this.textBoxproductName);
            this.Controls.Add(this.textBoxproductID);
            this.Controls.Add(this.lbunitPrice);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbsupplierID);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductID);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ProductoView";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
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
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button bteliminarproducto;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lbgestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label lbmensajemodificar;
    }
}