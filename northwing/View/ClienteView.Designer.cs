namespace northwing
{
    partial class ClienteView
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
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.labelciudad = new System.Windows.Forms.Label();
            this.labelpais = new System.Windows.Forms.Label();
            this.textBoxciudad = new System.Windows.Forms.TextBox();
            this.textBoxpais = new System.Windows.Forms.TextBox();
            this.btconsultar = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEliminarCliente = new System.Windows.Forms.Button();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbInstruccion = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            this.lbmensajepais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCustomer.Location = new System.Drawing.Point(49, 187);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(94, 21);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "CustomerID:";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(168, 186);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomer.TabIndex = 17;
            this.textBoxCustomer.TextChanged += new System.EventHandler(this.textBoxCustomer_TextChanged);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelnombre.Location = new System.Drawing.Point(49, 229);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(71, 21);
            this.labelnombre.TabIndex = 2;
            this.labelnombre.Text = "Nombre:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeldireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeldireccion.Location = new System.Drawing.Point(49, 275);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(79, 21);
            this.labeldireccion.TabIndex = 3;
            this.labeldireccion.Text = "Dirección:";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(168, 229);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(254, 20);
            this.textBoxnombre.TabIndex = 4;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBoxnombre_TextChanged);
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(168, 275);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(254, 20);
            this.textBoxdireccion.TabIndex = 5;
            this.textBoxdireccion.TextChanged += new System.EventHandler(this.textBoxdireccion_TextChanged);
            // 
            // labelciudad
            // 
            this.labelciudad.AutoSize = true;
            this.labelciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelciudad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelciudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelciudad.Location = new System.Drawing.Point(49, 320);
            this.labelciudad.Name = "labelciudad";
            this.labelciudad.Size = new System.Drawing.Size(62, 21);
            this.labelciudad.TabIndex = 6;
            this.labelciudad.Text = "Ciudad:";
            // 
            // labelpais
            // 
            this.labelpais.AutoSize = true;
            this.labelpais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelpais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelpais.Location = new System.Drawing.Point(49, 369);
            this.labelpais.Name = "labelpais";
            this.labelpais.Size = new System.Drawing.Size(42, 21);
            this.labelpais.TabIndex = 7;
            this.labelpais.Text = "Pais:";
            // 
            // textBoxciudad
            // 
            this.textBoxciudad.Location = new System.Drawing.Point(168, 320);
            this.textBoxciudad.Name = "textBoxciudad";
            this.textBoxciudad.Size = new System.Drawing.Size(254, 20);
            this.textBoxciudad.TabIndex = 8;
            this.textBoxciudad.TextChanged += new System.EventHandler(this.textBoxciudad_TextChanged);
            // 
            // textBoxpais
            // 
            this.textBoxpais.Location = new System.Drawing.Point(168, 369);
            this.textBoxpais.Name = "textBoxpais";
            this.textBoxpais.Size = new System.Drawing.Size(254, 20);
            this.textBoxpais.TabIndex = 9;
            this.textBoxpais.TextChanged += new System.EventHandler(this.textBoxpais_TextChanged);
            // 
            // btconsultar
            // 
            this.btconsultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconsultar.Location = new System.Drawing.Point(347, 185);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(75, 23);
            this.btconsultar.TabIndex = 10;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.UseVisualStyleBackColor = false;
            this.btconsultar.Click += new System.EventHandler(this.btconsultar_Click);
            // 
            // btAlta
            // 
            this.btAlta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlta.Location = new System.Drawing.Point(49, 452);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(114, 50);
            this.btAlta.TabIndex = 11;
            this.btAlta.Text = "Alta Cliente";
            this.btAlta.UseVisualStyleBackColor = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcancelar.Location = new System.Drawing.Point(212, 452);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(114, 50);
            this.btcancelar.TabIndex = 12;
            this.btcancelar.Text = "Borrar Datos";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(763, 452);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(114, 50);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEliminarCliente
            // 
            this.btEliminarCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminarCliente.Location = new System.Drawing.Point(384, 452);
            this.btEliminarCliente.Name = "btEliminarCliente";
            this.btEliminarCliente.Size = new System.Drawing.Size(114, 50);
            this.btEliminarCliente.TabIndex = 14;
            this.btEliminarCliente.Text = "Dar de baja a Cliente";
            this.btEliminarCliente.UseVisualStyleBackColor = false;
            this.btEliminarCliente.Click += new System.EventHandler(this.btEliminarCliente_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulo.Location = new System.Drawing.Point(49, 54);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(204, 35);
            this.lbtitulo.TabIndex = 15;
            this.lbtitulo.Text = "Gestión clientes:";
            // 
            // lbInstruccion
            // 
            this.lbInstruccion.AutoSize = true;
            this.lbInstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbInstruccion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInstruccion.Location = new System.Drawing.Point(49, 120);
            this.lbInstruccion.Name = "lbInstruccion";
            this.lbInstruccion.Size = new System.Drawing.Size(247, 28);
            this.lbInstruccion.TabIndex = 16;
            this.lbInstruccion.Text = "Introduzca su Customer ID:";
            // 
            // btmodificar
            // 
            this.btmodificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmodificar.Location = new System.Drawing.Point(562, 452);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(114, 50);
            this.btmodificar.TabIndex = 18;
            this.btmodificar.Text = "Modificar datos";
            this.btmodificar.UseVisualStyleBackColor = false;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // lbmensajepais
            // 
            this.lbmensajepais.AutoSize = true;
            this.lbmensajepais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmensajepais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajepais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmensajepais.Location = new System.Drawing.Point(479, 369);
            this.lbmensajepais.Name = "lbmensajepais";
            this.lbmensajepais.Size = new System.Drawing.Size(398, 21);
            this.lbmensajepais.TabIndex = 20;
            this.lbmensajepais.Text = "Si fuera necesario cambie su pais y pulse modificar datos";
            this.lbmensajepais.Visible = false;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(904, 564);
            this.Controls.Add(this.lbmensajepais);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.lbInstruccion);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.btEliminarCliente);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btconsultar);
            this.Controls.Add(this.textBoxpais);
            this.Controls.Add(this.textBoxciudad);
            this.Controls.Add(this.labelpais);
            this.Controls.Add(this.labelciudad);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Name = "ClienteView";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.Label labelciudad;
        private System.Windows.Forms.Label labelpais;
        private System.Windows.Forms.TextBox textBoxciudad;
        private System.Windows.Forms.TextBox textBoxpais;
        private System.Windows.Forms.Button btconsultar;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminarCliente;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbInstruccion;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Label lbmensajepais;
    }
}