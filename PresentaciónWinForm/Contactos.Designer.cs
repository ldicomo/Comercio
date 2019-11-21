namespace PresentaciónWinForm
{
    partial class Contactos
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
            this.labNúmeroContacto = new System.Windows.Forms.Label();
            this.txtNúmeroContacto = new System.Windows.Forms.TextBox();
            this.btnCancelarContacto = new System.Windows.Forms.Button();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.txtMailContacto = new System.Windows.Forms.TextBox();
            this.txtCelularContacto = new System.Windows.Forms.TextBox();
            this.txtTelContacto = new System.Windows.Forms.TextBox();
            this.txtApellidoContacto = new System.Windows.Forms.TextBox();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.txtIdProveedorContacto = new System.Windows.Forms.TextBox();
            this.labMailContacto = new System.Windows.Forms.Label();
            this.labCelularContacto = new System.Windows.Forms.Label();
            this.labTelContacto = new System.Windows.Forms.Label();
            this.labApellidoContacto = new System.Windows.Forms.Label();
            this.labNombreContacto = new System.Windows.Forms.Label();
            this.labIdProveedorContacto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // labNúmeroContacto
            // 
            this.labNúmeroContacto.AutoSize = true;
            this.labNúmeroContacto.Location = new System.Drawing.Point(54, 72);
            this.labNúmeroContacto.Name = "labNúmeroContacto";
            this.labNúmeroContacto.Size = new System.Drawing.Size(47, 13);
            this.labNúmeroContacto.TabIndex = 55;
            this.labNúmeroContacto.Text = "Número:";
            // 
            // txtNúmeroContacto
            // 
            this.txtNúmeroContacto.Location = new System.Drawing.Point(109, 69);
            this.txtNúmeroContacto.Name = "txtNúmeroContacto";
            this.txtNúmeroContacto.Size = new System.Drawing.Size(100, 20);
            this.txtNúmeroContacto.TabIndex = 54;
            // 
            // btnCancelarContacto
            // 
            this.btnCancelarContacto.Location = new System.Drawing.Point(122, 338);
            this.btnCancelarContacto.Name = "btnCancelarContacto";
            this.btnCancelarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarContacto.TabIndex = 53;
            this.btnCancelarContacto.Text = "Cancelar";
            this.btnCancelarContacto.UseVisualStyleBackColor = true;
            this.btnCancelarContacto.Click += new System.EventHandler(this.btnCancelarContacto_Click);
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.Location = new System.Drawing.Point(736, 338);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarContacto.TabIndex = 52;
            this.btnAgregarContacto.Text = "Agregar";
            this.btnAgregarContacto.UseVisualStyleBackColor = true;
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(646, 338);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarContacto.TabIndex = 51;
            this.btnModificarContacto.Text = "Modificar";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.Location = new System.Drawing.Point(245, 27);
            this.dgvContactos.MultiSelect = false;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(566, 281);
            this.dgvContactos.TabIndex = 50;
            // 
            // txtMailContacto
            // 
            this.txtMailContacto.Location = new System.Drawing.Point(109, 288);
            this.txtMailContacto.Name = "txtMailContacto";
            this.txtMailContacto.Size = new System.Drawing.Size(100, 20);
            this.txtMailContacto.TabIndex = 49;
            // 
            // txtCelularContacto
            // 
            this.txtCelularContacto.Location = new System.Drawing.Point(109, 243);
            this.txtCelularContacto.Name = "txtCelularContacto";
            this.txtCelularContacto.Size = new System.Drawing.Size(100, 20);
            this.txtCelularContacto.TabIndex = 48;
            // 
            // txtTelContacto
            // 
            this.txtTelContacto.Location = new System.Drawing.Point(109, 202);
            this.txtTelContacto.Name = "txtTelContacto";
            this.txtTelContacto.Size = new System.Drawing.Size(100, 20);
            this.txtTelContacto.TabIndex = 47;
            // 
            // txtApellidoContacto
            // 
            this.txtApellidoContacto.Location = new System.Drawing.Point(109, 157);
            this.txtApellidoContacto.Name = "txtApellidoContacto";
            this.txtApellidoContacto.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoContacto.TabIndex = 46;
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(109, 112);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreContacto.TabIndex = 45;
            // 
            // txtIdProveedorContacto
            // 
            this.txtIdProveedorContacto.Location = new System.Drawing.Point(109, 27);
            this.txtIdProveedorContacto.Name = "txtIdProveedorContacto";
            this.txtIdProveedorContacto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedorContacto.TabIndex = 44;
            // 
            // labMailContacto
            // 
            this.labMailContacto.AutoSize = true;
            this.labMailContacto.Location = new System.Drawing.Point(72, 291);
            this.labMailContacto.Name = "labMailContacto";
            this.labMailContacto.Size = new System.Drawing.Size(29, 13);
            this.labMailContacto.TabIndex = 43;
            this.labMailContacto.Text = "Mail:";
            // 
            // labCelularContacto
            // 
            this.labCelularContacto.AutoSize = true;
            this.labCelularContacto.Location = new System.Drawing.Point(59, 243);
            this.labCelularContacto.Name = "labCelularContacto";
            this.labCelularContacto.Size = new System.Drawing.Size(42, 13);
            this.labCelularContacto.TabIndex = 42;
            this.labCelularContacto.Text = "Celular:";
            // 
            // labTelContacto
            // 
            this.labTelContacto.AutoSize = true;
            this.labTelContacto.Location = new System.Drawing.Point(49, 202);
            this.labTelContacto.Name = "labTelContacto";
            this.labTelContacto.Size = new System.Drawing.Size(52, 13);
            this.labTelContacto.TabIndex = 41;
            this.labTelContacto.Text = "Teléfono:";
            // 
            // labApellidoContacto
            // 
            this.labApellidoContacto.AutoSize = true;
            this.labApellidoContacto.Location = new System.Drawing.Point(54, 160);
            this.labApellidoContacto.Name = "labApellidoContacto";
            this.labApellidoContacto.Size = new System.Drawing.Size(47, 13);
            this.labApellidoContacto.TabIndex = 40;
            this.labApellidoContacto.Text = "Apellido:";
            // 
            // labNombreContacto
            // 
            this.labNombreContacto.AutoSize = true;
            this.labNombreContacto.Location = new System.Drawing.Point(54, 115);
            this.labNombreContacto.Name = "labNombreContacto";
            this.labNombreContacto.Size = new System.Drawing.Size(47, 13);
            this.labNombreContacto.TabIndex = 39;
            this.labNombreContacto.Text = "Nombre:";
            // 
            // labIdProveedorContacto
            // 
            this.labIdProveedorContacto.AutoSize = true;
            this.labIdProveedorContacto.Location = new System.Drawing.Point(30, 30);
            this.labIdProveedorContacto.Name = "labIdProveedorContacto";
            this.labIdProveedorContacto.Size = new System.Drawing.Size(71, 13);
            this.labIdProveedorContacto.TabIndex = 38;
            this.labIdProveedorContacto.Text = "Id Proveedor:";
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 388);
            this.Controls.Add(this.labNúmeroContacto);
            this.Controls.Add(this.txtNúmeroContacto);
            this.Controls.Add(this.btnCancelarContacto);
            this.Controls.Add(this.btnAgregarContacto);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.txtMailContacto);
            this.Controls.Add(this.txtCelularContacto);
            this.Controls.Add(this.txtTelContacto);
            this.Controls.Add(this.txtApellidoContacto);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.txtIdProveedorContacto);
            this.Controls.Add(this.labMailContacto);
            this.Controls.Add(this.labCelularContacto);
            this.Controls.Add(this.labTelContacto);
            this.Controls.Add(this.labApellidoContacto);
            this.Controls.Add(this.labNombreContacto);
            this.Controls.Add(this.labIdProveedorContacto);
            this.Name = "Contactos";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.Contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNúmeroContacto;
        private System.Windows.Forms.TextBox txtNúmeroContacto;
        private System.Windows.Forms.Button btnCancelarContacto;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TextBox txtMailContacto;
        private System.Windows.Forms.TextBox txtCelularContacto;
        private System.Windows.Forms.TextBox txtTelContacto;
        private System.Windows.Forms.TextBox txtApellidoContacto;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.TextBox txtIdProveedorContacto;
        private System.Windows.Forms.Label labMailContacto;
        private System.Windows.Forms.Label labCelularContacto;
        private System.Windows.Forms.Label labTelContacto;
        private System.Windows.Forms.Label labApellidoContacto;
        private System.Windows.Forms.Label labNombreContacto;
        private System.Windows.Forms.Label labIdProveedorContacto;
    }
}