
namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class ModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCliente));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpUsuario = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dpFechaNac = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cbGenero = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.txtRfc = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtInstitucion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCurp = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidoM = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidoP = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chEsMoral = new System.Windows.Forms.CheckBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(530, 0);
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
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar cliente";
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
            this.panel1.Size = new System.Drawing.Size(580, 44);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.gpUsuario);
            this.panel2.Controls.Add(this.chEsMoral);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 578);
            this.panel2.TabIndex = 5;
            // 
            // gpUsuario
            // 
            this.gpUsuario.Controls.Add(this.lblNombre);
            this.gpUsuario.Controls.Add(this.dpFechaNac);
            this.gpUsuario.Controls.Add(this.cbGenero);
            this.gpUsuario.Controls.Add(this.btnModificar);
            this.gpUsuario.Controls.Add(this.txtRfc);
            this.gpUsuario.Controls.Add(this.txtInstitucion);
            this.gpUsuario.Controls.Add(this.txtCurp);
            this.gpUsuario.Controls.Add(this.txtEmail);
            this.gpUsuario.Controls.Add(this.txtApellidoM);
            this.gpUsuario.Controls.Add(this.txtApellidoP);
            this.gpUsuario.Controls.Add(this.txtNombre);
            this.gpUsuario.Controls.Add(this.label9);
            this.gpUsuario.Controls.Add(this.lblUsuario);
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
            this.gpUsuario.Size = new System.Drawing.Size(521, 510);
            this.gpUsuario.TabIndex = 14;
            this.gpUsuario.TabStop = false;
            this.gpUsuario.Text = "Datos de usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(11, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(171, 22);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre de usuario";
            // 
            // dpFechaNac
            // 
            this.dpFechaNac.BorderColor = System.Drawing.Color.MidnightBlue;
            this.dpFechaNac.BorderSize = 2;
            this.dpFechaNac.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpFechaNac.Location = new System.Drawing.Point(11, 287);
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
            this.cbGenero.Location = new System.Drawing.Point(11, 346);
            this.cbGenero.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Padding = new System.Windows.Forms.Padding(1);
            this.cbGenero.Size = new System.Drawing.Size(214, 30);
            this.cbGenero.TabIndex = 36;
            this.cbGenero.Texts = "";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnModificar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.Location = new System.Drawing.Point(269, 442);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(10);
            this.btnModificar.Size = new System.Drawing.Size(214, 54);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.txtCurp.Location = new System.Drawing.Point(11, 464);
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
            this.txtEmail.Location = new System.Drawing.Point(11, 405);
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
            this.txtApellidoM.Location = new System.Drawing.Point(11, 228);
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
            this.txtApellidoP.Location = new System.Drawing.Point(11, 169);
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
            this.txtNombre.Location = new System.Drawing.Point(11, 110);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "CURP";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(11, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(141, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nombre de usuario";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstitucion.Location = new System.Drawing.Point(269, 88);
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
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Paterno";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(11, 265);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Genero";
            // 
            // chEsMoral
            // 
            this.chEsMoral.AutoSize = true;
            this.chEsMoral.Enabled = false;
            this.chEsMoral.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chEsMoral.Location = new System.Drawing.Point(43, 21);
            this.chEsMoral.Name = "chEsMoral";
            this.chEsMoral.Size = new System.Drawing.Size(184, 27);
            this.chEsMoral.TabIndex = 13;
            this.chEsMoral.Text = "Es persona moral";
            this.chEsMoral.UseVisualStyleBackColor = true;
            this.chEsMoral.CheckedChanged += new System.EventHandler(this.chEsMoral_CheckedChanged);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 741);
            this.MinimizeBox = false;
            this.Name = "ModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chEsMoral;
        private System.Windows.Forms.GroupBox gpUsuario;
        private RJCodeAdvance.RJControls.RJTextBox txtNombre;
        private RJCodeAdvance.RJControls.RJTextBox txtRfc;
        private RJCodeAdvance.RJControls.RJTextBox txtInstitucion;
        private RJCodeAdvance.RJControls.RJTextBox txtCurp;
        private RJCodeAdvance.RJControls.RJTextBox txtEmail;
        private RJCodeAdvance.RJControls.RJTextBox txtApellidoM;
        private RJCodeAdvance.RJControls.RJTextBox txtApellidoP;
        private RJCodeAdvance.RJControls.RJComboBox cbGenero;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaNac;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Label lblNombre;
    }
}