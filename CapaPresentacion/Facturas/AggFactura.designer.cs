using System.Windows.Forms;

namespace CapaPresentacion.Facturas
{
    partial class AggFactura
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.dgvClmFactFch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClmClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClmFactProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClmProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClmValUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTerminarFactura = new System.Windows.Forms.Button();
            this.btnAggProd = new System.Windows.Forms.Button();
            this.cmbFactProd = new System.Windows.Forms.ComboBox();
            this.cmbFactClien = new System.Windows.Forms.ComboBox();
            this.txtCantFactProd = new System.Windows.Forms.TextBox();
            this.txtTotalFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAdventecia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToOrderColumns = true;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClmFactFch,
            this.dgvClmClient,
            this.dgvClmFactProd,
            this.dgvClmProd,
            this.dgvClmCantidad,
            this.dgvClmValUni});
            this.dgvFacturas.Location = new System.Drawing.Point(251, 97);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 43;
            this.dgvFacturas.RowTemplate.Height = 25;
            this.dgvFacturas.Size = new System.Drawing.Size(424, 216);
            this.dgvFacturas.TabIndex = 0;
            // 
            // dgvClmFactFch
            // 
            this.dgvClmFactFch.HeaderText = "Fecha";
            this.dgvClmFactFch.Name = "dgvClmFactFch";
            this.dgvClmFactFch.Width = 62;
            // 
            // dgvClmClient
            // 
            this.dgvClmClient.HeaderText = "Cliente";
            this.dgvClmClient.Name = "dgvClmClient";
            this.dgvClmClient.Width = 64;
            // 
            // dgvClmFactProd
            // 
            this.dgvClmFactProd.HeaderText = "Vendedor";
            this.dgvClmFactProd.Name = "dgvClmFactProd";
            this.dgvClmFactProd.Width = 78;
            // 
            // dgvClmProd
            // 
            this.dgvClmProd.HeaderText = "Producto";
            this.dgvClmProd.Name = "dgvClmProd";
            this.dgvClmProd.Width = 75;
            // 
            // dgvClmCantidad
            // 
            this.dgvClmCantidad.HeaderText = "Cantidad";
            this.dgvClmCantidad.Name = "dgvClmCantidad";
            this.dgvClmCantidad.Width = 74;
            // 
            // dgvClmValUni
            // 
            this.dgvClmValUni.HeaderText = "Valor Unitario";
            this.dgvClmValUni.Name = "dgvClmValUni";
            this.dgvClmValUni.Width = 95;
            // 
            // btnTerminarFactura
            // 
            this.btnTerminarFactura.Location = new System.Drawing.Point(10, 329);
            this.btnTerminarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerminarFactura.Name = "btnTerminarFactura";
            this.btnTerminarFactura.Size = new System.Drawing.Size(125, 27);
            this.btnTerminarFactura.TabIndex = 1;
            this.btnTerminarFactura.Text = "Terminar factura";
            this.btnTerminarFactura.UseVisualStyleBackColor = true;
            this.btnTerminarFactura.Click += new System.EventHandler(this.btnTerminarFactura_Click);
            // 
            // btnAggProd
            // 
            this.btnAggProd.Location = new System.Drawing.Point(251, 329);
            this.btnAggProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggProd.Name = "btnAggProd";
            this.btnAggProd.Size = new System.Drawing.Size(109, 27);
            this.btnAggProd.TabIndex = 2;
            this.btnAggProd.Text = "Agregar producto";
            this.btnAggProd.UseVisualStyleBackColor = true;
            this.btnAggProd.Click += new System.EventHandler(this.btnAggProd_Click);
            // 
            // cmbFactProd
            // 
            this.cmbFactProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactProd.FormattingEnabled = true;
            this.cmbFactProd.Location = new System.Drawing.Point(77, 154);
            this.cmbFactProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFactProd.Name = "cmbFactProd";
            this.cmbFactProd.Size = new System.Drawing.Size(149, 21);
            this.cmbFactProd.TabIndex = 4;
            // 
            // cmbFactClien
            // 
            this.cmbFactClien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactClien.FormattingEnabled = true;
            this.cmbFactClien.Location = new System.Drawing.Point(77, 97);
            this.cmbFactClien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFactClien.Name = "cmbFactClien";
            this.cmbFactClien.Size = new System.Drawing.Size(149, 21);
            this.cmbFactClien.TabIndex = 5;
            // 
            // txtCantFactProd
            // 
            this.txtCantFactProd.Location = new System.Drawing.Point(77, 206);
            this.txtCantFactProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantFactProd.Name = "txtCantFactProd";
            this.txtCantFactProd.Size = new System.Drawing.Size(149, 20);
            this.txtCantFactProd.TabIndex = 7;
            this.txtCantFactProd.TextChanged += new System.EventHandler(this.txtCantFactProd_TextChanged);
            // 
            // txtTotalFact
            // 
            this.txtTotalFact.Enabled = false;
            this.txtTotalFact.Location = new System.Drawing.Point(566, 329);
            this.txtTotalFact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalFact.Name = "txtTotalFact";
            this.txtTotalFact.Size = new System.Drawing.Size(109, 20);
            this.txtTotalFact.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total factura:";
            // 
            // lblAdventecia
            // 
            this.lblAdventecia.AutoSize = true;
            this.lblAdventecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAdventecia.Location = new System.Drawing.Point(72, 9);
            this.lblAdventecia.Name = "lblAdventecia";
            this.lblAdventecia.Size = new System.Drawing.Size(64, 25);
            this.lblAdventecia.TabIndex = 15;
            this.lblAdventecia.Text = "label1";
            this.lblAdventecia.Visible = false;
            // 
            // AggFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.lblAdventecia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalFact);
            this.Controls.Add(this.txtCantFactProd);
            this.Controls.Add(this.cmbFactClien);
            this.Controls.Add(this.cmbFactProd);
            this.Controls.Add(this.btnAggProd);
            this.Controls.Add(this.btnTerminarFactura);
            this.Controls.Add(this.dgvFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AggFactura";
            this.Text = "AggFactura";
            this.Load += new System.EventHandler(this.AggFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFacturas;
        private Button btnTerminarFactura;
        private Button btnAggProd;
        private ComboBox cmbFactProd;
        private ComboBox cmbFactClien;
        private TextBox txtCantFactProd;
        private TextBox txtTotalFact;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn dgvClmFactFch;
        private DataGridViewTextBoxColumn dgvClmClient;
        private DataGridViewTextBoxColumn dgvClmFactProd;
        private DataGridViewTextBoxColumn dgvClmProd;
        private DataGridViewTextBoxColumn dgvClmCantidad;
        private DataGridViewTextBoxColumn dgvClmValUni;
        private Label lblAdventecia;
    }
}