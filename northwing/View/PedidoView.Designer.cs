﻿namespace northwing.View
{
    partial class PedidoView
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
            this.lbindicacion = new System.Windows.Forms.Label();
            this.lborderID = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbEmployeID = new System.Windows.Forms.Label();
            this.lborderdate = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.lbcodigopostal = new System.Windows.Forms.Label();
            this.lbcountry = new System.Windows.Forms.Label();
            this.textBoxorderID = new System.Windows.Forms.TextBox();
            this.textBoxcustomerID = new System.Windows.Forms.TextBox();
            this.cbEmployeID = new System.Windows.Forms.ComboBox();
            this.textBoxemployeID = new System.Windows.Forms.TextBox();
            this.textBoxorderdate = new System.Windows.Forms.TextBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxcountry = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.bteliminarpedido = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.lbmensajemodificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(46, 51);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(162, 35);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Crear Pedido";
            // 
            // lbindicacion
            // 
            this.lbindicacion.AutoSize = true;
            this.lbindicacion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbindicacion.Location = new System.Drawing.Point(41, 119);
            this.lbindicacion.Name = "lbindicacion";
            this.lbindicacion.Size = new System.Drawing.Size(176, 26);
            this.lbindicacion.TabIndex = 1;
            this.lbindicacion.Text = "Indique su OrderID";
            // 
            // lborderID
            // 
            this.lborderID.AutoSize = true;
            this.lborderID.Location = new System.Drawing.Point(43, 178);
            this.lborderID.Name = "lborderID";
            this.lborderID.Size = new System.Drawing.Size(47, 13);
            this.lborderID.TabIndex = 2;
            this.lborderID.Text = "Order ID";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(43, 220);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lbCustomerID.TabIndex = 3;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // lbEmployeID
            // 
            this.lbEmployeID.AutoSize = true;
            this.lbEmployeID.Location = new System.Drawing.Point(43, 259);
            this.lbEmployeID.Name = "lbEmployeID";
            this.lbEmployeID.Size = new System.Drawing.Size(61, 13);
            this.lbEmployeID.TabIndex = 4;
            this.lbEmployeID.Text = "Employe ID";
            // 
            // lborderdate
            // 
            this.lborderdate.AutoSize = true;
            this.lborderdate.Location = new System.Drawing.Point(43, 304);
            this.lborderdate.Name = "lborderdate";
            this.lborderdate.Size = new System.Drawing.Size(59, 13);
            this.lborderdate.TabIndex = 5;
            this.lborderdate.Text = "Order Date";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Location = new System.Drawing.Point(43, 344);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(52, 13);
            this.lbdireccion.TabIndex = 6;
            this.lbdireccion.Text = "Direccion";
            // 
            // lbcodigopostal
            // 
            this.lbcodigopostal.AutoSize = true;
            this.lbcodigopostal.Location = new System.Drawing.Point(43, 389);
            this.lbcodigopostal.Name = "lbcodigopostal";
            this.lbcodigopostal.Size = new System.Drawing.Size(72, 13);
            this.lbcodigopostal.TabIndex = 7;
            this.lbcodigopostal.Text = "Codigo Postal";
            // 
            // lbcountry
            // 
            this.lbcountry.AutoSize = true;
            this.lbcountry.Location = new System.Drawing.Point(46, 437);
            this.lbcountry.Name = "lbcountry";
            this.lbcountry.Size = new System.Drawing.Size(27, 13);
            this.lbcountry.TabIndex = 8;
            this.lbcountry.Text = "Pais";
            // 
            // textBoxorderID
            // 
            this.textBoxorderID.Location = new System.Drawing.Point(201, 175);
            this.textBoxorderID.Name = "textBoxorderID";
            this.textBoxorderID.Size = new System.Drawing.Size(130, 20);
            this.textBoxorderID.TabIndex = 9;
            // 
            // textBoxcustomerID
            // 
            this.textBoxcustomerID.Location = new System.Drawing.Point(201, 213);
            this.textBoxcustomerID.Name = "textBoxcustomerID";
            this.textBoxcustomerID.Size = new System.Drawing.Size(251, 20);
            this.textBoxcustomerID.TabIndex = 10;
            // 
            // cbEmployeID
            // 
            this.cbEmployeID.FormattingEnabled = true;
            this.cbEmployeID.Location = new System.Drawing.Point(201, 251);
            this.cbEmployeID.Name = "cbEmployeID";
            this.cbEmployeID.Size = new System.Drawing.Size(130, 21);
            this.cbEmployeID.TabIndex = 11;
            this.cbEmployeID.SelectedIndexChanged += new System.EventHandler(this.cbEmployeID_SelectedIndexChanged);
            // 
            // textBoxemployeID
            // 
            this.textBoxemployeID.Location = new System.Drawing.Point(352, 252);
            this.textBoxemployeID.Name = "textBoxemployeID";
            this.textBoxemployeID.Size = new System.Drawing.Size(100, 20);
            this.textBoxemployeID.TabIndex = 12;
            // 
            // textBoxorderdate
            // 
            this.textBoxorderdate.Location = new System.Drawing.Point(201, 297);
            this.textBoxorderdate.Name = "textBoxorderdate";
            this.textBoxorderdate.Size = new System.Drawing.Size(130, 20);
            this.textBoxorderdate.TabIndex = 13;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(201, 337);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(130, 20);
            this.textBoxdireccion.TabIndex = 14;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(201, 382);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(130, 20);
            this.textBoxCP.TabIndex = 15;
            // 
            // textBoxcountry
            // 
            this.textBoxcountry.Location = new System.Drawing.Point(201, 430);
            this.textBoxcountry.Name = "textBoxcountry";
            this.textBoxcountry.Size = new System.Drawing.Size(130, 20);
            this.textBoxcountry.TabIndex = 16;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(377, 172);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 17;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(201, 499);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(75, 40);
            this.btAlta.TabIndex = 18;
            this.btAlta.Text = "Crear Pedido";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(429, 579);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Borrar Datos";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(675, 579);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 20;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // bteliminarpedido
            // 
            this.bteliminarpedido.Location = new System.Drawing.Point(429, 497);
            this.bteliminarpedido.Name = "bteliminarpedido";
            this.bteliminarpedido.Size = new System.Drawing.Size(75, 44);
            this.bteliminarpedido.TabIndex = 21;
            this.bteliminarpedido.Text = "Eliminar Pedido";
            this.bteliminarpedido.UseVisualStyleBackColor = true;
            this.bteliminarpedido.Click += new System.EventHandler(this.bteliminarpedido_Click);
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(675, 495);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 44);
            this.btmodificar.TabIndex = 22;
            this.btmodificar.Text = "Modificar Datos";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // lbmensajemodificar
            // 
            this.lbmensajemodificar.AutoSize = true;
            this.lbmensajemodificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajemodificar.Location = new System.Drawing.Point(511, 430);
            this.lbmensajemodificar.Name = "lbmensajemodificar";
            this.lbmensajemodificar.Size = new System.Drawing.Size(441, 19);
            this.lbmensajemodificar.TabIndex = 24;
            this.lbmensajemodificar.Text = "Si fuera necesario modifique su pais  y pulse MODIFICAR DATOS";
            this.lbmensajemodificar.Visible = false;
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 634);
            this.Controls.Add(this.lbmensajemodificar);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.bteliminarpedido);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.textBoxcountry);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxorderdate);
            this.Controls.Add(this.textBoxemployeID);
            this.Controls.Add(this.cbEmployeID);
            this.Controls.Add(this.textBoxcustomerID);
            this.Controls.Add(this.textBoxorderID);
            this.Controls.Add(this.lbcountry);
            this.Controls.Add(this.lbcodigopostal);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.lborderdate);
            this.Controls.Add(this.lbEmployeID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.lborderID);
            this.Controls.Add(this.lbindicacion);
            this.Controls.Add(this.lbtitulo);
            this.Name = "PedidoView";
            this.Text = "PedidoView";
            this.Load += new System.EventHandler(this.PedidoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbindicacion;
        private System.Windows.Forms.Label lborderID;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbEmployeID;
        private System.Windows.Forms.Label lborderdate;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.Label lbcodigopostal;
        private System.Windows.Forms.Label lbcountry;
        private System.Windows.Forms.TextBox textBoxorderID;
        private System.Windows.Forms.TextBox textBoxcustomerID;
        private System.Windows.Forms.ComboBox cbEmployeID;
        private System.Windows.Forms.TextBox textBoxemployeID;
        private System.Windows.Forms.TextBox textBoxorderdate;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxcountry;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button bteliminarpedido;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Label lbmensajemodificar;
    }
}