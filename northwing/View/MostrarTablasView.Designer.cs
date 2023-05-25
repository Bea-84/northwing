namespace northwing
{
    partial class MostrarTablasView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btmostrarproductos = new System.Windows.Forms.Button();
            this.btmostrarpedidos = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btCustomer
            // 
            this.btCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCustomer.Location = new System.Drawing.Point(74, 45);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(123, 82);
            this.btCustomer.TabIndex = 1;
            this.btCustomer.Text = "Mostrar tabla customers";
            this.btCustomer.UseVisualStyleBackColor = false;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btmostrarproductos
            // 
            this.btmostrarproductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmostrarproductos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmostrarproductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmostrarproductos.Location = new System.Drawing.Point(406, 45);
            this.btmostrarproductos.Name = "btmostrarproductos";
            this.btmostrarproductos.Size = new System.Drawing.Size(126, 82);
            this.btmostrarproductos.TabIndex = 2;
            this.btmostrarproductos.Text = "Mostrar tabla productos";
            this.btmostrarproductos.UseVisualStyleBackColor = false;
            this.btmostrarproductos.Click += new System.EventHandler(this.btmostrarproductos_Click);
            // 
            // btmostrarpedidos
            // 
            this.btmostrarpedidos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmostrarpedidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmostrarpedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmostrarpedidos.Location = new System.Drawing.Point(766, 45);
            this.btmostrarpedidos.Name = "btmostrarpedidos";
            this.btmostrarpedidos.Size = new System.Drawing.Size(126, 82);
            this.btmostrarpedidos.TabIndex = 3;
            this.btmostrarpedidos.Text = "Mostrar tabla pedidos";
            this.btmostrarpedidos.UseVisualStyleBackColor = false;
            this.btmostrarpedidos.Click += new System.EventHandler(this.btmostrarpedidos_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(817, 632);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MostrarTablasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(975, 703);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btmostrarpedidos);
            this.Controls.Add(this.btmostrarproductos);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MostrarTablasView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btmostrarproductos;
        private System.Windows.Forms.Button btmostrarpedidos;
        private System.Windows.Forms.Button btSalir;
    }
}

