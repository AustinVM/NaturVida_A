namespace CapaPresentacion.Inventario
{
    partial class Frm_Inventario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInventario = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInventario = new System.Windows.Forms.ComboBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInventario);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 345);
            this.tabControl1.TabIndex = 3;
            // 
            // tbpInventario
            // 
            this.tbpInventario.Controls.Add(this.btnExportarExcel);
            this.tbpInventario.Controls.Add(this.label8);
            this.tbpInventario.Controls.Add(this.cmbInventario);
            this.tbpInventario.Controls.Add(this.dgvInventario);
            this.tbpInventario.Controls.Add(this.btnMostrarProductos);
            this.tbpInventario.Controls.Add(this.btnConsultarProductos);
            this.tbpInventario.Location = new System.Drawing.Point(4, 22);
            this.tbpInventario.Name = "tbpInventario";
            this.tbpInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInventario.Size = new System.Drawing.Size(657, 319);
            this.tbpInventario.TabIndex = 1;
            this.tbpInventario.Text = "Inventario";
            this.tbpInventario.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(565, 81);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(86, 28);
            this.btnExportarExcel.TabIndex = 5;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(66, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "PRODUCTOS:";
            // 
            // cmbInventario
            // 
            this.cmbInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInventario.FormattingEnabled = true;
            this.cmbInventario.Location = new System.Drawing.Point(220, 36);
            this.cmbInventario.Name = "cmbInventario";
            this.cmbInventario.Size = new System.Drawing.Size(232, 21);
            this.cmbInventario.TabIndex = 3;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.ColumnHeadersHeight = 24;
            this.dgvInventario.Location = new System.Drawing.Point(6, 115);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersWidth = 43;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.Size = new System.Drawing.Size(648, 198);
            this.dgvInventario.TabIndex = 2;
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(351, 75);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(101, 25);
            this.btnMostrarProductos.TabIndex = 1;
            this.btnMostrarProductos.Text = "Mostrar productos";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Location = new System.Drawing.Point(220, 75);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(111, 25);
            this.btnConsultarProductos.TabIndex = 0;
            this.btnConsultarProductos.Text = "Consultar producto";
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpInventario.ResumeLayout(false);
            this.tbpInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInventario;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Button btnConsultarProductos;
    }
}