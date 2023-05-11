namespace northwing.View
{
    partial class MenuView
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbseleccionar = new System.Windows.Forms.Label();
            this.btgestioncliente = new System.Windows.Forms.Button();
            this.btgestionproductos = new System.Windows.Forms.Button();
            this.btcrearpedido = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(205, 54);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(396, 35);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Bienvenidos a la BBDD Northwing";
            // 
            // lbseleccionar
            // 
            this.lbseleccionar.AutoSize = true;
            this.lbseleccionar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbseleccionar.Location = new System.Drawing.Point(68, 145);
            this.lbseleccionar.Name = "lbseleccionar";
            this.lbseleccionar.Size = new System.Drawing.Size(271, 26);
            this.lbseleccionar.TabIndex = 1;
            this.lbseleccionar.Text = "Seleccione la opción deseada:";
            // 
            // btgestioncliente
            // 
            this.btgestioncliente.Location = new System.Drawing.Point(143, 243);
            this.btgestioncliente.Name = "btgestioncliente";
            this.btgestioncliente.Size = new System.Drawing.Size(75, 51);
            this.btgestioncliente.TabIndex = 2;
            this.btgestioncliente.Text = "Gestión Clientes";
            this.btgestioncliente.UseVisualStyleBackColor = true;
            this.btgestioncliente.Click += new System.EventHandler(this.btgestioncliente_Click);
            // 
            // btgestionproductos
            // 
            this.btgestionproductos.Location = new System.Drawing.Point(357, 242);
            this.btgestionproductos.Name = "btgestionproductos";
            this.btgestionproductos.Size = new System.Drawing.Size(75, 52);
            this.btgestionproductos.TabIndex = 3;
            this.btgestionproductos.Text = "Gestión productos";
            this.btgestionproductos.UseVisualStyleBackColor = true;
            this.btgestionproductos.Click += new System.EventHandler(this.btgestionproductos_Click);
            // 
            // btcrearpedido
            // 
            this.btcrearpedido.Location = new System.Drawing.Point(583, 243);
            this.btcrearpedido.Name = "btcrearpedido";
            this.btcrearpedido.Size = new System.Drawing.Size(75, 52);
            this.btcrearpedido.TabIndex = 4;
            this.btcrearpedido.Text = "Crear pedidos";
            this.btcrearpedido.UseVisualStyleBackColor = true;
            this.btcrearpedido.Click += new System.EventHandler(this.btcrearpedido_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(583, 377);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btcrearpedido);
            this.Controls.Add(this.btgestionproductos);
            this.Controls.Add(this.btgestioncliente);
            this.Controls.Add(this.lbseleccionar);
            this.Controls.Add(this.lbtitulo);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbseleccionar;
        private System.Windows.Forms.Button btgestioncliente;
        private System.Windows.Forms.Button btgestionproductos;
        private System.Windows.Forms.Button btcrearpedido;
        private System.Windows.Forms.Button btSalir;
    }
}