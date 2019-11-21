namespace PresentaciónWinForm
{
    partial class Proveedores
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
            this.btnContactosProveedor = new System.Windows.Forms.Button();
            this.btnCorredoresProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContactosProveedor
            // 
            this.btnContactosProveedor.Location = new System.Drawing.Point(28, 397);
            this.btnContactosProveedor.Name = "btnContactosProveedor";
            this.btnContactosProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnContactosProveedor.TabIndex = 20;
            this.btnContactosProveedor.Text = "Contactos";
            this.btnContactosProveedor.UseVisualStyleBackColor = true;
            this.btnContactosProveedor.Click += new System.EventHandler(this.btnContactosProveedor_Click);
            // 
            // btnCorredoresProveedor
            // 
            this.btnCorredoresProveedor.Location = new System.Drawing.Point(120, 397);
            this.btnCorredoresProveedor.Name = "btnCorredoresProveedor";
            this.btnCorredoresProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnCorredoresProveedor.TabIndex = 19;
            this.btnCorredoresProveedor.Text = "Corredores";
            this.btnCorredoresProveedor.UseVisualStyleBackColor = true;
            this.btnCorredoresProveedor.Click += new System.EventHandler(this.btnCorredoresProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(606, 397);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProveedor.TabIndex = 18;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProveedores.Location = new System.Drawing.Point(28, 30);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(745, 326);
            this.dgvProveedores.TabIndex = 17;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(698, 397);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProveedor.TabIndex = 16;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContactosProveedor);
            this.Controls.Add(this.btnCorredoresProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContactosProveedor;
        private System.Windows.Forms.Button btnCorredoresProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
    }
}