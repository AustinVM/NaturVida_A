namespace CapaPresentacion.Clientes
{
    partial class MenuClientes
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
            this.tbpAgrClien = new System.Windows.Forms.TabPage();
            this.txtCorrIngreClien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimpiarIng = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTelIngreClien = new System.Windows.Forms.TextBox();
            this.txtDirecIngreClien = new System.Windows.Forms.TextBox();
            this.txtNombIngreClien = new System.Windows.Forms.TextBox();
            this.txtDocIngreClien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpMostClien = new System.Windows.Forms.TabPage();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnMostrarClien = new System.Windows.Forms.Button();
            this.btnConsultarClien = new System.Windows.Forms.Button();
            this.tbpActClien = new System.Windows.Forms.TabPage();
            this.txtActCorrClien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActTelClien = new System.Windows.Forms.TextBox();
            this.txtActDirecClien = new System.Windows.Forms.TextBox();
            this.txtActNombClien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConsultarClienAct = new System.Windows.Forms.Button();
            this.cmbActClien = new System.Windows.Forms.ComboBox();
            this.btnLimpiarActClien = new System.Windows.Forms.Button();
            this.btnActClien = new System.Windows.Forms.Button();
            this.tbpElimClien = new System.Windows.Forms.TabPage();
            this.cmbEliminarClien = new System.Windows.Forms.ComboBox();
            this.btnEliminarClien = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpAgrClien.SuspendLayout();
            this.tbpMostClien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tbpActClien.SuspendLayout();
            this.tbpElimClien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAgrClien);
            this.tabControl1.Controls.Add(this.tbpMostClien);
            this.tabControl1.Controls.Add(this.tbpActClien);
            this.tabControl1.Controls.Add(this.tbpElimClien);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 345);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpAgrClien
            // 
            this.tbpAgrClien.Controls.Add(this.txtCorrIngreClien);
            this.tbpAgrClien.Controls.Add(this.label11);
            this.tbpAgrClien.Controls.Add(this.btnLimpiarIng);
            this.tbpAgrClien.Controls.Add(this.btnGuardar);
            this.tbpAgrClien.Controls.Add(this.txtTelIngreClien);
            this.tbpAgrClien.Controls.Add(this.txtDirecIngreClien);
            this.tbpAgrClien.Controls.Add(this.txtNombIngreClien);
            this.tbpAgrClien.Controls.Add(this.txtDocIngreClien);
            this.tbpAgrClien.Controls.Add(this.label4);
            this.tbpAgrClien.Controls.Add(this.label3);
            this.tbpAgrClien.Controls.Add(this.label2);
            this.tbpAgrClien.Controls.Add(this.label1);
            this.tbpAgrClien.Location = new System.Drawing.Point(4, 22);
            this.tbpAgrClien.Name = "tbpAgrClien";
            this.tbpAgrClien.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgrClien.Size = new System.Drawing.Size(657, 319);
            this.tbpAgrClien.TabIndex = 0;
            this.tbpAgrClien.Text = "Agregar cliente";
            this.tbpAgrClien.UseVisualStyleBackColor = true;
            // 
            // txtCorrIngreClien
            // 
            this.txtCorrIngreClien.Location = new System.Drawing.Point(294, 174);
            this.txtCorrIngreClien.Name = "txtCorrIngreClien";
            this.txtCorrIngreClien.Size = new System.Drawing.Size(149, 20);
            this.txtCorrIngreClien.TabIndex = 11;
            this.txtCorrIngreClien.TextChanged += new System.EventHandler(this.txtCorrIngreClien_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label11.Location = new System.Drawing.Point(153, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Correo:";
            // 
            // btnLimpiarIng
            // 
            this.btnLimpiarIng.Location = new System.Drawing.Point(577, 287);
            this.btnLimpiarIng.Name = "btnLimpiarIng";
            this.btnLimpiarIng.Size = new System.Drawing.Size(74, 26);
            this.btnLimpiarIng.TabIndex = 9;
            this.btnLimpiarIng.Text = "Limpiar";
            this.btnLimpiarIng.UseVisualStyleBackColor = true;
            this.btnLimpiarIng.Click += new System.EventHandler(this.btnLimpiarIng_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(294, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 26);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelIngreClien
            // 
            this.txtTelIngreClien.Location = new System.Drawing.Point(294, 148);
            this.txtTelIngreClien.Name = "txtTelIngreClien";
            this.txtTelIngreClien.Size = new System.Drawing.Size(149, 20);
            this.txtTelIngreClien.TabIndex = 7;
            this.txtTelIngreClien.TextChanged += new System.EventHandler(this.txtTelIngreClien_TextChanged);
            // 
            // txtDirecIngreClien
            // 
            this.txtDirecIngreClien.Location = new System.Drawing.Point(294, 124);
            this.txtDirecIngreClien.Name = "txtDirecIngreClien";
            this.txtDirecIngreClien.Size = new System.Drawing.Size(149, 20);
            this.txtDirecIngreClien.TabIndex = 6;
            this.txtDirecIngreClien.TextChanged += new System.EventHandler(this.txtDirecIngreClien_TextChanged);
            // 
            // txtNombIngreClien
            // 
            this.txtNombIngreClien.Location = new System.Drawing.Point(294, 97);
            this.txtNombIngreClien.Name = "txtNombIngreClien";
            this.txtNombIngreClien.Size = new System.Drawing.Size(149, 20);
            this.txtNombIngreClien.TabIndex = 5;
            this.txtNombIngreClien.TextChanged += new System.EventHandler(this.txtNombIngreClien_TextChanged);
            // 
            // txtDocIngreClien
            // 
            this.txtDocIngreClien.Location = new System.Drawing.Point(294, 42);
            this.txtDocIngreClien.Name = "txtDocIngreClien";
            this.txtDocIngreClien.Size = new System.Drawing.Size(149, 20);
            this.txtDocIngreClien.TabIndex = 4;
            this.txtDocIngreClien.TextChanged += new System.EventHandler(this.txtDocIngreClien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(153, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(153, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(153, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(153, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // tbpMostClien
            // 
            this.tbpMostClien.Controls.Add(this.btnExportarExcel);
            this.tbpMostClien.Controls.Add(this.label8);
            this.tbpMostClien.Controls.Add(this.cmbClientes);
            this.tbpMostClien.Controls.Add(this.dgvClientes);
            this.tbpMostClien.Controls.Add(this.btnMostrarClien);
            this.tbpMostClien.Controls.Add(this.btnConsultarClien);
            this.tbpMostClien.Location = new System.Drawing.Point(4, 22);
            this.tbpMostClien.Name = "tbpMostClien";
            this.tbpMostClien.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMostClien.Size = new System.Drawing.Size(657, 319);
            this.tbpMostClien.TabIndex = 1;
            this.tbpMostClien.Text = "Mostrar clientes";
            this.tbpMostClien.UseVisualStyleBackColor = true;
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
            this.label8.Location = new System.Drawing.Point(84, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "CLIENTES:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(220, 36);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(232, 21);
            this.cmbClientes.TabIndex = 3;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeight = 24;
            this.dgvClientes.Location = new System.Drawing.Point(6, 115);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 43;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(648, 198);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnMostrarClien
            // 
            this.btnMostrarClien.Location = new System.Drawing.Point(351, 75);
            this.btnMostrarClien.Name = "btnMostrarClien";
            this.btnMostrarClien.Size = new System.Drawing.Size(101, 25);
            this.btnMostrarClien.TabIndex = 1;
            this.btnMostrarClien.Text = "Mostrar cliente";
            this.btnMostrarClien.UseVisualStyleBackColor = true;
            this.btnMostrarClien.Click += new System.EventHandler(this.btnMostrarClien_Click);
            // 
            // btnConsultarClien
            // 
            this.btnConsultarClien.Location = new System.Drawing.Point(220, 75);
            this.btnConsultarClien.Name = "btnConsultarClien";
            this.btnConsultarClien.Size = new System.Drawing.Size(111, 25);
            this.btnConsultarClien.TabIndex = 0;
            this.btnConsultarClien.Text = "Consultar cliente";
            this.btnConsultarClien.UseVisualStyleBackColor = true;
            this.btnConsultarClien.Click += new System.EventHandler(this.btnConsultarClien_Click);
            // 
            // tbpActClien
            // 
            this.tbpActClien.Controls.Add(this.txtActCorrClien);
            this.tbpActClien.Controls.Add(this.label5);
            this.tbpActClien.Controls.Add(this.txtActTelClien);
            this.tbpActClien.Controls.Add(this.txtActDirecClien);
            this.tbpActClien.Controls.Add(this.txtActNombClien);
            this.tbpActClien.Controls.Add(this.label6);
            this.tbpActClien.Controls.Add(this.label7);
            this.tbpActClien.Controls.Add(this.label12);
            this.tbpActClien.Controls.Add(this.label13);
            this.tbpActClien.Controls.Add(this.btnConsultarClienAct);
            this.tbpActClien.Controls.Add(this.cmbActClien);
            this.tbpActClien.Controls.Add(this.btnLimpiarActClien);
            this.tbpActClien.Controls.Add(this.btnActClien);
            this.tbpActClien.Location = new System.Drawing.Point(4, 22);
            this.tbpActClien.Name = "tbpActClien";
            this.tbpActClien.Size = new System.Drawing.Size(657, 319);
            this.tbpActClien.TabIndex = 2;
            this.tbpActClien.Text = "Actualizar cliente";
            this.tbpActClien.UseVisualStyleBackColor = true;
            // 
            // txtActCorrClien
            // 
            this.txtActCorrClien.Location = new System.Drawing.Point(259, 202);
            this.txtActCorrClien.Name = "txtActCorrClien";
            this.txtActCorrClien.Size = new System.Drawing.Size(149, 20);
            this.txtActCorrClien.TabIndex = 33;
            this.txtActCorrClien.TextChanged += new System.EventHandler(this.txtActCorrClien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(139, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Correo:";
            // 
            // txtActTelClien
            // 
            this.txtActTelClien.Location = new System.Drawing.Point(259, 176);
            this.txtActTelClien.Name = "txtActTelClien";
            this.txtActTelClien.Size = new System.Drawing.Size(149, 20);
            this.txtActTelClien.TabIndex = 31;
            this.txtActTelClien.TextChanged += new System.EventHandler(this.txtActTelClien_TextChanged);
            // 
            // txtActDirecClien
            // 
            this.txtActDirecClien.Location = new System.Drawing.Point(259, 152);
            this.txtActDirecClien.Name = "txtActDirecClien";
            this.txtActDirecClien.Size = new System.Drawing.Size(149, 20);
            this.txtActDirecClien.TabIndex = 30;
            this.txtActDirecClien.TextChanged += new System.EventHandler(this.txtActDirecClien_TextChanged);
            // 
            // txtActNombClien
            // 
            this.txtActNombClien.Location = new System.Drawing.Point(259, 125);
            this.txtActNombClien.Name = "txtActNombClien";
            this.txtActNombClien.Size = new System.Drawing.Size(149, 20);
            this.txtActNombClien.TabIndex = 29;
            this.txtActNombClien.TextChanged += new System.EventHandler(this.txtActNombClien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(139, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(139, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Dirección:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label12.Location = new System.Drawing.Point(139, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nombre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label13.Location = new System.Drawing.Point(139, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Documento:";
            // 
            // btnConsultarClienAct
            // 
            this.btnConsultarClienAct.Location = new System.Drawing.Point(431, 49);
            this.btnConsultarClienAct.Name = "btnConsultarClienAct";
            this.btnConsultarClienAct.Size = new System.Drawing.Size(111, 21);
            this.btnConsultarClienAct.TabIndex = 23;
            this.btnConsultarClienAct.Text = "Consultar cliente";
            this.btnConsultarClienAct.UseVisualStyleBackColor = true;
            this.btnConsultarClienAct.Click += new System.EventHandler(this.btnConsultarClienAct_Click);
            // 
            // cmbActClien
            // 
            this.cmbActClien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActClien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbActClien.FormattingEnabled = true;
            this.cmbActClien.Location = new System.Drawing.Point(259, 49);
            this.cmbActClien.Name = "cmbActClien";
            this.cmbActClien.Size = new System.Drawing.Size(149, 21);
            this.cmbActClien.TabIndex = 21;
            // 
            // btnLimpiarActClien
            // 
            this.btnLimpiarActClien.Location = new System.Drawing.Point(580, 290);
            this.btnLimpiarActClien.Name = "btnLimpiarActClien";
            this.btnLimpiarActClien.Size = new System.Drawing.Size(74, 26);
            this.btnLimpiarActClien.TabIndex = 19;
            this.btnLimpiarActClien.Text = "Limpiar";
            this.btnLimpiarActClien.UseVisualStyleBackColor = true;
            this.btnLimpiarActClien.Click += new System.EventHandler(this.btnLimpiarActClien_Click);
            // 
            // btnActClien
            // 
            this.btnActClien.Location = new System.Drawing.Point(259, 255);
            this.btnActClien.Name = "btnActClien";
            this.btnActClien.Size = new System.Drawing.Size(149, 26);
            this.btnActClien.TabIndex = 18;
            this.btnActClien.Text = "Actualizar";
            this.btnActClien.UseVisualStyleBackColor = true;
            this.btnActClien.Click += new System.EventHandler(this.btnActClien_Click);
            // 
            // tbpElimClien
            // 
            this.tbpElimClien.Controls.Add(this.cmbEliminarClien);
            this.tbpElimClien.Controls.Add(this.btnEliminarClien);
            this.tbpElimClien.Controls.Add(this.label10);
            this.tbpElimClien.Location = new System.Drawing.Point(4, 22);
            this.tbpElimClien.Name = "tbpElimClien";
            this.tbpElimClien.Size = new System.Drawing.Size(657, 319);
            this.tbpElimClien.TabIndex = 3;
            this.tbpElimClien.Text = "Eliminar Cliente";
            this.tbpElimClien.UseVisualStyleBackColor = true;
            // 
            // cmbEliminarClien
            // 
            this.cmbEliminarClien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarClien.FormattingEnabled = true;
            this.cmbEliminarClien.Location = new System.Drawing.Point(280, 117);
            this.cmbEliminarClien.Name = "cmbEliminarClien";
            this.cmbEliminarClien.Size = new System.Drawing.Size(175, 21);
            this.cmbEliminarClien.TabIndex = 22;
            // 
            // btnEliminarClien
            // 
            this.btnEliminarClien.Location = new System.Drawing.Point(381, 157);
            this.btnEliminarClien.Name = "btnEliminarClien";
            this.btnEliminarClien.Size = new System.Drawing.Size(74, 26);
            this.btnEliminarClien.TabIndex = 21;
            this.btnEliminarClien.Text = "Eliminar";
            this.btnEliminarClien.UseVisualStyleBackColor = true;
            this.btnEliminarClien.Click += new System.EventHandler(this.btnEliminarClien_Click);
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
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuClientes";
            this.Text = "MenuClientes";
            this.Load += new System.EventHandler(this.MenuClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpAgrClien.ResumeLayout(false);
            this.tbpAgrClien.PerformLayout();
            this.tbpMostClien.ResumeLayout(false);
            this.tbpMostClien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tbpActClien.ResumeLayout(false);
            this.tbpActClien.PerformLayout();
            this.tbpElimClien.ResumeLayout(false);
            this.tbpElimClien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpAgrClien;
        private System.Windows.Forms.Button btnLimpiarIng;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTelIngreClien;
        private System.Windows.Forms.TextBox txtDirecIngreClien;
        private System.Windows.Forms.TextBox txtNombIngreClien;
        private System.Windows.Forms.TextBox txtDocIngreClien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpMostClien;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnMostrarClien;
        private System.Windows.Forms.Button btnConsultarClien;
        private System.Windows.Forms.TabPage tbpActClien;
        private System.Windows.Forms.Button btnConsultarClienAct;
        private System.Windows.Forms.ComboBox cmbActClien;
        private System.Windows.Forms.Button btnLimpiarActClien;
        private System.Windows.Forms.Button btnActClien;
        private System.Windows.Forms.TabPage tbpElimClien;
        private System.Windows.Forms.ComboBox cmbEliminarClien;
        private System.Windows.Forms.Button btnEliminarClien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorrIngreClien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtActCorrClien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActTelClien;
        private System.Windows.Forms.TextBox txtActDirecClien;
        private System.Windows.Forms.TextBox txtActNombClien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}