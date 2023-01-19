namespace Proyecto_Geometria_por_KAML
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tipoDeEnvasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prismaCuadrangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prismaHexagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tipoDeEnvasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.archivoToolStripMenuItem.Text = "ARCHIVO";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeUsuarioToolStripMenuItem,
            this.verListaDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cambiarDeUsuarioToolStripMenuItem
            // 
            this.cambiarDeUsuarioToolStripMenuItem.Name = "cambiarDeUsuarioToolStripMenuItem";
            this.cambiarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de usuario";
            // 
            // verListaDeUsuariosToolStripMenuItem
            // 
            this.verListaDeUsuariosToolStripMenuItem.Name = "verListaDeUsuariosToolStripMenuItem";
            this.verListaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListaDeUsuariosToolStripMenuItem.Text = "Ver lista de usuarios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tipoDeEnvasesToolStripMenuItem
            // 
            this.tipoDeEnvasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prismaCuadrangularToolStripMenuItem,
            this.prismaHexagonalToolStripMenuItem,
            this.cilindricoToolStripMenuItem,
            this.conicoToolStripMenuItem});
            this.tipoDeEnvasesToolStripMenuItem.Name = "tipoDeEnvasesToolStripMenuItem";
            this.tipoDeEnvasesToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.tipoDeEnvasesToolStripMenuItem.Text = "PRESENTACION DE ENVASES";
            // 
            // prismaCuadrangularToolStripMenuItem
            // 
            this.prismaCuadrangularToolStripMenuItem.Name = "prismaCuadrangularToolStripMenuItem";
            this.prismaCuadrangularToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.prismaCuadrangularToolStripMenuItem.Text = "Prisma Cuadrangular";
            this.prismaCuadrangularToolStripMenuItem.Click += new System.EventHandler(this.prismaCuadrangularToolStripMenuItem_Click);
            // 
            // prismaHexagonalToolStripMenuItem
            // 
            this.prismaHexagonalToolStripMenuItem.Name = "prismaHexagonalToolStripMenuItem";
            this.prismaHexagonalToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.prismaHexagonalToolStripMenuItem.Text = "Prisma Hexagonal";
            this.prismaHexagonalToolStripMenuItem.Click += new System.EventHandler(this.prismaHexagonalToolStripMenuItem_Click);
            // 
            // cilindricoToolStripMenuItem
            // 
            this.cilindricoToolStripMenuItem.Name = "cilindricoToolStripMenuItem";
            this.cilindricoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cilindricoToolStripMenuItem.Text = "Cilindrico";
            this.cilindricoToolStripMenuItem.Click += new System.EventHandler(this.cilindricoToolStripMenuItem_Click);
            // 
            // conicoToolStripMenuItem
            // 
            this.conicoToolStripMenuItem.Name = "conicoToolStripMenuItem";
            this.conicoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.conicoToolStripMenuItem.Text = "Conico";
            this.conicoToolStripMenuItem.Click += new System.EventHandler(this.conicoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEnvasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismaCuadrangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismaHexagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cilindricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conicoToolStripMenuItem;
    }
}

