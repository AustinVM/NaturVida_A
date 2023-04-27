namespace CapaPresentacion._Inventario
{
    partial class MenuVendedores
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
            this.tbpAgrVende = new System.Windows.Forms.TabPage();
            this.txtConfimarContra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiarIng = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombIngreVende = new System.Windows.Forms.TextBox();
            this.txtContraseIngreVende = new System.Windows.Forms.TextBox();
            this.txtUsuarIngreVende = new System.Windows.Forms.TextBox();
            this.txtCodIngreVende = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpMostVende = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.btnMostrarVende = new System.Windows.Forms.Button();
            this.btnConsultarVende = new System.Windows.Forms.Button();
            this.tbpActVende = new System.Windows.Forms.TabPage();
            this.txtConfirContraAct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActNombVende = new System.Windows.Forms.TextBox();
            this.txtActContraVende = new System.Windows.Forms.TextBox();
            this.txtActUsuarVende = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConsultarVendeAct = new System.Windows.Forms.Button();
            this.cmbActVende = new System.Windows.Forms.ComboBox();
            this.btnLimpiarActClien = new System.Windows.Forms.Button();
            this.btnActVende = new System.Windows.Forms.Button();
            this.tbpElimVende = new System.Windows.Forms.TabPage();
            this.cmbEliminarVende = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpAgrVende.SuspendLayout();
            this.tbpMostVende.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.tbpActVende.SuspendLayout();
            this.tbpElimVende.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAgrVende);
            this.tabControl1.Controls.Add(this.tbpMostVende);
            this.tabControl1.Controls.Add(this.tbpActVende);
            this.tabControl1.Controls.Add(this.tbpElimVende);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 345);
            this.tabControl1.TabIndex = 2;
            // 
            // tbpAgrVende
            // 
            this.tbpAgrVende.Controls.Add(this.txtConfimarContra);
            this.tbpAgrVende.Controls.Add(this.label9);
            this.tbpAgrVende.Controls.Add(this.btnLimpiarIng);
            this.tbpAgrVende.Controls.Add(this.btnGuardar);
            this.tbpAgrVende.Controls.Add(this.txtNombIngreVende);
            this.tbpAgrVende.Controls.Add(this.txtContraseIngreVende);
            this.tbpAgrVende.Controls.Add(this.txtUsuarIngreVende);
            this.tbpAgrVende.Controls.Add(this.txtCodIngreVende);
            this.tbpAgrVende.Controls.Add(this.label4);
            this.tbpAgrVende.Controls.Add(this.label3);
            this.tbpAgrVende.Controls.Add(this.label2);
            this.tbpAgrVende.Controls.Add(this.label1);
            this.tbpAgrVende.Location = new System.Drawing.Point(4, 22);
            this.tbpAgrVende.Name = "tbpAgrVende";
            this.tbpAgrVende.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgrVende.Size = new System.Drawing.Size(657, 319);
            this.tbpAgrVende.TabIndex = 0;
            this.tbpAgrVende.Text = "Agregar vendedor";
            this.tbpAgrVende.UseVisualStyleBackColor = true;
            // 
            // txtConfimarContra
            // 
            this.txtConfimarContra.Location = new System.Drawing.Point(294, 159);
            this.txtConfimarContra.Name = "txtConfimarContra";
            this.txtConfimarContra.Size = new System.Drawing.Size(149, 20);
            this.txtConfimarContra.TabIndex = 11;
            this.txtConfimarContra.TextChanged += new System.EventHandler(this.txtConfimarContra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.Location = new System.Drawing.Point(73, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Confimar contraseña:";
            // 
            // btnLimpiarIng
            // 
            this.btnLimpiarIng.Location = new System.Drawing.Point(577, 287);
            this.btnLimpiarIng.Name = "btnLimpiarIng";
            this.btnLimpiarIng.Size = new System.Drawing.Size(74, 26);
            this.btnLimpiarIng.TabIndex = 9;
            this.btnLimpiarIng.Text = "Limpiar";
            this.btnLimpiarIng.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(294, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 26);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombIngreVende
            // 
            this.txtNombIngreVende.Location = new System.Drawing.Point(294, 209);
            this.txtNombIngreVende.Name = "txtNombIngreVende";
            this.txtNombIngreVende.Size = new System.Drawing.Size(149, 20);
            this.txtNombIngreVende.TabIndex = 7;
            this.txtNombIngreVende.TextChanged += new System.EventHandler(this.txtNombIngreVende_TextChanged);
            // 
            // txtContraseIngreVende
            // 
            this.txtContraseIngreVende.Location = new System.Drawing.Point(294, 125);
            this.txtContraseIngreVende.Name = "txtContraseIngreVende";
            this.txtContraseIngreVende.Size = new System.Drawing.Size(149, 20);
            this.txtContraseIngreVende.TabIndex = 6;
            this.txtContraseIngreVende.TextChanged += new System.EventHandler(this.txtContraseIngreVende_TextChanged);
            // 
            // txtUsuarIngreVende
            // 
            this.txtUsuarIngreVende.Location = new System.Drawing.Point(294, 83);
            this.txtUsuarIngreVende.Name = "txtUsuarIngreVende";
            this.txtUsuarIngreVende.Size = new System.Drawing.Size(149, 20);
            this.txtUsuarIngreVende.TabIndex = 5;
            this.txtUsuarIngreVende.TextChanged += new System.EventHandler(this.txtUsuarIngreVende_TextChanged);
            // 
            // txtCodIngreVende
            // 
            this.txtCodIngreVende.Location = new System.Drawing.Point(294, 28);
            this.txtCodIngreVende.Name = "txtCodIngreVende";
            this.txtCodIngreVende.Size = new System.Drawing.Size(149, 20);
            this.txtCodIngreVende.TabIndex = 4;
            this.txtCodIngreVende.TextChanged += new System.EventHandler(this.txtCodIngreVende_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(180, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(153, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(184, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(184, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tbpMostVende
            // 
            this.tbpMostVende.Controls.Add(this.btnExportarExcel);
            this.tbpMostVende.Controls.Add(this.label8);
            this.tbpMostVende.Controls.Add(this.cmbVendedores);
            this.tbpMostVende.Controls.Add(this.dgvVendedores);
            this.tbpMostVende.Controls.Add(this.btnMostrarVende);
            this.tbpMostVende.Controls.Add(this.btnConsultarVende);
            this.tbpMostVende.Location = new System.Drawing.Point(4, 22);
            this.tbpMostVende.Name = "tbpMostVende";
            this.tbpMostVende.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMostVende.Size = new System.Drawing.Size(657, 319);
            this.tbpMostVende.TabIndex = 1;
            this.tbpMostVende.Text = "Mostrar vendedores";
            this.tbpMostVende.UseVisualStyleBackColor = true;
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
            this.label8.Size = new System.Drawing.Size(148, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "VENDEDORES:";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(220, 36);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(232, 21);
            this.cmbVendedores.TabIndex = 3;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AllowUserToResizeColumns = false;
            this.dgvVendedores.AllowUserToResizeRows = false;
            this.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVendedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendedores.ColumnHeadersHeight = 24;
            this.dgvVendedores.Location = new System.Drawing.Point(6, 115);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.RowHeadersWidth = 43;
            this.dgvVendedores.RowTemplate.Height = 25;
            this.dgvVendedores.Size = new System.Drawing.Size(648, 198);
            this.dgvVendedores.TabIndex = 2;
            // 
            // btnMostrarVende
            // 
            this.btnMostrarVende.Location = new System.Drawing.Point(351, 75);
            this.btnMostrarVende.Name = "btnMostrarVende";
            this.btnMostrarVende.Size = new System.Drawing.Size(101, 25);
            this.btnMostrarVende.TabIndex = 1;
            this.btnMostrarVende.Text = "Mostrar vendedor";
            this.btnMostrarVende.UseVisualStyleBackColor = true;
            this.btnMostrarVende.Click += new System.EventHandler(this.btnMostrarVende_Click);
            // 
            // btnConsultarVende
            // 
            this.btnConsultarVende.Location = new System.Drawing.Point(220, 75);
            this.btnConsultarVende.Name = "btnConsultarVende";
            this.btnConsultarVende.Size = new System.Drawing.Size(111, 25);
            this.btnConsultarVende.TabIndex = 0;
            this.btnConsultarVende.Text = "Consultar vendedor";
            this.btnConsultarVende.UseVisualStyleBackColor = true;
            this.btnConsultarVende.Click += new System.EventHandler(this.btnConsultarVende_Click);
            // 
            // tbpActVende
            // 
            this.tbpActVende.Controls.Add(this.txtConfirContraAct);
            this.tbpActVende.Controls.Add(this.label11);
            this.tbpActVende.Controls.Add(this.label5);
            this.tbpActVende.Controls.Add(this.label6);
            this.tbpActVende.Controls.Add(this.label7);
            this.tbpActVende.Controls.Add(this.txtActNombVende);
            this.tbpActVende.Controls.Add(this.txtActContraVende);
            this.tbpActVende.Controls.Add(this.txtActUsuarVende);
            this.tbpActVende.Controls.Add(this.label13);
            this.tbpActVende.Controls.Add(this.btnConsultarVendeAct);
            this.tbpActVende.Controls.Add(this.cmbActVende);
            this.tbpActVende.Controls.Add(this.btnLimpiarActClien);
            this.tbpActVende.Controls.Add(this.btnActVende);
            this.tbpActVende.Location = new System.Drawing.Point(4, 22);
            this.tbpActVende.Name = "tbpActVende";
            this.tbpActVende.Size = new System.Drawing.Size(657, 319);
            this.tbpActVende.TabIndex = 2;
            this.tbpActVende.Text = "Actualizar vendedor";
            this.tbpActVende.UseVisualStyleBackColor = true;
            // 
            // txtConfirContraAct
            // 
            this.txtConfirContraAct.Location = new System.Drawing.Point(259, 150);
            this.txtConfirContraAct.Name = "txtConfirContraAct";
            this.txtConfirContraAct.Size = new System.Drawing.Size(149, 20);
            this.txtConfirContraAct.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label11.Location = new System.Drawing.Point(55, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Confimar contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(162, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(139, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(170, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Usuario:";
            // 
            // txtActNombVende
            // 
            this.txtActNombVende.Location = new System.Drawing.Point(259, 176);
            this.txtActNombVende.Name = "txtActNombVende";
            this.txtActNombVende.Size = new System.Drawing.Size(149, 20);
            this.txtActNombVende.TabIndex = 31;
            this.txtActNombVende.TextChanged += new System.EventHandler(this.txtActNombVende_TextChanged);
            // 
            // txtActContraVende
            // 
            this.txtActContraVende.Location = new System.Drawing.Point(259, 118);
            this.txtActContraVende.Name = "txtActContraVende";
            this.txtActContraVende.Size = new System.Drawing.Size(149, 20);
            this.txtActContraVende.TabIndex = 30;
            this.txtActContraVende.TextChanged += new System.EventHandler(this.txtActContraVende_TextChanged);
            // 
            // txtActUsuarVende
            // 
            this.txtActUsuarVende.Location = new System.Drawing.Point(259, 92);
            this.txtActUsuarVende.Name = "txtActUsuarVende";
            this.txtActUsuarVende.Size = new System.Drawing.Size(149, 20);
            this.txtActUsuarVende.TabIndex = 29;
            this.txtActUsuarVende.TextChanged += new System.EventHandler(this.txtActUsuarVende_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label13.Location = new System.Drawing.Point(170, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Codigo:";
            // 
            // btnConsultarVendeAct
            // 
            this.btnConsultarVendeAct.Location = new System.Drawing.Point(431, 49);
            this.btnConsultarVendeAct.Name = "btnConsultarVendeAct";
            this.btnConsultarVendeAct.Size = new System.Drawing.Size(111, 21);
            this.btnConsultarVendeAct.TabIndex = 23;
            this.btnConsultarVendeAct.Text = "Consultar vendedor";
            this.btnConsultarVendeAct.UseVisualStyleBackColor = true;
            this.btnConsultarVendeAct.Click += new System.EventHandler(this.btnConsultarVendeAct_Click);
            // 
            // cmbActVende
            // 
            this.cmbActVende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActVende.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbActVende.FormattingEnabled = true;
            this.cmbActVende.Location = new System.Drawing.Point(259, 49);
            this.cmbActVende.Name = "cmbActVende";
            this.cmbActVende.Size = new System.Drawing.Size(149, 21);
            this.cmbActVende.TabIndex = 21;
            // 
            // btnLimpiarActClien
            // 
            this.btnLimpiarActClien.Location = new System.Drawing.Point(580, 290);
            this.btnLimpiarActClien.Name = "btnLimpiarActClien";
            this.btnLimpiarActClien.Size = new System.Drawing.Size(74, 26);
            this.btnLimpiarActClien.TabIndex = 19;
            this.btnLimpiarActClien.Text = "Limpiar";
            this.btnLimpiarActClien.UseVisualStyleBackColor = true;
            // 
            // btnActVende
            // 
            this.btnActVende.Location = new System.Drawing.Point(259, 255);
            this.btnActVende.Name = "btnActVende";
            this.btnActVende.Size = new System.Drawing.Size(149, 26);
            this.btnActVende.TabIndex = 18;
            this.btnActVende.Text = "Actualizar";
            this.btnActVende.UseVisualStyleBackColor = true;
            this.btnActVende.Click += new System.EventHandler(this.btnActVende_Click);
            // 
            // tbpElimVende
            // 
            this.tbpElimVende.Controls.Add(this.cmbEliminarVende);
            this.tbpElimVende.Controls.Add(this.btnEliminar);
            this.tbpElimVende.Controls.Add(this.label10);
            this.tbpElimVende.Location = new System.Drawing.Point(4, 22);
            this.tbpElimVende.Name = "tbpElimVende";
            this.tbpElimVende.Size = new System.Drawing.Size(657, 319);
            this.tbpElimVende.TabIndex = 3;
            this.tbpElimVende.Text = "Eliminar vendedor";
            this.tbpElimVende.UseVisualStyleBackColor = true;
            // 
            // cmbEliminarVende
            // 
            this.cmbEliminarVende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarVende.FormattingEnabled = true;
            this.cmbEliminarVende.Location = new System.Drawing.Point(280, 117);
            this.cmbEliminarVende.Name = "cmbEliminarVende";
            this.cmbEliminarVende.Size = new System.Drawing.Size(175, 21);
            this.cmbEliminarVende.TabIndex = 22;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(381, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 26);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label10.Location = new System.Drawing.Point(199, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cliente:";
            // 
            // MenuVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVendedores";
            this.Text = "MenuVendedores";
            this.Load += new System.EventHandler(this.MenuVendedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpAgrVende.ResumeLayout(false);
            this.tbpAgrVende.PerformLayout();
            this.tbpMostVende.ResumeLayout(false);
            this.tbpMostVende.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.tbpActVende.ResumeLayout(false);
            this.tbpActVende.PerformLayout();
            this.tbpElimVende.ResumeLayout(false);
            this.tbpElimVende.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpAgrVende;
        private System.Windows.Forms.Button btnLimpiarIng;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombIngreVende;
        private System.Windows.Forms.TextBox txtContraseIngreVende;
        private System.Windows.Forms.TextBox txtUsuarIngreVende;
        private System.Windows.Forms.TextBox txtCodIngreVende;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpMostVende;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Button btnMostrarVende;
        private System.Windows.Forms.Button btnConsultarVende;
        private System.Windows.Forms.TabPage tbpActVende;
        private System.Windows.Forms.TextBox txtActNombVende;
        private System.Windows.Forms.TextBox txtActContraVende;
        private System.Windows.Forms.TextBox txtActUsuarVende;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnConsultarVendeAct;
        private System.Windows.Forms.ComboBox cmbActVende;
        private System.Windows.Forms.Button btnLimpiarActClien;
        private System.Windows.Forms.Button btnActVende;
        private System.Windows.Forms.TabPage tbpElimVende;
        private System.Windows.Forms.ComboBox cmbEliminarVende;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfimarContra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConfirContraAct;
        private System.Windows.Forms.Label label11;
    }
}