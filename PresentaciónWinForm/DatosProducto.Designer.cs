namespace PresentaciónWinForm
{
    partial class DatosProducto
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
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnAceptarProducto = new System.Windows.Forms.Button();
            this.txtPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.txtPorcentajeProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioCompraProducto = new System.Windows.Forms.TextBox();
            this.labPorcentajeProducto = new System.Windows.Forms.Label();
            this.txtStockMínimoProducto = new System.Windows.Forms.TextBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.labPrecioVentaProducto = new System.Windows.Forms.Label();
            this.labPrecioCompraProducto = new System.Windows.Forms.Label();
            this.labStockMínimoProducto = new System.Windows.Forms.Label();
            this.labStockProducto = new System.Windows.Forms.Label();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.txtDescripciónProducto = new System.Windows.Forms.TextBox();
            this.labMarcaProducto = new System.Windows.Forms.Label();
            this.labTipoProducto = new System.Windows.Forms.Label();
            this.labDescripciónProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Location = new System.Drawing.Point(379, 169);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProducto.TabIndex = 37;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnAceptarProducto
            // 
            this.btnAceptarProducto.Location = new System.Drawing.Point(264, 169);
            this.btnAceptarProducto.Name = "btnAceptarProducto";
            this.btnAceptarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarProducto.TabIndex = 36;
            this.btnAceptarProducto.Text = "Aceptar";
            this.btnAceptarProducto.UseVisualStyleBackColor = true;
            this.btnAceptarProducto.Click += new System.EventHandler(this.btnAceptarProducto_Click);
            // 
            // txtPrecioVentaProducto
            // 
            this.txtPrecioVentaProducto.Location = new System.Drawing.Point(593, 111);
            this.txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            this.txtPrecioVentaProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaProducto.TabIndex = 35;
            // 
            // txtPorcentajeProducto
            // 
            this.txtPorcentajeProducto.Location = new System.Drawing.Point(593, 24);
            this.txtPorcentajeProducto.Name = "txtPorcentajeProducto";
            this.txtPorcentajeProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeProducto.TabIndex = 34;
            // 
            // txtPrecioCompraProducto
            // 
            this.txtPrecioCompraProducto.Location = new System.Drawing.Point(593, 66);
            this.txtPrecioCompraProducto.Name = "txtPrecioCompraProducto";
            this.txtPrecioCompraProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompraProducto.TabIndex = 33;
            // 
            // labPorcentajeProducto
            // 
            this.labPorcentajeProducto.AutoSize = true;
            this.labPorcentajeProducto.Location = new System.Drawing.Point(516, 27);
            this.labPorcentajeProducto.Name = "labPorcentajeProducto";
            this.labPorcentajeProducto.Size = new System.Drawing.Size(61, 13);
            this.labPorcentajeProducto.TabIndex = 32;
            this.labPorcentajeProducto.Text = "Porcentaje:";
            // 
            // txtStockMínimoProducto
            // 
            this.txtStockMínimoProducto.Location = new System.Drawing.Point(354, 69);
            this.txtStockMínimoProducto.Name = "txtStockMínimoProducto";
            this.txtStockMínimoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtStockMínimoProducto.TabIndex = 31;
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(354, 24);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(100, 20);
            this.txtStockProducto.TabIndex = 30;
            // 
            // labPrecioVentaProducto
            // 
            this.labPrecioVentaProducto.AutoSize = true;
            this.labPrecioVentaProducto.Location = new System.Drawing.Point(506, 114);
            this.labPrecioVentaProducto.Name = "labPrecioVentaProducto";
            this.labPrecioVentaProducto.Size = new System.Drawing.Size(71, 13);
            this.labPrecioVentaProducto.TabIndex = 29;
            this.labPrecioVentaProducto.Text = "Precio Venta:";
            // 
            // labPrecioCompraProducto
            // 
            this.labPrecioCompraProducto.AutoSize = true;
            this.labPrecioCompraProducto.Location = new System.Drawing.Point(498, 68);
            this.labPrecioCompraProducto.Name = "labPrecioCompraProducto";
            this.labPrecioCompraProducto.Size = new System.Drawing.Size(79, 13);
            this.labPrecioCompraProducto.TabIndex = 28;
            this.labPrecioCompraProducto.Text = "Precio Compra:";
            // 
            // labStockMínimoProducto
            // 
            this.labStockMínimoProducto.AutoSize = true;
            this.labStockMínimoProducto.Location = new System.Drawing.Point(263, 72);
            this.labStockMínimoProducto.Name = "labStockMínimoProducto";
            this.labStockMínimoProducto.Size = new System.Drawing.Size(76, 13);
            this.labStockMínimoProducto.TabIndex = 27;
            this.labStockMínimoProducto.Text = "Stock Mínimo:";
            // 
            // labStockProducto
            // 
            this.labStockProducto.AutoSize = true;
            this.labStockProducto.Location = new System.Drawing.Point(301, 27);
            this.labStockProducto.Name = "labStockProducto";
            this.labStockProducto.Size = new System.Drawing.Size(38, 13);
            this.labStockProducto.TabIndex = 26;
            this.labStockProducto.Text = "Stock:";
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(120, 115);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaProducto.TabIndex = 25;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(120, 69);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtTipoProducto.TabIndex = 24;
            // 
            // txtDescripciónProducto
            // 
            this.txtDescripciónProducto.Location = new System.Drawing.Point(120, 23);
            this.txtDescripciónProducto.Name = "txtDescripciónProducto";
            this.txtDescripciónProducto.Size = new System.Drawing.Size(100, 20);
            this.txtDescripciónProducto.TabIndex = 23;
            // 
            // labMarcaProducto
            // 
            this.labMarcaProducto.AutoSize = true;
            this.labMarcaProducto.Location = new System.Drawing.Point(67, 118);
            this.labMarcaProducto.Name = "labMarcaProducto";
            this.labMarcaProducto.Size = new System.Drawing.Size(40, 13);
            this.labMarcaProducto.TabIndex = 22;
            this.labMarcaProducto.Text = "Marca:";
            // 
            // labTipoProducto
            // 
            this.labTipoProducto.AutoSize = true;
            this.labTipoProducto.Location = new System.Drawing.Point(76, 72);
            this.labTipoProducto.Name = "labTipoProducto";
            this.labTipoProducto.Size = new System.Drawing.Size(31, 13);
            this.labTipoProducto.TabIndex = 21;
            this.labTipoProducto.Text = "Tipo:";
            // 
            // labDescripciónProducto
            // 
            this.labDescripciónProducto.AutoSize = true;
            this.labDescripciónProducto.Location = new System.Drawing.Point(41, 26);
            this.labDescripciónProducto.Name = "labDescripciónProducto";
            this.labDescripciónProducto.Size = new System.Drawing.Size(66, 13);
            this.labDescripciónProducto.TabIndex = 20;
            this.labDescripciónProducto.Text = "Descripción:";
            // 
            // DatosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 215);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnAceptarProducto);
            this.Controls.Add(this.txtPrecioVentaProducto);
            this.Controls.Add(this.txtPorcentajeProducto);
            this.Controls.Add(this.txtPrecioCompraProducto);
            this.Controls.Add(this.labPorcentajeProducto);
            this.Controls.Add(this.txtStockMínimoProducto);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.labPrecioVentaProducto);
            this.Controls.Add(this.labPrecioCompraProducto);
            this.Controls.Add(this.labStockMínimoProducto);
            this.Controls.Add(this.labStockProducto);
            this.Controls.Add(this.txtMarcaProducto);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.txtDescripciónProducto);
            this.Controls.Add(this.labMarcaProducto);
            this.Controls.Add(this.labTipoProducto);
            this.Controls.Add(this.labDescripciónProducto);
            this.Name = "DatosProducto";
            this.Text = "DatosProducto";
            this.Load += new System.EventHandler(this.DatosProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnAceptarProducto;
        private System.Windows.Forms.TextBox txtPrecioVentaProducto;
        private System.Windows.Forms.TextBox txtPorcentajeProducto;
        private System.Windows.Forms.TextBox txtPrecioCompraProducto;
        private System.Windows.Forms.Label labPorcentajeProducto;
        private System.Windows.Forms.TextBox txtStockMínimoProducto;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label labPrecioVentaProducto;
        private System.Windows.Forms.Label labPrecioCompraProducto;
        private System.Windows.Forms.Label labStockMínimoProducto;
        private System.Windows.Forms.Label labStockProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.TextBox txtDescripciónProducto;
        private System.Windows.Forms.Label labMarcaProducto;
        private System.Windows.Forms.Label labTipoProducto;
        private System.Windows.Forms.Label labDescripciónProducto;
    }
}