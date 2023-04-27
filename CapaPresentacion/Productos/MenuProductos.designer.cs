using System.Windows.Forms;

namespace CapaPresentacion.Productos
{
    partial class MenuProductos
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
            this.tbpAgrProd = new System.Windows.Forms.TabPage();
            this.btnLimpiarIng = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantIngreProd = new System.Windows.Forms.TextBox();
            this.txtValUniIngreProd = new System.Windows.Forms.TextBox();
            this.txtDescIngreProd = new System.Windows.Forms.TextBox();
            this.txtCodIngreProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpMostProd = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnMostrarProd = new System.Windows.Forms.Button();
            this.btnConsultarProd = new System.Windows.Forms.Button();
            this.tbpActProd = new System.Windows.Forms.TabPage();
            this.btnConsultarProdAct = new System.Windows.Forms.Button();
            this.cmbActProd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.btnActProd = new System.Windows.Forms.Button();
            this.txtCantActProd = new System.Windows.Forms.TextBox();
            this.txtValUniActProd = new System.Windows.Forms.TextBox();
            this.txtDescActProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpElimProd = new System.Windows.Forms.TabPage();
            this.cmbEliminarProd = new System.Windows.Forms.ComboBox();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpAgrProd.SuspendLayout();
            this.tbpMostProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tbpActProd.SuspendLayout();
            this.tbpElimProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAgrProd);
            this.tabControl1.Controls.Add(this.tbpMostProd);
            this.tabControl1.Controls.Add(this.tbpActProd);
            this.tabControl1.Controls.Add(this.tbpElimProd);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpAgrProd
            // 
            this.tbpAgrProd.Controls.Add(this.btnLimpiarIng);
            this.tbpAgrProd.Controls.Add(this.btnGuardar);
            this.tbpAgrProd.Controls.Add(this.txtCantIngreProd);
            this.tbpAgrProd.Controls.Add(this.txtValUniIngreProd);
            this.tbpAgrProd.Controls.Add(this.txtDescIngreProd);
            this.tbpAgrProd.Controls.Add(this.txtCodIngreProd);
            this.tbpAgrProd.Controls.Add(this.label4);
            this.tbpAgrProd.Controls.Add(this.label3);
            this.tbpAgrProd.Controls.Add(this.label2);
            this.tbpAgrProd.Controls.Add(this.label1);
            this.tbpAgrProd.Location = new System.Drawing.Point(4, 22);
            this.tbpAgrProd.Name = "tbpAgrProd";
            this.tbpAgrProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgrProd.Size = new System.Drawing.Size(657, 319);
            this.tbpAgrProd.TabIndex = 0;
            this.tbpAgrProd.Text = "Agregar producto";
            this.tbpAgrProd.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarIng
            // 
            this.btnLimpiarIng.Location = new System.Drawing.Point(579, 285);
            this.btnLimpiarIng.Name = "btnLimpiarIng";
            this.btnLimpiarIng.Size = new System.Drawing.Size(74, 26);
            this.btnLimpiarIng.TabIndex = 9;
            this.btnLimpiarIng.Text = "Limpiar";
            this.btnLimpiarIng.UseVisualStyleBackColor = true;
            this.btnLimpiarIng.Click += new System.EventHandler(this.btnLimpiarIng_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(331, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 26);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantIngreProd
            // 
            this.txtCantIngreProd.Location = new System.Drawing.Point(256, 166);
            this.txtCantIngreProd.Name = "txtCantIngreProd";
            this.txtCantIngreProd.ShortcutsEnabled = false;
            this.txtCantIngreProd.Size = new System.Drawing.Size(149, 20);
            this.txtCantIngreProd.TabIndex = 7;
            this.txtCantIngreProd.TextChanged += new System.EventHandler(this.txtCantIngreProd_TextChanged);
            // 
            // txtValUniIngreProd
            // 
            this.txtValUniIngreProd.Location = new System.Drawing.Point(256, 142);
            this.txtValUniIngreProd.Name = "txtValUniIngreProd";
            this.txtValUniIngreProd.ShortcutsEnabled = false;
            this.txtValUniIngreProd.Size = new System.Drawing.Size(149, 20);
            this.txtValUniIngreProd.TabIndex = 6;
            this.txtValUniIngreProd.TextChanged += new System.EventHandler(this.txtValUniIngreProd_TextChanged);
            // 
            // txtDescIngreProd
            // 
            this.txtDescIngreProd.Location = new System.Drawing.Point(256, 115);
            this.txtDescIngreProd.Name = "txtDescIngreProd";
            this.txtDescIngreProd.ShortcutsEnabled = false;
            this.txtDescIngreProd.Size = new System.Drawing.Size(149, 20);
            this.txtDescIngreProd.TabIndex = 5;
            // 
            // txtCodIngreProd
            // 
            this.txtCodIngreProd.Location = new System.Drawing.Point(256, 61);
            this.txtCodIngreProd.Name = "txtCodIngreProd";
            this.txtCodIngreProd.ShortcutsEnabled = false;
            this.txtCodIngreProd.Size = new System.Drawing.Size(149, 20);
            this.txtCodIngreProd.TabIndex = 4;
            this.txtCodIngreProd.TextChanged += new System.EventHandler(this.txtCodIngreProd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(121, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(121, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(121, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tbpMostProd
            // 
            this.tbpMostProd.Controls.Add(this.btnExportarExcel);
            this.tbpMostProd.Controls.Add(this.label8);
            this.tbpMostProd.Controls.Add(this.cmbProductos);
            this.tbpMostProd.Controls.Add(this.dgvProductos);
            this.tbpMostProd.Controls.Add(this.btnMostrarProd);
            this.tbpMostProd.Controls.Add(this.btnConsultarProd);
            this.tbpMostProd.Location = new System.Drawing.Point(4, 22);
            this.tbpMostProd.Name = "tbpMostProd";
            this.tbpMostProd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMostProd.Size = new System.Drawing.Size(657, 319);
            this.tbpMostProd.TabIndex = 1;
            this.tbpMostProd.Text = "Mostrar productos";
            this.tbpMostProd.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(565, 83);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(86, 28);
            this.btnExportarExcel.TabIndex = 5;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(84, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "PRODUCTOS";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(220, 36);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(232, 21);
            this.cmbProductos.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeight = 24;
            this.dgvProductos.Location = new System.Drawing.Point(5, 117);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 43;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(648, 198);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnMostrarProd
            // 
            this.btnMostrarProd.Location = new System.Drawing.Point(351, 75);
            this.btnMostrarProd.Name = "btnMostrarProd";
            this.btnMostrarProd.Size = new System.Drawing.Size(101, 23);
            this.btnMostrarProd.TabIndex = 1;
            this.btnMostrarProd.Text = "Mostrar productos";
            this.btnMostrarProd.UseVisualStyleBackColor = true;
            this.btnMostrarProd.Click += new System.EventHandler(this.btnMostrarProds_Click);
            // 
            // btnConsultarProd
            // 
            this.btnConsultarProd.Location = new System.Drawing.Point(220, 75);
            this.btnConsultarProd.Name = "btnConsultarProd";
            this.btnConsultarProd.Size = new System.Drawing.Size(111, 23);
            this.btnConsultarProd.TabIndex = 0;
            this.btnConsultarProd.Text = "Consultar producto";
            this.btnConsultarProd.UseVisualStyleBackColor = true;
            this.btnConsultarProd.Click += new System.EventHandler(this.btnConsultarProd_Click);
            // 
            // tbpActProd
            // 
            this.tbpActProd.Controls.Add(this.btnConsultarProdAct);
            this.tbpActProd.Controls.Add(this.cmbActProd);
            this.tbpActProd.Controls.Add(this.label9);
            this.tbpActProd.Controls.Add(this.btnLimpiarAct);
            this.tbpActProd.Controls.Add(this.btnActProd);
            this.tbpActProd.Controls.Add(this.txtCantActProd);
            this.tbpActProd.Controls.Add(this.txtValUniActProd);
            this.tbpActProd.Controls.Add(this.txtDescActProd);
            this.tbpActProd.Controls.Add(this.label5);
            this.tbpActProd.Controls.Add(this.label6);
            this.tbpActProd.Controls.Add(this.label7);
            this.tbpActProd.Location = new System.Drawing.Point(4, 22);
            this.tbpActProd.Name = "tbpActProd";
            this.tbpActProd.Size = new System.Drawing.Size(657, 319);
            this.tbpActProd.TabIndex = 2;
            this.tbpActProd.Text = "Actualizar producto";
            this.tbpActProd.UseVisualStyleBackColor = true;
            // 
            // btnConsultarProdAct
            // 
            this.btnConsultarProdAct.Location = new System.Drawing.Point(431, 99);
            this.btnConsultarProdAct.Name = "btnConsultarProdAct";
            this.btnConsultarProdAct.Size = new System.Drawing.Size(111, 21);
            this.btnConsultarProdAct.TabIndex = 23;
            this.btnConsultarProdAct.Text = "Consultar producto";
            this.btnConsultarProdAct.UseVisualStyleBackColor = true;
            this.btnConsultarProdAct.Click += new System.EventHandler(this.btnConsultarProdAct_Click);
            // 
            // cmbActProd
            // 
            this.cmbActProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbActProd.FormattingEnabled = true;
            this.cmbActProd.Location = new System.Drawing.Point(259, 99);
            this.cmbActProd.Name = "cmbActProd";
            this.cmbActProd.Size = new System.Drawing.Size(149, 21);
            this.cmbActProd.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.Location = new System.Drawing.Point(110, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Codigo:";
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.Location = new System.Drawing.Point(582, 292);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(74, 26);
            this.btnLimpiarAct.TabIndex = 19;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = true;
            this.btnLimpiarAct.Click += new System.EventHandler(this.btnLimpiarAct_Click);
            // 
            // btnActProd
            // 
            this.btnActProd.Location = new System.Drawing.Point(259, 220);
            this.btnActProd.Name = "btnActProd";
            this.btnActProd.Size = new System.Drawing.Size(148, 26);
            this.btnActProd.TabIndex = 18;
            this.btnActProd.Text = "Actualizar";
            this.btnActProd.UseVisualStyleBackColor = true;
            this.btnActProd.Click += new System.EventHandler(this.btnActProd_Click);
            // 
            // txtCantActProd
            // 
            this.txtCantActProd.Location = new System.Drawing.Point(259, 170);
            this.txtCantActProd.Name = "txtCantActProd";
            this.txtCantActProd.ShortcutsEnabled = false;
            this.txtCantActProd.Size = new System.Drawing.Size(149, 20);
            this.txtCantActProd.TabIndex = 17;
            this.txtCantActProd.TextChanged += new System.EventHandler(this.txtCantActProd_TextChanged);
            // 
            // txtValUniActProd
            // 
            this.txtValUniActProd.Location = new System.Drawing.Point(259, 146);
            this.txtValUniActProd.Name = "txtValUniActProd";
            this.txtValUniActProd.ShortcutsEnabled = false;
            this.txtValUniActProd.Size = new System.Drawing.Size(149, 20);
            this.txtValUniActProd.TabIndex = 16;
            this.txtValUniActProd.TextChanged += new System.EventHandler(this.txtValUniActProd_TextChanged);
            // 
            // txtDescActProd
            // 
            this.txtDescActProd.Location = new System.Drawing.Point(259, 122);
            this.txtDescActProd.Name = "txtDescActProd";
            this.txtDescActProd.ShortcutsEnabled = false;
            this.txtDescActProd.Size = new System.Drawing.Size(149, 20);
            this.txtDescActProd.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(110, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(110, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor unitario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(110, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripción:";
            // 
            // tbpElimProd
            // 
            this.tbpElimProd.Controls.Add(this.cmbEliminarProd);
            this.tbpElimProd.Controls.Add(this.btnEliminarProd);
            this.tbpElimProd.Controls.Add(this.label10);
            this.tbpElimProd.Location = new System.Drawing.Point(4, 22);
            this.tbpElimProd.Name = "tbpElimProd";
            this.tbpElimProd.Size = new System.Drawing.Size(657, 319);
            this.tbpElimProd.TabIndex = 3;
            this.tbpElimProd.Text = "Eliminar producto";
            this.tbpElimProd.UseVisualStyleBackColor = true;
            // 
            // cmbEliminarProd
            // 
            this.cmbEliminarProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarProd.FormattingEnabled = true;
            this.cmbEliminarProd.Location = new System.Drawing.Point(286, 119);
            this.cmbEliminarProd.Name = "cmbEliminarProd";
            this.cmbEliminarProd.Size = new System.Drawing.Size(175, 21);
            this.cmbEliminarProd.TabIndex = 22;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Location = new System.Drawing.Point(387, 159);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(74, 26);
            this.btnEliminarProd.TabIndex = 21;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = true;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label10.Location = new System.Drawing.Point(187, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Producto:";
            // 
            // MenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProductos";
            this.Text = "MenuProductos";
            this.Load += new System.EventHandler(this.MenuProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpAgrProd.ResumeLayout(false);
            this.tbpAgrProd.PerformLayout();
            this.tbpMostProd.ResumeLayout(false);
            this.tbpMostProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tbpActProd.ResumeLayout(false);
            this.tbpActProd.PerformLayout();
            this.tbpElimProd.ResumeLayout(false);
            this.tbpElimProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpAgrProd;
        private TabPage tbpMostProd;
        private TabPage tbpActProd;
        private TabPage tbpElimProd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCantIngreProd;
        private TextBox txtValUniIngreProd;
        private TextBox txtDescIngreProd;
        private TextBox txtCodIngreProd;
        private Button btnGuardar;
        private Button btnLimpiarIng;
        private Button btnMostrarProd;
        private Button btnConsultarProd;
        private DataGridView dgvProductos;
        private ComboBox cmbProductos;
        private Button btnLimpiarAct;
        private Button btnActProd;
        private TextBox txtCantActProd;
        private TextBox txtValUniActProd;
        private TextBox txtDescActProd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Button btnEliminarProd;
        private Label label10;
        private ComboBox cmbEliminarProd;
        private ComboBox cmbActProd;
        private Button btnConsultarProdAct;
        private Label label8;
        private Button btnExportarExcel;
    }
}