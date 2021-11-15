
namespace Trabajo_Practico_PAV_I
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.pnlSubMenuReportes = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUsXPerfil = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnlSubMenuOperaciones = new System.Windows.Forms.Panel();
            this.btnHistorialFormularios = new System.Windows.Forms.Button();
            this.btnHistorialPerfiles = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.pnlSubMenuAdministrar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPerfiles = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnlSubMenuReportes.SuspendLayout();
            this.pnlSubMenuOperaciones.SuspendLayout();
            this.pnlSubMenuAdministrar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(0, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(36, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPerfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(0, 42);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(36, 13);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "label1";
            // 
            // pnlSubMenuReportes
            // 
            this.pnlSubMenuReportes.Controls.Add(this.button2);
            this.pnlSubMenuReportes.Controls.Add(this.btnUsXPerfil);
            this.pnlSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuReportes.Location = new System.Drawing.Point(3, 455);
            this.pnlSubMenuReportes.Name = "pnlSubMenuReportes";
            this.pnlSubMenuReportes.Size = new System.Drawing.Size(145, 63);
            this.pnlSubMenuReportes.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 25);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(145, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reporte2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUsXPerfil
            // 
            this.btnUsXPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsXPerfil.FlatAppearance.BorderSize = 0;
            this.btnUsXPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsXPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsXPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnUsXPerfil.Name = "btnUsXPerfil";
            this.btnUsXPerfil.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsXPerfil.Size = new System.Drawing.Size(145, 25);
            this.btnUsXPerfil.TabIndex = 5;
            this.btnUsXPerfil.Text = "Usuarios por Perfil";
            this.btnUsXPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsXPerfil.UseVisualStyleBackColor = true;
            this.btnUsXPerfil.Click += new System.EventHandler(this.usuariosPorPerfilToolStripMenuItem_Click_1);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Location = new System.Drawing.Point(3, 405);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(145, 44);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pnlSubMenuOperaciones
            // 
            this.pnlSubMenuOperaciones.Controls.Add(this.btnHistorialFormularios);
            this.pnlSubMenuOperaciones.Controls.Add(this.btnHistorialPerfiles);
            this.pnlSubMenuOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuOperaciones.Location = new System.Drawing.Point(3, 340);
            this.pnlSubMenuOperaciones.Name = "pnlSubMenuOperaciones";
            this.pnlSubMenuOperaciones.Size = new System.Drawing.Size(145, 59);
            this.pnlSubMenuOperaciones.TabIndex = 7;
            // 
            // btnHistorialFormularios
            // 
            this.btnHistorialFormularios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialFormularios.FlatAppearance.BorderSize = 0;
            this.btnHistorialFormularios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHistorialFormularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialFormularios.Location = new System.Drawing.Point(0, 25);
            this.btnHistorialFormularios.Name = "btnHistorialFormularios";
            this.btnHistorialFormularios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistorialFormularios.Size = new System.Drawing.Size(145, 25);
            this.btnHistorialFormularios.TabIndex = 7;
            this.btnHistorialFormularios.Text = "Historial Formularios";
            this.btnHistorialFormularios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialFormularios.UseVisualStyleBackColor = true;
            this.btnHistorialFormularios.Click += new System.EventHandler(this.historialPermisosToolStripMenuItem_Click);
            // 
            // btnHistorialPerfiles
            // 
            this.btnHistorialPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialPerfiles.FlatAppearance.BorderSize = 0;
            this.btnHistorialPerfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHistorialPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPerfiles.Location = new System.Drawing.Point(0, 0);
            this.btnHistorialPerfiles.Name = "btnHistorialPerfiles";
            this.btnHistorialPerfiles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistorialPerfiles.Size = new System.Drawing.Size(145, 25);
            this.btnHistorialPerfiles.TabIndex = 6;
            this.btnHistorialPerfiles.Text = "Historial Perfiles";
            this.btnHistorialPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPerfiles.UseVisualStyleBackColor = true;
            this.btnHistorialPerfiles.Click += new System.EventHandler(this.historialPerfilesDelUsuarioToolStripMenuItem_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Location = new System.Drawing.Point(3, 290);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOperaciones.Size = new System.Drawing.Size(145, 44);
            this.btnOperaciones.TabIndex = 6;
            this.btnOperaciones.Text = "Historiales";
            this.btnOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // pnlSubMenuAdministrar
            // 
            this.pnlSubMenuAdministrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSubMenuAdministrar.BackgroundImage")));
            this.pnlSubMenuAdministrar.Controls.Add(this.button3);
            this.pnlSubMenuAdministrar.Controls.Add(this.btnUsuarios);
            this.pnlSubMenuAdministrar.Controls.Add(this.btnPerfiles);
            this.pnlSubMenuAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAdministrar.Location = new System.Drawing.Point(3, 200);
            this.pnlSubMenuAdministrar.Name = "pnlSubMenuAdministrar";
            this.pnlSubMenuAdministrar.Size = new System.Drawing.Size(139, 84);
            this.pnlSubMenuAdministrar.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 50);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(139, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Formularios";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.nuevoFormulario_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 25);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(139, 25);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.nuevoUsuario_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfiles.FlatAppearance.BorderSize = 0;
            this.btnPerfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfiles.Location = new System.Drawing.Point(0, 0);
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerfiles.Size = new System.Drawing.Size(139, 25);
            this.btnPerfiles.TabIndex = 0;
            this.btnPerfiles.Text = "Perfiles";
            this.btnPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfiles.UseVisualStyleBackColor = true;
            this.btnPerfiles.Click += new System.EventHandler(this.nuevoPerfil_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Location = new System.Drawing.Point(3, 150);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdministrar.Size = new System.Drawing.Size(145, 44);
            this.btnAdministrar.TabIndex = 1;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 141);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnAdministrar);
            this.flowLayoutPanel1.Controls.Add(this.pnlSubMenuAdministrar);
            this.flowLayoutPanel1.Controls.Add(this.btnOperaciones);
            this.flowLayoutPanel1.Controls.Add(this.pnlSubMenuOperaciones);
            this.flowLayoutPanel1.Controls.Add(this.btnReportes);
            this.flowLayoutPanel1.Controls.Add(this.pnlSubMenuReportes);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 601);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblPerfil);
            this.panel2.Location = new System.Drawing.Point(3, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 55);
            this.panel2.TabIndex = 10;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.Location = new System.Drawing.Point(154, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(743, 568);
            this.panelChildForm.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 601);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Perfiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSubMenuReportes.ResumeLayout(false);
            this.pnlSubMenuOperaciones.ResumeLayout(false);
            this.pnlSubMenuAdministrar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Panel pnlSubMenuReportes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUsXPerfil;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel pnlSubMenuOperaciones;
        private System.Windows.Forms.Button btnHistorialFormularios;
        private System.Windows.Forms.Button btnHistorialPerfiles;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Panel pnlSubMenuAdministrar;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPerfiles;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
    }
}

