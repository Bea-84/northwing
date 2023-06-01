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
            this.btborrardatos = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btbajaCliente = new System.Windows.Forms.Button();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbsubtitulo = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            this.lbmensajepais = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbinstruccion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCustomer.Location = new System.Drawing.Point(65, 228);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(117, 26);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "CustomerID:";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(255, 230);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(132, 22);
            this.textBoxCustomer.TabIndex = 17;
            this.textBoxCustomer.TextChanged += new System.EventHandler(this.textBoxCustomer_TextChanged);
            this.textBoxCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCustomer_KeyPress);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelnombre.Location = new System.Drawing.Point(37, 107);
            this.labelnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(86, 26);
            this.labelnombre.TabIndex = 2;
            this.labelnombre.Text = "Nombre:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeldireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeldireccion.Location = new System.Drawing.Point(37, 169);
            this.labeldireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(96, 26);
            this.labeldireccion.TabIndex = 3;
            this.labeldireccion.Text = "Dirección:";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(189, 107);
            this.textBoxnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(337, 22);
            this.textBoxnombre.TabIndex = 4;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBoxnombre_TextChanged);
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(189, 170);
            this.textBoxdireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(337, 22);
            this.textBoxdireccion.TabIndex = 5;
            this.textBoxdireccion.TextChanged += new System.EventHandler(this.textBoxdireccion_TextChanged);
            // 
            // labelciudad
            // 
            this.labelciudad.AutoSize = true;
            this.labelciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelciudad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelciudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelciudad.Location = new System.Drawing.Point(37, 225);
            this.labelciudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelciudad.Name = "labelciudad";
            this.labelciudad.Size = new System.Drawing.Size(77, 26);
            this.labelciudad.TabIndex = 6;
            this.labelciudad.Text = "Ciudad:";
            // 
            // labelpais
            // 
            this.labelpais.AutoSize = true;
            this.labelpais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelpais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelpais.Location = new System.Drawing.Point(37, 345);
            this.labelpais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpais.Name = "labelpais";
            this.labelpais.Size = new System.Drawing.Size(52, 26);
            this.labelpais.TabIndex = 7;
            this.labelpais.Text = "Pais:";
            // 
            // textBoxciudad
            // 
            this.textBoxciudad.Location = new System.Drawing.Point(189, 226);
            this.textBoxciudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxciudad.Name = "textBoxciudad";
            this.textBoxciudad.Size = new System.Drawing.Size(337, 22);
            this.textBoxciudad.TabIndex = 8;
            this.textBoxciudad.TextChanged += new System.EventHandler(this.textBoxciudad_TextChanged);
            // 
            // textBoxpais
            // 
            this.textBoxpais.Location = new System.Drawing.Point(189, 345);
            this.textBoxpais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxpais.Name = "textBoxpais";
            this.textBoxpais.Size = new System.Drawing.Size(337, 22);
            this.textBoxpais.TabIndex = 9;
            this.textBoxpais.TextChanged += new System.EventHandler(this.textBoxpais_TextChanged);
            this.textBoxpais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxpais_KeyPress);
            // 
            // btconsultar
            // 
            this.btconsultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconsultar.Location = new System.Drawing.Point(472, 225);
            this.btconsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(155, 28);
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
            this.btAlta.Location = new System.Drawing.Point(103, 773);
            this.btAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(152, 62);
            this.btAlta.TabIndex = 11;
            this.btAlta.Text = "Alta Cliente";
            this.btAlta.UseVisualStyleBackColor = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btborrardatos
            // 
            this.btborrardatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btborrardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btborrardatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btborrardatos.Location = new System.Drawing.Point(720, 225);
            this.btborrardatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btborrardatos.Name = "btborrardatos";
            this.btborrardatos.Size = new System.Drawing.Size(155, 28);
            this.btborrardatos.TabIndex = 12;
            this.btborrardatos.Text = "Borrar Datos";
            this.btborrardatos.UseVisualStyleBackColor = false;
            this.btborrardatos.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(955, 773);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(152, 62);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btbajaCliente
            // 
            this.btbajaCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbajaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbajaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbajaCliente.Location = new System.Drawing.Point(365, 773);
            this.btbajaCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbajaCliente.Name = "btbajaCliente";
            this.btbajaCliente.Size = new System.Drawing.Size(152, 62);
            this.btbajaCliente.TabIndex = 14;
            this.btbajaCliente.Text = "Dar de baja a Cliente";
            this.btbajaCliente.UseVisualStyleBackColor = false;
            this.btbajaCliente.Click += new System.EventHandler(this.btEliminarCliente_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulo.Location = new System.Drawing.Point(65, 66);
            this.lbtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(254, 43);
            this.lbtitulo.TabIndex = 15;
            this.lbtitulo.Text = "Gestión clientes:";
            // 
            // lbsubtitulo
            // 
            this.lbsubtitulo.AutoSize = true;
            this.lbsubtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsubtitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsubtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsubtitulo.Location = new System.Drawing.Point(65, 148);
            this.lbsubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsubtitulo.Name = "lbsubtitulo";
            this.lbsubtitulo.Size = new System.Drawing.Size(541, 35);
            this.lbsubtitulo.TabIndex = 16;
            this.lbsubtitulo.Text = "Introduzca su Customer ID y pulse CONSULTAR:";
            // 
            // btmodificar
            // 
            this.btmodificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmodificar.Location = new System.Drawing.Point(672, 773);
            this.btmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(152, 62);
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
            this.lbmensajepais.Location = new System.Drawing.Point(37, 287);
            this.lbmensajepais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmensajepais.Name = "lbmensajepais";
            this.lbmensajepais.Size = new System.Drawing.Size(586, 26);
            this.lbmensajepais.TabIndex = 20;
            this.lbmensajepais.Text = "Si fuera necesario puede cambiar su pais y pulsar MODIFICAR DATOS";
            this.lbmensajepais.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbinstruccion);
            this.panel1.Controls.Add(this.labelnombre);
            this.panel1.Controls.Add(this.labeldireccion);
            this.panel1.Controls.Add(this.lbmensajepais);
            this.panel1.Controls.Add(this.labelciudad);
            this.panel1.Controls.Add(this.textBoxnombre);
            this.panel1.Controls.Add(this.textBoxdireccion);
            this.panel1.Controls.Add(this.textBoxciudad);
            this.panel1.Controls.Add(this.labelpais);
            this.panel1.Controls.Add(this.textBoxpais);
            this.panel1.Location = new System.Drawing.Point(65, 295);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 428);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // lbinstruccion
            // 
            this.lbinstruccion.AutoSize = true;
            this.lbinstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbinstruccion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinstruccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbinstruccion.Location = new System.Drawing.Point(37, 38);
            this.lbinstruccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbinstruccion.Name = "lbinstruccion";
            this.lbinstruccion.Size = new System.Drawing.Size(752, 35);
            this.lbinstruccion.TabIndex = 0;
            this.lbinstruccion.Text = "Rellene todos los campos  para darse de alta y pulse ALTA CLIENTE";
            this.lbinstruccion.Visible = false;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1212, 880);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.lbsubtitulo);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btborrardatos);
            this.Controls.Add(this.btbajaCliente);
            this.Controls.Add(this.btconsultar);
            this.Controls.Add(this.btAlta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClienteView";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btborrardatos;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btbajaCliente;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbsubtitulo;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Label lbmensajepais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbinstruccion;
    }
}