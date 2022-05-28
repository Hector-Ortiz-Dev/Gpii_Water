
namespace Gpi_Water.Ventanas
{
    partial class RepGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepGeneral));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerar = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new RJCodeAdvance.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMes = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAño = new RJCodeAdvance.RJControls.RJComboBox();
            this.dgConsumos = new System.Windows.Forms.DataGridView();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 44);
            this.panel1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 38;
            this.btnCerrar.Location = new System.Drawing.Point(877, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 44);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte General";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 538);
            this.panel2.TabIndex = 9;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerar.BorderRadius = 25;
            this.btnGenerar.BorderSize = 0;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(585, 415);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(258, 59);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar PDF";
            this.btnGenerar.TextColor = System.Drawing.Color.White;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAño);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 154);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tipo de servicio";
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipo.BorderSize = 1;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipo.Items.AddRange(new object[] {
            "TODOS",
            "DOMESTICO",
            "COMERCIAL",
            "INDUSTRIAL"});
            this.cbTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTipo.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbTipo.Location = new System.Drawing.Point(6, 118);
            this.cbTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipo.Size = new System.Drawing.Size(215, 30);
            this.cbTipo.TabIndex = 40;
            this.cbTipo.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mes";
            // 
            // cbMes
            // 
            this.cbMes.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbMes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMes.BorderSize = 1;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMes.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbMes.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMes.Items.AddRange(new object[] {
            "TODOS",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMes.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbMes.Location = new System.Drawing.Point(241, 55);
            this.cbMes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMes.Name = "cbMes";
            this.cbMes.Padding = new System.Windows.Forms.Padding(1);
            this.cbMes.Size = new System.Drawing.Size(215, 30);
            this.cbMes.TabIndex = 38;
            this.cbMes.Texts = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 15;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(241, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(215, 46);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Año";
            // 
            // cbAño
            // 
            this.cbAño.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAño.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbAño.BorderSize = 1;
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAño.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbAño.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbAño.Items.AddRange(new object[] {
            "TODOS",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.cbAño.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbAño.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbAño.Location = new System.Drawing.Point(6, 55);
            this.cbAño.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAño.Name = "cbAño";
            this.cbAño.Padding = new System.Windows.Forms.Padding(1);
            this.cbAño.Size = new System.Drawing.Size(215, 30);
            this.cbAño.TabIndex = 36;
            this.cbAño.Texts = "";
            // 
            // dgConsumos
            // 
            this.dgConsumos.AllowUserToAddRows = false;
            this.dgConsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgConsumos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgConsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgConsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsumos.ColumnHeadersHeight = 40;
            this.dgConsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.año,
            this.mes,
            this.zona,
            this.tipo,
            this.pagado,
            this.pendiente_pago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsumos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsumos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgConsumos.EnableHeadersVisualStyles = false;
            this.dgConsumos.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgConsumos.Location = new System.Drawing.Point(0, 44);
            this.dgConsumos.Name = "dgConsumos";
            this.dgConsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgConsumos.RowTemplate.Height = 25;
            this.dgConsumos.Size = new System.Drawing.Size(927, 366);
            this.dgConsumos.TabIndex = 16;
            // 
            // año
            // 
            this.año.DataPropertyName = "año";
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // zona
            // 
            this.zona.DataPropertyName = "zona";
            this.zona.HeaderText = "Zona";
            this.zona.Name = "zona";
            this.zona.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo de servicio";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // pagado
            // 
            this.pagado.DataPropertyName = "pagado";
            this.pagado.HeaderText = "Total Pagado";
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            // 
            // pendiente_pago
            // 
            this.pendiente_pago.DataPropertyName = "pendiente_pago";
            this.pendiente_pago.HeaderText = "Total Pendiente";
            this.pendiente_pago.Name = "pendiente_pago";
            this.pendiente_pago.ReadOnly = true;
            // 
            // RepGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 582);
            this.Controls.Add(this.dgConsumos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepGeneral";
            this.Text = "Reporte General";
            this.Load += new System.EventHandler(this.RepGeneral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private RJCodeAdvance.RJControls.RJButton btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJComboBox cbMes;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJComboBox cbAño;
        private System.Windows.Forms.DataGridView dgConsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente_pago;
    }
}