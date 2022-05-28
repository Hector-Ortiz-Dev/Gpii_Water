
namespace Gpi_Water.Ventanas
{
    partial class Lecturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoR = new RJCodeAdvance.RJControls.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMesR = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbAñoR = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnGenerar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCarga = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClientes = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbAño = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtBuscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.dgConsumos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_num_ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.TabIndex = 4;
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
            this.btnCerrar.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnCarga);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgConsumos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(927, 538);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbTipoR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbMesR);
            this.groupBox2.Controls.Add(this.cbAñoR);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(596, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 269);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar recibos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo";
            // 
            // cbTipoR
            // 
            this.cbTipoR.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbTipoR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoR.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipoR.BorderSize = 1;
            this.cbTipoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTipoR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoR.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbTipoR.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipoR.Items.AddRange(new object[] {
            "DOMESTICO",
            "COMERCIAL",
            "INDUSTRIAL"});
            this.cbTipoR.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTipoR.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbTipoR.Location = new System.Drawing.Point(8, 175);
            this.cbTipoR.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTipoR.Name = "cbTipoR";
            this.cbTipoR.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipoR.Size = new System.Drawing.Size(280, 30);
            this.cbTipoR.TabIndex = 47;
            this.cbTipoR.Texts = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Año";
            // 
            // cbMesR
            // 
            this.cbMesR.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbMesR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMesR.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMesR.BorderSize = 1;
            this.cbMesR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMesR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMesR.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbMesR.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMesR.Items.AddRange(new object[] {
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
            this.cbMesR.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMesR.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbMesR.Location = new System.Drawing.Point(8, 114);
            this.cbMesR.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMesR.Name = "cbMesR";
            this.cbMesR.Padding = new System.Windows.Forms.Padding(1);
            this.cbMesR.Size = new System.Drawing.Size(280, 30);
            this.cbMesR.TabIndex = 45;
            this.cbMesR.Texts = "";
            // 
            // cbAñoR
            // 
            this.cbAñoR.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbAñoR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAñoR.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbAñoR.BorderSize = 1;
            this.cbAñoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAñoR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAñoR.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbAñoR.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbAñoR.Items.AddRange(new object[] {
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
            this.cbAñoR.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbAñoR.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbAñoR.Location = new System.Drawing.Point(8, 55);
            this.cbAñoR.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAñoR.Name = "cbAñoR";
            this.cbAñoR.Padding = new System.Windows.Forms.Padding(1);
            this.cbAñoR.Size = new System.Drawing.Size(280, 30);
            this.cbAñoR.TabIndex = 44;
            this.cbAñoR.Texts = "";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGenerar.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnGenerar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerar.BorderRadius = 10;
            this.btnGenerar.BorderSize = 0;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(30, 217);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(235, 44);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextColor = System.Drawing.Color.White;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCarga
            // 
            this.btnCarga.AutoSize = true;
            this.btnCarga.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCarga.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnCarga.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCarga.BorderRadius = 10;
            this.btnCarga.BorderSize = 0;
            this.btnCarga.FlatAppearance.BorderSize = 0;
            this.btnCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarga.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarga.ForeColor = System.Drawing.Color.White;
            this.btnCarga.Location = new System.Drawing.Point(341, 395);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(235, 44);
            this.btnCarga.TabIndex = 14;
            this.btnCarga.Text = "Carga masiva";
            this.btnCarga.TextColor = System.Drawing.Color.White;
            this.btnCarga.UseVisualStyleBackColor = false;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(341, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(235, 44);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Capturar lectura";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbClientes);
            this.groupBox1.Controls.Add(this.cbAño);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(28, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(2, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Contratos";
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
            this.btnBuscar.Location = new System.Drawing.Point(172, 225);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 34);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(2, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar";
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
            // cbClientes
            // 
            this.cbClientes.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbClientes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbClientes.BorderSize = 1;
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClientes.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbClientes.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbClientes.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbClientes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbClientes.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbClientes.Location = new System.Drawing.Point(7, 178);
            this.cbClientes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Padding = new System.Windows.Forms.Padding(1);
            this.cbClientes.Size = new System.Drawing.Size(285, 30);
            this.cbClientes.TabIndex = 42;
            this.cbClientes.Texts = "";
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
            this.cbAño.Size = new System.Drawing.Size(286, 30);
            this.cbAño.TabIndex = 36;
            this.cbAño.Texts = "";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.Location = new System.Drawing.Point(2, 115);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.Size = new System.Drawing.Size(290, 37);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.Texts = "";
            this.txtBuscar.UnderlinedStyle = false;
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
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
            this.id,
            this.tipo,
            this.consumo,
            this.mes,
            this.año,
            this.fk_num_ref,
            this.dataGridViewTextBoxColumn1});
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
            this.dgConsumos.Location = new System.Drawing.Point(10, 10);
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
            this.dgConsumos.Size = new System.Drawing.Size(907, 244);
            this.dgConsumos.TabIndex = 6;
            this.dgConsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsumos_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // consumo
            // 
            this.consumo.DataPropertyName = "consumo";
            this.consumo.HeaderText = "Lectura";
            this.consumo.Name = "consumo";
            this.consumo.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // año
            // 
            this.año.DataPropertyName = "año";
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.ReadOnly = true;
            // 
            // fk_num_ref
            // 
            this.fk_num_ref.DataPropertyName = "fk_num_ref";
            this.fk_num_ref.HeaderText = "Numero referencia";
            this.fk_num_ref.Name = "fk_num_ref";
            this.fk_num_ref.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Lecturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecturas";
            this.Text = "Lecturas";
            this.Load += new System.EventHandler(this.Lecturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgConsumos;
        private System.Windows.Forms.GroupBox groupBox1;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJComboBox cbAño;
        private RJCodeAdvance.RJControls.RJButton btnCarga;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJComboBox cbClientes;
        private RJCodeAdvance.RJControls.RJTextBox txtBuscar;
        private RJCodeAdvance.RJControls.RJButton btnGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJComboBox cbMesR;
        private RJCodeAdvance.RJControls.RJComboBox cbAñoR;
        private System.Windows.Forms.Label label7;
        private RJCodeAdvance.RJControls.RJComboBox cbTipoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_num_ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}