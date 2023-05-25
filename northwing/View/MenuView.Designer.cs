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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            this.lbseleccionar = new System.Windows.Forms.Label();
            this.btgestioncliente = new System.Windows.Forms.Button();
            this.btgestionproductos = new System.Windows.Forms.Button();
            this.btcrearpedido = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.BTLogotipo = new System.Windows.Forms.Button();
            this.btmostrarTablas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbseleccionar
            // 
            this.lbseleccionar.AutoSize = true;
            this.lbseleccionar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbseleccionar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbseleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbseleccionar.Location = new System.Drawing.Point(48, 453);
            this.lbseleccionar.Name = "lbseleccionar";
            this.lbseleccionar.Size = new System.Drawing.Size(273, 28);
            this.lbseleccionar.TabIndex = 1;
            this.lbseleccionar.Text = "Seleccione la opción deseada:";
            // 
            // btgestioncliente
            // 
            this.btgestioncliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btgestioncliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgestioncliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btgestioncliente.Location = new System.Drawing.Point(48, 556);
            this.btgestioncliente.Name = "btgestioncliente";
            this.btgestioncliente.Size = new System.Drawing.Size(127, 61);
            this.btgestioncliente.TabIndex = 2;
            this.btgestioncliente.Text = "Gestión Clientes";
            this.btgestioncliente.UseVisualStyleBackColor = false;
            this.btgestioncliente.Click += new System.EventHandler(this.btgestioncliente_Click);
            // 
            // btgestionproductos
            // 
            this.btgestionproductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btgestionproductos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgestionproductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btgestionproductos.Location = new System.Drawing.Point(302, 556);
            this.btgestionproductos.Name = "btgestionproductos";
            this.btgestionproductos.Size = new System.Drawing.Size(127, 61);
            this.btgestionproductos.TabIndex = 3;
            this.btgestionproductos.Text = "Gestión productos";
            this.btgestionproductos.UseVisualStyleBackColor = false;
            this.btgestionproductos.Click += new System.EventHandler(this.btgestionproductos_Click);
            // 
            // btcrearpedido
            // 
            this.btcrearpedido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btcrearpedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcrearpedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcrearpedido.Location = new System.Drawing.Point(558, 556);
            this.btcrearpedido.Name = "btcrearpedido";
            this.btcrearpedido.Size = new System.Drawing.Size(125, 61);
            this.btcrearpedido.TabIndex = 4;
            this.btcrearpedido.Text = "Crear pedidos";
            this.btcrearpedido.UseVisualStyleBackColor = false;
            this.btcrearpedido.Click += new System.EventHandler(this.btcrearpedido_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(1060, 556);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(125, 61);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // BTLogotipo
            // 
            this.BTLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("BTLogotipo.Image")));
            this.BTLogotipo.Location = new System.Drawing.Point(443, 63);
            this.BTLogotipo.Name = "BTLogotipo";
            this.BTLogotipo.Size = new System.Drawing.Size(364, 338);
            this.BTLogotipo.TabIndex = 6;
            this.BTLogotipo.UseVisualStyleBackColor = true;
            // 
            // btmostrarTablas
            // 
            this.btmostrarTablas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmostrarTablas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmostrarTablas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmostrarTablas.Location = new System.Drawing.Point(817, 556);
            this.btmostrarTablas.Name = "btmostrarTablas";
            this.btmostrarTablas.Size = new System.Drawing.Size(125, 61);
            this.btmostrarTablas.TabIndex = 7;
            this.btmostrarTablas.Text = "Mostrar tablas";
            this.btmostrarTablas.UseVisualStyleBackColor = false;
            this.btmostrarTablas.Click += new System.EventHandler(this.btmostrarTablas_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1253, 672);
            this.Controls.Add(this.btmostrarTablas);
            this.Controls.Add(this.BTLogotipo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btcrearpedido);
            this.Controls.Add(this.btgestionproductos);
            this.Controls.Add(this.btgestioncliente);
            this.Controls.Add(this.lbseleccionar);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbseleccionar;
        private System.Windows.Forms.Button btgestioncliente;
        private System.Windows.Forms.Button btgestionproductos;
        private System.Windows.Forms.Button btcrearpedido;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button BTLogotipo;
        private System.Windows.Forms.Button btmostrarTablas;
    }
}