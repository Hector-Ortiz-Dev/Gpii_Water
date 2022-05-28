
namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class AgregarCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpServicio = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new RJCodeAdvance.RJControls.RJComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMedidor = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCodPos = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNumero = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCalle = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtColonia = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbMunicipio = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbTipo = new RJCodeAdvance.RJControls.RJComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gpUsuario = new System.Windows.Forms.GroupBox();
            this.dpFechaNac = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cbGenero = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtRfc = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtInstitucion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCurp = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidoM = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidoP = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtContrasena = new RJCodeAdvance.RJControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chEsMoral = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpServicio.SuspendLayout();
            this.gpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(774, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 44);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar cliente";
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
            this.panel1.Size = new System.Drawing.Size(824, 44);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.gpServicio);
            this.panel2.Controls.Add(this.gpUsuario);
            this.panel2.Controls.Add(this.chEsMoral);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 658);
            this.panel2.TabIndex = 5;
            // 
            // gpServicio
            // 
            this.gpServicio.Controls.Add(this.cbCategoria);
            this.gpServicio.Controls.Add(this.label16);
            this.gpServicio.Controls.Add(this.txtMedidor);
            this.gpServicio.Controls.Add(this.txtCodPos);
            this.gpServicio.Controls.Add(this.txtNumero);
            this.gpServicio.Controls.Add(this.txtCalle);
            this.gpServicio.Controls.Add(this.txtColonia);
            this.gpServicio.Controls.Add(this.cbMunicipio);
            this.gpServicio.Controls.Add(this.cbTipo);
            this.gpServicio.Controls.Add(this.label20);
            this.gpServicio.Controls.Add(this.label19);
            this.gpServicio.Controls.Add(this.label18);
            this.gpServicio.Controls.Add(this.label15);
            this.gpServicio.Controls.Add(this.label17);
            this.gpServicio.Controls.Add(this.label14);
            this.gpServicio.Controls.Add(this.label13);
            this.gpServicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpServicio.Location = new System.Drawing.Point(550, 68);
            this.gpServicio.Name = "gpServicio";
            this.gpServicio.Size = new System.Drawing.Size(271, 505);
            this.gpServicio.TabIndex = 25;
            this.gpServicio.TabStop = false;
            this.gpServicio.Text = "Datos del servicio";
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategoria.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCategoria.BorderSize = 1;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategoria.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbCategoria.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbCategoria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCategoria.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbCategoria.Location = new System.Drawing.Point(4, 463);
            this.cbCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategoria.Size = new System.Drawing.Size(246, 30);
            this.cbCategoria.TabIndex = 43;
            this.cbCategoria.Texts = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(4, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 18);
            this.label16.TabIndex = 42;
            this.label16.Text = "Categoria";
            // 
            // txtMedidor
            // 
            this.txtMedidor.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMedidor.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtMedidor.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtMedidor.BorderRadius = 0;
            this.txtMedidor.BorderSize = 2;
            this.txtMedidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedidor.Location = new System.Drawing.Point(4, 405);
            this.txtMedidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedidor.Multiline = false;
            this.txtMedidor.Name = "txtMedidor";
            this.txtMedidor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMedidor.PasswordChar = false;
            this.txtMedidor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedidor.PlaceholderText = "";
            this.txtMedidor.Size = new System.Drawing.Size(246, 33);
            this.txtMedidor.TabIndex = 39;
            this.txtMedidor.Texts = "";
            this.txtMedidor.UnderlinedStyle = false;
            this.txtMedidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedidor_KeyPress);
            // 
            // txtCodPos
            // 
            this.txtCodPos.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCodPos.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtCodPos.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtCodPos.BorderRadius = 0;
            this.txtCodPos.BorderSize = 2;
            this.txtCodPos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodPos.Location = new System.Drawing.Point(3, 346);
            this.txtCodPos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPos.Multiline = false;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodPos.PasswordChar = false;
            this.txtCodPos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodPos.PlaceholderText = "";
            this.txtCodPos.Size = new System.Drawing.Size(246, 33);
            this.txtCodPos.TabIndex = 38;
            this.txtCodPos.Texts = "";
            this.txtCodPos.UnderlinedStyle = false;
            this.txtCodPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPos_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNumero.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtNumero.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtNumero.BorderRadius = 0;
            this.txtNumero.BorderSize = 2;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumero.Location = new System.Drawing.Point(2, 287);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.Size = new System.Drawing.Size(246, 33);
            this.txtNumero.TabIndex = 37;
            this.txtNumero.Texts = "";
            this.txtNumero.UnderlinedStyle = false;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCalle.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtCalle.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtCalle.BorderRadius = 0;
            this.txtCalle.BorderSize = 2;
            this.txtCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCalle.Location = new System.Drawing.Point(4, 228);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCalle.PasswordChar = false;
            this.txtCalle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalle.PlaceholderText = "";
            this.txtCalle.Size = new System.Drawing.Size(246, 33);
            this.txtCalle.TabIndex = 36;
            this.txtCalle.Texts = "";
            this.txtCalle.UnderlinedStyle = false;
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.AliceBlue;
            this.txtColonia.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtColonia.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtColonia.BorderRadius = 0;
            this.txtColonia.BorderSize = 2;
            this.txtColonia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColonia.Location = new System.Drawing.Point(4, 169);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Multiline = false;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColonia.PasswordChar = false;
            this.txtColonia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColonia.PlaceholderText = "";
            this.txtColonia.Size = new System.Drawing.Size(246, 33);
            this.txtColonia.TabIndex = 25;
            this.txtColonia.Texts = "";
            this.txtColonia.UnderlinedStyle = false;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbMunicipio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMunicipio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMunicipio.BorderSize = 1;
            this.cbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMunicipio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMunicipio.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbMunicipio.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMunicipio.Items.AddRange(new object[] {
            "Abasolo",
            "Agualeguas",
            "Allende",
            "Anáhuac",
            "Apodaca",
            "Aramberri",
            "Bustamante",
            "Cadereyta Jiménez",
            "Cerralvo",
            "Ciénega de Flores",
            "China",
            "Doctor Arroyo",
            "Doctor Coss",
            "Doctor González",
            "El Carmen",
            "Galeana",
            "García",
            "General Bravo",
            "General Escobedo",
            "General Terán",
            "General Treviño",
            "General Zaragoza",
            "General Zuazua",
            "Guadalupe",
            "Hidalgo",
            "Higueras",
            "Hualahuises",
            "Iturbide",
            "Juárez",
            "Lampazos de Naranjo",
            "Linares",
            "Los Aldamas",
            "Los Herreras",
            "Los Ramones",
            "Marín",
            "Melchor Ocampo",
            "Mier y Noriega",
            "Mina",
            "Montemorelos",
            "Monterrey",
            "Parás",
            "Pesquería",
            "Rayones",
            "Sabinas Hidalgo",
            "Salinas Victoria",
            "San Nicolás de los Garza",
            "San Pedro Garza García",
            "Santa Catarina",
            "Santiago",
            "Vallecillo",
            "Villaldama"});
            this.cbMunicipio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMunicipio.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbMunicipio.Location = new System.Drawing.Point(3, 110);
            this.cbMunicipio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Padding = new System.Windows.Forms.Padding(1);
            this.cbMunicipio.Size = new System.Drawing.Size(246, 30);
            this.cbMunicipio.TabIndex = 35;
            this.cbMunicipio.Texts = "";
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
            "DOMESTICO",
            "COMERCIAL",
            "INDUSTRIAL"});
            this.cbTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTipo.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbTipo.Location = new System.Drawing.Point(3, 51);
            this.cbTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipo.Size = new System.Drawing.Size(246, 30);
            this.cbTipo.TabIndex = 34;
            this.cbTipo.Texts = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(2, 265);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 18);
            this.label20.TabIndex = 33;
            this.label20.Text = "Número exterior";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(2, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 18);
            this.label19.TabIndex = 32;
            this.label19.Text = "Código Postal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(3, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 18);
            this.label18.TabIndex = 31;
            this.label18.Text = "Calle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Colonia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 383);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Numero de medidor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Municipio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tipo de servicio";
            // 
            // gpUsuario
            // 
            this.gpUsuario.Controls.Add(this.dpFechaNac);
            this.gpUsuario.Controls.Add(this.cbGenero);
            this.gpUsuario.Controls.Add(this.txtRfc);
            this.gpUsuario.Controls.Add(this.txtInstitucion);
            this.gpUsuario.Controls.Add(this.txtCurp);
            this.gpUsuario.Controls.Add(this.txtEmail);
            this.gpUsuario.Controls.Add(this.txtApellidoM);
            this.gpUsuario.Controls.Add(this.txtApellidoP);
            this.gpUsuario.Controls.Add(this.txtNombre);
            this.gpUsuario.Controls.Add(this.txtContrasena);
            this.gpUsuario.Controls.Add(this.label12);
            this.gpUsuario.Controls.Add(this.txtUsuario);
            this.gpUsuario.Controls.Add(this.label9);
            this.gpUsuario.Controls.Add(this.label2);
            this.gpUsuario.Controls.Add(this.lblInstitucion);
            this.gpUsuario.Controls.Add(this.label10);
            this.gpUsuario.Controls.Add(this.label3);
            this.gpUsuario.Controls.Add(this.label4);
            this.gpUsuario.Controls.Add(this.lblFecha);
            this.gpUsuario.Controls.Add(this.label8);
            this.gpUsuario.Controls.Add(this.label6);
            this.gpUsuario.Controls.Add(this.label7);
            this.gpUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpUsuario.Location = new System.Drawing.Point(27, 68);
            this.gpUsuario.Name = "gpUsuario";
            this.gpUsuario.Size = new System.Drawing.Size(521, 578);
            this.gpUsuario.TabIndex = 14;
            this.gpUsuario.TabStop = false;
            this.gpUsuario.Text = "Datos de usuario";
            // 
            // dpFechaNac
            // 
            this.dpFechaNac.BorderColor = System.Drawing.Color.MidnightBlue;
            this.dpFechaNac.BorderSize = 2;
            this.dpFechaNac.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpFechaNac.Location = new System.Drawing.Point(11, 346);
            this.dpFechaNac.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaNac.Name = "dpFechaNac";
            this.dpFechaNac.Size = new System.Drawing.Size(214, 35);
            this.dpFechaNac.SkinColor = System.Drawing.Color.AliceBlue;
            this.dpFechaNac.TabIndex = 39;
            this.dpFechaNac.TextColor = System.Drawing.Color.Black;
            // 
            // cbGenero
            // 
            this.cbGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbGenero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGenero.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbGenero.BorderSize = 1;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenero.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbGenero.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbGenero.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cbGenero.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbGenero.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbGenero.Location = new System.Drawing.Point(11, 405);
            this.cbGenero.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Padding = new System.Windows.Forms.Padding(1);
            this.cbGenero.Size = new System.Drawing.Size(214, 30);
            this.cbGenero.TabIndex = 36;
            this.cbGenero.Texts = "";
            // 
            // txtRfc
            // 
            this.txtRfc.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRfc.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtRfc.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtRfc.BorderRadius = 0;
            this.txtRfc.BorderSize = 2;
            this.txtRfc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRfc.Location = new System.Drawing.Point(269, 51);
            this.txtRfc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRfc.Multiline = false;
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRfc.PasswordChar = false;
            this.txtRfc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRfc.PlaceholderText = "";
            this.txtRfc.Size = new System.Drawing.Size(214, 33);
            this.txtRfc.TabIndex = 24;
            this.txtRfc.Texts = "";
            this.txtRfc.UnderlinedStyle = false;
            this.txtRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRfc_KeyPress);
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.BackColor = System.Drawing.Color.AliceBlue;
            this.txtInstitucion.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtInstitucion.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtInstitucion.BorderRadius = 0;
            this.txtInstitucion.BorderSize = 2;
            this.txtInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInstitucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInstitucion.Location = new System.Drawing.Point(269, 110);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstitucion.Multiline = false;
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtInstitucion.PasswordChar = false;
            this.txtInstitucion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInstitucion.PlaceholderText = "";
            this.txtInstitucion.Size = new System.Drawing.Size(214, 33);
            this.txtInstitucion.TabIndex = 23;
            this.txtInstitucion.Texts = "";
            this.txtInstitucion.UnderlinedStyle = false;
            this.txtInstitucion.Visible = false;
            // 
            // txtCurp
            // 
            this.txtCurp.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCurp.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtCurp.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtCurp.BorderRadius = 0;
            this.txtCurp.BorderSize = 2;
            this.txtCurp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurp.Location = new System.Drawing.Point(11, 523);
            this.txtCurp.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurp.Multiline = false;
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCurp.PasswordChar = false;
            this.txtCurp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurp.PlaceholderText = "";
            this.txtCurp.Size = new System.Drawing.Size(214, 33);
            this.txtCurp.TabIndex = 22;
            this.txtCurp.Texts = "";
            this.txtCurp.UnderlinedStyle = false;
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurp_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEmail.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(11, 464);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(214, 33);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellidoM.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtApellidoM.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtApellidoM.BorderRadius = 0;
            this.txtApellidoM.BorderSize = 2;
            this.txtApellidoM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidoM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoM.Location = new System.Drawing.Point(11, 287);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Multiline = false;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoM.PasswordChar = false;
            this.txtApellidoM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoM.PlaceholderText = "";
            this.txtApellidoM.Size = new System.Drawing.Size(214, 33);
            this.txtApellidoM.TabIndex = 18;
            this.txtApellidoM.Texts = "";
            this.txtApellidoM.UnderlinedStyle = false;
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellidoP.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtApellidoP.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtApellidoP.BorderRadius = 0;
            this.txtApellidoP.BorderSize = 2;
            this.txtApellidoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoP.Location = new System.Drawing.Point(11, 228);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Multiline = false;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoP.PasswordChar = false;
            this.txtApellidoP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoP.PlaceholderText = "";
            this.txtApellidoP.Size = new System.Drawing.Size(214, 33);
            this.txtApellidoP.TabIndex = 17;
            this.txtApellidoP.Texts = "";
            this.txtApellidoP.UnderlinedStyle = false;
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombre.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(11, 169);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(214, 33);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.AliceBlue;
            this.txtContrasena.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtContrasena.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtContrasena.BorderRadius = 0;
            this.txtContrasena.BorderSize = 2;
            this.txtContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasena.Location = new System.Drawing.Point(11, 110);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Multiline = false;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContrasena.PasswordChar = false;
            this.txtContrasena.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContrasena.PlaceholderText = "";
            this.txtContrasena.Size = new System.Drawing.Size(214, 33);
            this.txtContrasena.TabIndex = 15;
            this.txtContrasena.Texts = "";
            this.txtContrasena.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(11, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Contrasena";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsuario.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtUsuario.BorderRadius = 0;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(11, 51);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(214, 33);
            this.txtUsuario.TabIndex = 13;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "CURP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de usuario";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstitucion.Location = new System.Drawing.Point(281, 88);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(76, 18);
            this.lblInstitucion.TabIndex = 12;
            this.lblInstitucion.Text = "Institucion";
            this.lblInstitucion.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(269, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Paterno";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(11, 324);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Genero";
            // 
            // chEsMoral
            // 
            this.chEsMoral.AutoSize = true;
            this.chEsMoral.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chEsMoral.Location = new System.Drawing.Point(43, 21);
            this.chEsMoral.Name = "chEsMoral";
            this.chEsMoral.Size = new System.Drawing.Size(184, 27);
            this.chEsMoral.TabIndex = 13;
            this.chEsMoral.Text = "Es persona moral";
            this.chEsMoral.UseVisualStyleBackColor = true;
            this.chEsMoral.CheckedChanged += new System.EventHandler(this.chEsMoral_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAgregar.Location = new System.Drawing.Point(618, 579);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10);
            this.btnAgregar.Size = new System.Drawing.Size(131, 54);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.AliceBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 741);
            this.MinimizeBox = false;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpServicio.ResumeLayout(false);
            this.gpServicio.PerformLayout();
            this.gpUsuario.ResumeLayout(false);
            this.gpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chEsMoral;
        private System.Windows.Forms.GroupBox gpUsuario;
        private RJCodeAdvance.RJControls.RJTextBox txtUsuario;
        private System.Windows.Forms.Label label12;
        private RJCodeAdvance.RJControls.RJTextBox txtNombre;
        private RJCodeAdvance.RJControls.RJTextBox txtContrasena;
        private System.Windows.Forms.GroupBox gpServicio;
        private RJCodeAdvance.RJControls.RJTextBox txtRfc;
        private RJCodeAdvance.RJControls.RJTextBox txtInstitucion;
        private RJCodeAdvance.RJControls.RJTextBox txtCurp;
        private RJCodeAdvance.RJControls.RJTextBox txtEmail;
        private RJCodeAdvance.RJControls.RJTextBox txtApellidoM;
        private RJCodeAdvance.RJControls.RJTextBox txtApellidoP;
        private RJCodeAdvance.RJControls.RJComboBox cbTipo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private RJCodeAdvance.RJControls.RJTextBox txtColonia;
        private RJCodeAdvance.RJControls.RJComboBox cbMunicipio;
        private RJCodeAdvance.RJControls.RJTextBox txtMedidor;
        private RJCodeAdvance.RJControls.RJTextBox txtCodPos;
        private RJCodeAdvance.RJControls.RJTextBox txtNumero;
        private RJCodeAdvance.RJControls.RJTextBox txtCalle;
        private RJCodeAdvance.RJControls.RJComboBox cbGenero;
        private RJCodeAdvance.RJControls.RJComboBox cbCategoria;
        private System.Windows.Forms.Label label16;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaNac;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}