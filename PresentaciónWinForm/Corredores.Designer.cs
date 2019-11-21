namespace PresentaciónWinForm
{
    partial class Corredores
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
            this.txtNúmeroCorredor = new System.Windows.Forms.TextBox();
            this.labNúmeroCorredor = new System.Windows.Forms.Label();
            this.btnCancelarCorredor = new System.Windows.Forms.Button();
            this.btnAgregarCorredor = new System.Windows.Forms.Button();
            this.btnModificarCorredor = new System.Windows.Forms.Button();
            this.dgvCorredor = new System.Windows.Forms.DataGridView();
            this.txtMailCorredor = new System.Windows.Forms.TextBox();
            this.txtCelularCorredor = new System.Windows.Forms.TextBox();
            this.txtTelCorredor = new System.Windows.Forms.TextBox();
            this.txtApellidoCorredor = new System.Windows.Forms.TextBox();
            this.txtNombreCorredor = new System.Windows.Forms.TextBox();
            this.txtIdProveedorCorredor = new System.Windows.Forms.TextBox();
            this.labMailCorredor = new System.Windows.Forms.Label();
            this.labCelularCorredor = new System.Windows.Forms.Label();
            this.labTelCorredor = new System.Windows.Forms.Label();
            this.labApellidoCorredor = new System.Windows.Forms.Label();
            this.labNombreCorredor = new System.Windows.Forms.Label();
            this.labIdProveedorCorredor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorredor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNúmeroCorredor
            // 
            this.txtNúmeroCorredor.Location = new System.Drawing.Point(109, 69);
            this.txtNúmeroCorredor.Name = "txtNúmeroCorredor";
            this.txtNúmeroCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtNúmeroCorredor.TabIndex = 88;
            // 
            // labNúmeroCorredor
            // 
            this.labNúmeroCorredor.AutoSize = true;
            this.labNúmeroCorredor.Location = new System.Drawing.Point(54, 72);
            this.labNúmeroCorredor.Name = "labNúmeroCorredor";
            this.labNúmeroCorredor.Size = new System.Drawing.Size(47, 13);
            this.labNúmeroCorredor.TabIndex = 87;
            this.labNúmeroCorredor.Text = "Número:";
            // 
            // btnCancelarCorredor
            // 
            this.btnCancelarCorredor.Location = new System.Drawing.Point(123, 337);
            this.btnCancelarCorredor.Name = "btnCancelarCorredor";
            this.btnCancelarCorredor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCorredor.TabIndex = 86;
            this.btnCancelarCorredor.Text = "Cancelar";
            this.btnCancelarCorredor.UseVisualStyleBackColor = true;
            this.btnCancelarCorredor.Click += new System.EventHandler(this.btnCancelarCorredor_Click);
            // 
            // btnAgregarCorredor
            // 
            this.btnAgregarCorredor.Location = new System.Drawing.Point(735, 337);
            this.btnAgregarCorredor.Name = "btnAgregarCorredor";
            this.btnAgregarCorredor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCorredor.TabIndex = 85;
            this.btnAgregarCorredor.Text = "Agregar";
            this.btnAgregarCorredor.UseVisualStyleBackColor = true;
            this.btnAgregarCorredor.Click += new System.EventHandler(this.btnAgregarCorredor_Click);
            // 
            // btnModificarCorredor
            // 
            this.btnModificarCorredor.Location = new System.Drawing.Point(642, 337);
            this.btnModificarCorredor.Name = "btnModificarCorredor";
            this.btnModificarCorredor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCorredor.TabIndex = 84;
            this.btnModificarCorredor.Text = "Modificar";
            this.btnModificarCorredor.UseVisualStyleBackColor = true;
            this.btnModificarCorredor.Click += new System.EventHandler(this.btnModificarCorredor_Click);
            // 
            // dgvCorredor
            // 
            this.dgvCorredor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCorredor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorredor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCorredor.Location = new System.Drawing.Point(244, 28);
            this.dgvCorredor.MultiSelect = false;
            this.dgvCorredor.Name = "dgvCorredor";
            this.dgvCorredor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorredor.Size = new System.Drawing.Size(566, 281);
            this.dgvCorredor.TabIndex = 83;
            // 
            // txtMailCorredor
            // 
            this.txtMailCorredor.Location = new System.Drawing.Point(109, 289);
            this.txtMailCorredor.Name = "txtMailCorredor";
            this.txtMailCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtMailCorredor.TabIndex = 82;
            // 
            // txtCelularCorredor
            // 
            this.txtCelularCorredor.Location = new System.Drawing.Point(109, 244);
            this.txtCelularCorredor.Name = "txtCelularCorredor";
            this.txtCelularCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtCelularCorredor.TabIndex = 81;
            // 
            // txtTelCorredor
            // 
            this.txtTelCorredor.Location = new System.Drawing.Point(109, 203);
            this.txtTelCorredor.Name = "txtTelCorredor";
            this.txtTelCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtTelCorredor.TabIndex = 80;
            // 
            // txtApellidoCorredor
            // 
            this.txtApellidoCorredor.Location = new System.Drawing.Point(109, 158);
            this.txtApellidoCorredor.Name = "txtApellidoCorredor";
            this.txtApellidoCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCorredor.TabIndex = 79;
            // 
            // txtNombreCorredor
            // 
            this.txtNombreCorredor.Location = new System.Drawing.Point(109, 113);
            this.txtNombreCorredor.Name = "txtNombreCorredor";
            this.txtNombreCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCorredor.TabIndex = 78;
            // 
            // txtIdProveedorCorredor
            // 
            this.txtIdProveedorCorredor.Location = new System.Drawing.Point(109, 28);
            this.txtIdProveedorCorredor.Name = "txtIdProveedorCorredor";
            this.txtIdProveedorCorredor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedorCorredor.TabIndex = 77;
            // 
            // labMailCorredor
            // 
            this.labMailCorredor.AutoSize = true;
            this.labMailCorredor.Location = new System.Drawing.Point(72, 292);
            this.labMailCorredor.Name = "labMailCorredor";
            this.labMailCorredor.Size = new System.Drawing.Size(29, 13);
            this.labMailCorredor.TabIndex = 76;
            this.labMailCorredor.Text = "Mail:";
            // 
            // labCelularCorredor
            // 
            this.labCelularCorredor.AutoSize = true;
            this.labCelularCorredor.Location = new System.Drawing.Point(59, 244);
            this.labCelularCorredor.Name = "labCelularCorredor";
            this.labCelularCorredor.Size = new System.Drawing.Size(42, 13);
            this.labCelularCorredor.TabIndex = 75;
            this.labCelularCorredor.Text = "Celular:";
            // 
            // labTelCorredor
            // 
            this.labTelCorredor.AutoSize = true;
            this.labTelCorredor.Location = new System.Drawing.Point(49, 203);
            this.labTelCorredor.Name = "labTelCorredor";
            this.labTelCorredor.Size = new System.Drawing.Size(52, 13);
            this.labTelCorredor.TabIndex = 74;
            this.labTelCorredor.Text = "Teléfono:";
            // 
            // labApellidoCorredor
            // 
            this.labApellidoCorredor.AutoSize = true;
            this.labApellidoCorredor.Location = new System.Drawing.Point(54, 161);
            this.labApellidoCorredor.Name = "labApellidoCorredor";
            this.labApellidoCorredor.Size = new System.Drawing.Size(47, 13);
            this.labApellidoCorredor.TabIndex = 73;
            this.labApellidoCorredor.Text = "Apellido:";
            // 
            // labNombreCorredor
            // 
            this.labNombreCorredor.AutoSize = true;
            this.labNombreCorredor.Location = new System.Drawing.Point(54, 116);
            this.labNombreCorredor.Name = "labNombreCorredor";
            this.labNombreCorredor.Size = new System.Drawing.Size(47, 13);
            this.labNombreCorredor.TabIndex = 72;
            this.labNombreCorredor.Text = "Nombre:";
            // 
            // labIdProveedorCorredor
            // 
            this.labIdProveedorCorredor.AutoSize = true;
            this.labIdProveedorCorredor.Location = new System.Drawing.Point(30, 31);
            this.labIdProveedorCorredor.Name = "labIdProveedorCorredor";
            this.labIdProveedorCorredor.Size = new System.Drawing.Size(71, 13);
            this.labIdProveedorCorredor.TabIndex = 71;
            this.labIdProveedorCorredor.Text = "Id Proveedor:";
            // 
            // Corredores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 388);
            this.Controls.Add(this.txtNúmeroCorredor);
            this.Controls.Add(this.labNúmeroCorredor);
            this.Controls.Add(this.btnCancelarCorredor);
            this.Controls.Add(this.btnAgregarCorredor);
            this.Controls.Add(this.btnModificarCorredor);
            this.Controls.Add(this.dgvCorredor);
            this.Controls.Add(this.txtMailCorredor);
            this.Controls.Add(this.txtCelularCorredor);
            this.Controls.Add(this.txtTelCorredor);
            this.Controls.Add(this.txtApellidoCorredor);
            this.Controls.Add(this.txtNombreCorredor);
            this.Controls.Add(this.txtIdProveedorCorredor);
            this.Controls.Add(this.labMailCorredor);
            this.Controls.Add(this.labCelularCorredor);
            this.Controls.Add(this.labTelCorredor);
            this.Controls.Add(this.labApellidoCorredor);
            this.Controls.Add(this.labNombreCorredor);
            this.Controls.Add(this.labIdProveedorCorredor);
            this.Name = "Corredores";
            this.Text = "Corredores";
            this.Load += new System.EventHandler(this.Corredores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorredor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNúmeroCorredor;
        private System.Windows.Forms.Label labNúmeroCorredor;
        private System.Windows.Forms.Button btnCancelarCorredor;
        private System.Windows.Forms.Button btnAgregarCorredor;
        private System.Windows.Forms.Button btnModificarCorredor;
        private System.Windows.Forms.DataGridView dgvCorredor;
        private System.Windows.Forms.TextBox txtMailCorredor;
        private System.Windows.Forms.TextBox txtCelularCorredor;
        private System.Windows.Forms.TextBox txtTelCorredor;
        private System.Windows.Forms.TextBox txtApellidoCorredor;
        private System.Windows.Forms.TextBox txtNombreCorredor;
        private System.Windows.Forms.TextBox txtIdProveedorCorredor;
        private System.Windows.Forms.Label labMailCorredor;
        private System.Windows.Forms.Label labCelularCorredor;
        private System.Windows.Forms.Label labTelCorredor;
        private System.Windows.Forms.Label labApellidoCorredor;
        private System.Windows.Forms.Label labNombreCorredor;
        private System.Windows.Forms.Label labIdProveedorCorredor;
    }
}