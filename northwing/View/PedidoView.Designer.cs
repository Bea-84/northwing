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
            this.lbsubtitulo = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbinstruccion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulo.Location = new System.Drawing.Point(46, 51);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(162, 35);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Crear Pedido";
            // 
            // lbsubtitulo
            // 
            this.lbsubtitulo.AutoSize = true;
            this.lbsubtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsubtitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsubtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsubtitulo.Location = new System.Drawing.Point(41, 119);
            this.lbsubtitulo.Name = "lbsubtitulo";
            this.lbsubtitulo.Size = new System.Drawing.Size(377, 28);
            this.lbsubtitulo.TabIndex = 1;
            this.lbsubtitulo.Text = "Introduzca su OrderID y pulse CONSULTAR";
            // 
            // lborderID
            // 
            this.lborderID.AutoSize = true;
            this.lborderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lborderID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborderID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lborderID.Location = new System.Drawing.Point(43, 178);
            this.lborderID.Name = "lborderID";
            this.lborderID.Size = new System.Drawing.Size(69, 21);
            this.lborderID.TabIndex = 2;
            this.lborderID.Text = "Order ID";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCustomerID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCustomerID.Location = new System.Drawing.Point(43, 97);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(94, 21);
            this.lbCustomerID.TabIndex = 3;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // lbEmployeID
            // 
            this.lbEmployeID.AutoSize = true;
            this.lbEmployeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbEmployeID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmployeID.Location = new System.Drawing.Point(43, 140);
            this.lbEmployeID.Name = "lbEmployeID";
            this.lbEmployeID.Size = new System.Drawing.Size(88, 21);
            this.lbEmployeID.TabIndex = 4;
            this.lbEmployeID.Text = "Employe ID";
            // 
            // lborderdate
            // 
            this.lborderdate.AutoSize = true;
            this.lborderdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lborderdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborderdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lborderdate.Location = new System.Drawing.Point(43, 185);
            this.lborderdate.Name = "lborderdate";
            this.lborderdate.Size = new System.Drawing.Size(87, 21);
            this.lborderdate.TabIndex = 5;
            this.lborderdate.Text = "Order Date";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbdireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdireccion.Location = new System.Drawing.Point(43, 232);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(75, 21);
            this.lbdireccion.TabIndex = 6;
            this.lbdireccion.Text = "Direccion";
            // 
            // lbcodigopostal
            // 
            this.lbcodigopostal.AutoSize = true;
            this.lbcodigopostal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbcodigopostal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigopostal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcodigopostal.Location = new System.Drawing.Point(42, 280);
            this.lbcodigopostal.Name = "lbcodigopostal";
            this.lbcodigopostal.Size = new System.Drawing.Size(104, 21);
            this.lbcodigopostal.TabIndex = 7;
            this.lbcodigopostal.Text = "Codigo Postal";
            // 
            // lbcountry
            // 
            this.lbcountry.AutoSize = true;
            this.lbcountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbcountry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcountry.Location = new System.Drawing.Point(42, 323);
            this.lbcountry.Name = "lbcountry";
            this.lbcountry.Size = new System.Drawing.Size(38, 21);
            this.lbcountry.TabIndex = 8;
            this.lbcountry.Text = "Pais";
            // 
            // textBoxorderID
            // 
            this.textBoxorderID.Location = new System.Drawing.Point(176, 179);
            this.textBoxorderID.Name = "textBoxorderID";
            this.textBoxorderID.Size = new System.Drawing.Size(130, 20);
            this.textBoxorderID.TabIndex = 9;
            // 
            // textBoxcustomerID
            // 
            this.textBoxcustomerID.Location = new System.Drawing.Point(255, 98);
            this.textBoxcustomerID.Name = "textBoxcustomerID";
            this.textBoxcustomerID.Size = new System.Drawing.Size(251, 20);
            this.textBoxcustomerID.TabIndex = 10;
            // 
            // cbEmployeID
            // 
            this.cbEmployeID.FormattingEnabled = true;
            this.cbEmployeID.Location = new System.Drawing.Point(255, 139);
            this.cbEmployeID.Name = "cbEmployeID";
            this.cbEmployeID.Size = new System.Drawing.Size(130, 21);
            this.cbEmployeID.TabIndex = 11;
            this.cbEmployeID.SelectedIndexChanged += new System.EventHandler(this.cbEmployeID_SelectedIndexChanged);
            // 
            // textBoxemployeID
            // 
            this.textBoxemployeID.Location = new System.Drawing.Point(406, 140);
            this.textBoxemployeID.Name = "textBoxemployeID";
            this.textBoxemployeID.Size = new System.Drawing.Size(100, 20);
            this.textBoxemployeID.TabIndex = 12;
            // 
            // textBoxorderdate
            // 
            this.textBoxorderdate.Location = new System.Drawing.Point(255, 185);
            this.textBoxorderdate.Name = "textBoxorderdate";
            this.textBoxorderdate.Size = new System.Drawing.Size(130, 20);
            this.textBoxorderdate.TabIndex = 13;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(255, 232);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(130, 20);
            this.textBoxdireccion.TabIndex = 14;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(255, 281);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(130, 20);
            this.textBoxCP.TabIndex = 15;
            // 
            // textBoxcountry
            // 
            this.textBoxcountry.Location = new System.Drawing.Point(255, 326);
            this.textBoxcountry.Name = "textBoxcountry";
            this.textBoxcountry.Size = new System.Drawing.Size(130, 20);
            this.textBoxcountry.TabIndex = 16;
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConsultar.Location = new System.Drawing.Point(399, 176);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(109, 23);
            this.btConsultar.TabIndex = 17;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btAlta
            // 
            this.btAlta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlta.Location = new System.Drawing.Point(88, 707);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(109, 40);
            this.btAlta.TabIndex = 18;
            this.btAlta.Text = "Crear Pedido";
            this.btAlta.UseVisualStyleBackColor = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(620, 176);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 23);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Borrar Datos";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(812, 703);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(109, 44);
            this.btSalir.TabIndex = 20;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // bteliminarpedido
            // 
            this.bteliminarpedido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bteliminarpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminarpedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bteliminarpedido.Location = new System.Drawing.Point(309, 703);
            this.bteliminarpedido.Name = "bteliminarpedido";
            this.bteliminarpedido.Size = new System.Drawing.Size(109, 44);
            this.bteliminarpedido.TabIndex = 21;
            this.bteliminarpedido.Text = "Eliminar Pedido";
            this.bteliminarpedido.UseVisualStyleBackColor = false;
            this.bteliminarpedido.Click += new System.EventHandler(this.bteliminarpedido_Click);
            // 
            // btmodificar
            // 
            this.btmodificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmodificar.Location = new System.Drawing.Point(565, 703);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(109, 44);
            this.btmodificar.TabIndex = 22;
            this.btmodificar.Text = "Modificar Datos";
            this.btmodificar.UseVisualStyleBackColor = false;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // lbmensajemodificar
            // 
            this.lbmensajemodificar.AutoSize = true;
            this.lbmensajemodificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmensajemodificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajemodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbmensajemodificar.Location = new System.Drawing.Point(88, 650);
            this.lbmensajemodificar.Name = "lbmensajemodificar";
            this.lbmensajemodificar.Size = new System.Drawing.Size(443, 21);
            this.lbmensajemodificar.TabIndex = 24;
            this.lbmensajemodificar.Text = "Si fuera necesario modifique su pais  y pulse MODIFICAR DATOS";
            this.lbmensajemodificar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbinstruccion);
            this.panel1.Controls.Add(this.lbCustomerID);
            this.panel1.Controls.Add(this.textBoxcustomerID);
            this.panel1.Controls.Add(this.lbEmployeID);
            this.panel1.Controls.Add(this.cbEmployeID);
            this.panel1.Controls.Add(this.textBoxemployeID);
            this.panel1.Controls.Add(this.lborderdate);
            this.panel1.Controls.Add(this.textBoxorderdate);
            this.panel1.Controls.Add(this.textBoxcountry);
            this.panel1.Controls.Add(this.lbdireccion);
            this.panel1.Controls.Add(this.textBoxCP);
            this.panel1.Controls.Add(this.lbcountry);
            this.panel1.Controls.Add(this.textBoxdireccion);
            this.panel1.Controls.Add(this.lbcodigopostal);
            this.panel1.Location = new System.Drawing.Point(46, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 383);
            this.panel1.TabIndex = 25;
            this.panel1.Visible = false;
            // 
            // lbinstruccion
            // 
            this.lbinstruccion.AutoSize = true;
            this.lbinstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbinstruccion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinstruccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbinstruccion.Location = new System.Drawing.Point(42, 35);
            this.lbinstruccion.Name = "lbinstruccion";
            this.lbinstruccion.Size = new System.Drawing.Size(586, 28);
            this.lbinstruccion.TabIndex = 0;
            this.lbinstruccion.Text = "Siga las instrucciones para crear un pedido y pulse CREAR PEDIDO:";
            this.lbinstruccion.Visible = false;
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(992, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbmensajemodificar);
            this.Controls.Add(this.bteliminarpedido);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.textBoxorderID);
            this.Controls.Add(this.lborderID);
            this.Controls.Add(this.lbsubtitulo);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.lbtitulo);
            this.Name = "PedidoView";
            this.Text = "PedidoView";
            this.Load += new System.EventHandler(this.PedidoView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Label lbsubtitulo;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbinstruccion;
    }
}