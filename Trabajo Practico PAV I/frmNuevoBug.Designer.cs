
namespace Trabajo_Practico_PAV_I
{
    partial class frmNuevoBug
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mskFechaAlta = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblUsuarioAsignado = new System.Windows.Forms.Label();
            this.grdBugs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.btnAgregarBug = new System.Windows.Forms.Button();
            this.cmbUsuarioAsignado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnActualizarBug = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(38, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(38, 49);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(107, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 49);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // mskFechaAlta
            // 
            this.mskFechaAlta.Location = new System.Drawing.Point(107, 76);
            this.mskFechaAlta.Mask = "00/00/0000";
            this.mskFechaAlta.Name = "mskFechaAlta";
            this.mskFechaAlta.Size = new System.Drawing.Size(81, 20);
            this.mskFechaAlta.TabIndex = 4;
            this.mskFechaAlta.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(35, 79);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(61, 13);
            this.lblFechaAlta.TabIndex = 5;
            this.lblFechaAlta.Text = "Fecha Alta:";
            // 
            // lblUsuarioAsignado
            // 
            this.lblUsuarioAsignado.AutoSize = true;
            this.lblUsuarioAsignado.Location = new System.Drawing.Point(3, 111);
            this.lblUsuarioAsignado.Name = "lblUsuarioAsignado";
            this.lblUsuarioAsignado.Size = new System.Drawing.Size(93, 13);
            this.lblUsuarioAsignado.TabIndex = 6;
            this.lblUsuarioAsignado.Text = "Usuario Asignado:";
            // 
            // grdBugs
            // 
            this.grdBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.FechaAlta,
            this.Estado});
            this.grdBugs.Location = new System.Drawing.Point(413, 27);
            this.grdBugs.Name = "grdBugs";
            this.grdBugs.Size = new System.Drawing.Size(349, 358);
            this.grdBugs.TabIndex = 8;
            this.grdBugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBugs_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id_bug";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "fecha_alta";
            this.FechaAlta.HeaderText = "FechaAlta";
            this.FechaAlta.Name = "FechaAlta";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "id_estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 75;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(45, 151);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(51, 13);
            this.lblPrioridad.TabIndex = 9;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(107, 151);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(121, 21);
            this.cmbPrioridad.TabIndex = 10;
            // 
            // btnAgregarBug
            // 
            this.btnAgregarBug.Location = new System.Drawing.Point(324, 354);
            this.btnAgregarBug.Name = "btnAgregarBug";
            this.btnAgregarBug.Size = new System.Drawing.Size(83, 31);
            this.btnAgregarBug.TabIndex = 11;
            this.btnAgregarBug.Text = "Agregar Bug";
            this.btnAgregarBug.UseVisualStyleBackColor = true;
            this.btnAgregarBug.Click += new System.EventHandler(this.btnAgregarBug_Click);
            // 
            // cmbUsuarioAsignado
            // 
            this.cmbUsuarioAsignado.FormattingEnabled = true;
            this.cmbUsuarioAsignado.Location = new System.Drawing.Point(107, 111);
            this.cmbUsuarioAsignado.Name = "cmbUsuarioAsignado";
            this.cmbUsuarioAsignado.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarioAsignado.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Producto";
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Location = new System.Drawing.Point(43, 238);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(53, 13);
            this.lblCriticidad.TabIndex = 14;
            this.lblCriticidad.Text = "Criticidad:";
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(107, 238);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCriticidad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(107, 279);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 17;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(107, 191);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 18;
            // 
            // btnActualizarBug
            // 
            this.btnActualizarBug.Location = new System.Drawing.Point(235, 354);
            this.btnActualizarBug.Name = "btnActualizarBug";
            this.btnActualizarBug.Size = new System.Drawing.Size(83, 31);
            this.btnActualizarBug.TabIndex = 19;
            this.btnActualizarBug.Text = "Actualizar Bug";
            this.btnActualizarBug.UseVisualStyleBackColor = true;
            this.btnActualizarBug.Click += new System.EventHandler(this.btnActualizarBug_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(6, 347);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(83, 38);
            this.btnLimpiarCampos.TabIndex = 20;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // frmNuevoBug
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarBug);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCriticidad);
            this.Controls.Add(this.lblCriticidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuarioAsignado);
            this.Controls.Add(this.btnAgregarBug);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.grdBugs);
            this.Controls.Add(this.lblUsuarioAsignado);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.mskFechaAlta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmNuevoBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Bug";
            this.Load += new System.EventHandler(this.frmNuevoBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox mskFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblUsuarioAsignado;
        private System.Windows.Forms.DataGridView grdBugs;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Button btnAgregarBug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox cmbUsuarioAsignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnActualizarBug;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}