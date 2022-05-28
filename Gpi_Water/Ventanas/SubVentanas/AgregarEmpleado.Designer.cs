
namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.gpUsuario = new System.Windows.Forms.GroupBox();
            this.dpFechaNac = new RJCodeAdvance.RJControls.RJDatePicker();
            this.cbGenero = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtDomicilio = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidoM = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidoP = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtContrasena = new RJCodeAdvance.RJControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.btnCerrar.Location = new System.Drawing.Point(438, 0);
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
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar empleado";
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
            this.panel1.Size = new System.Drawing.Size(488, 44);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.gpUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 658);
            this.panel2.TabIndex = 5;
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
            this.btnAgregar.Location = new System.Drawing.Point(185, 565);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10);
            this.btnAgregar.Size = new System.Drawing.Size(131, 54);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.AliceBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpUsuario
            // 
            this.gpUsuario.Controls.Add(this.dpFechaNac);
            this.gpUsuario.Controls.Add(this.cbGenero);
            this.gpUsuario.Controls.Add(this.txtDomicilio);
            this.gpUsuario.Controls.Add(this.txtApellidoM);
            this.gpUsuario.Controls.Add(this.txtApellidoP);
            this.gpUsuario.Controls.Add(this.txtNombre);
            this.gpUsuario.Controls.Add(this.txtContrasena);
            this.gpUsuario.Controls.Add(this.label12);
            this.gpUsuario.Controls.Add(this.txtUsuario);
            this.gpUsuario.Controls.Add(this.label2);
            this.gpUsuario.Controls.Add(this.label3);
            this.gpUsuario.Controls.Add(this.label4);
            this.gpUsuario.Controls.Add(this.label5);
            this.gpUsuario.Controls.Add(this.label8);
            this.gpUsuario.Controls.Add(this.label6);
            this.gpUsuario.Controls.Add(this.label7);
            this.gpUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpUsuario.Location = new System.Drawing.Point(36, 32);
            this.gpUsuario.Name = "gpUsuario";
            this.gpUsuario.Size = new System.Drawing.Size(424, 516);
            this.gpUsuario.TabIndex = 14;
            this.gpUsuario.TabStop = false;
            this.gpUsuario.Text = "Datos del empleado";
            // 
            // dpFechaNac
            // 
            this.dpFechaNac.BorderColor = System.Drawing.Color.MidnightBlue;
            this.dpFechaNac.BorderSize = 2;
            this.dpFechaNac.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpFechaNac.Location = new System.Drawing.Point(23, 345);
            this.dpFechaNac.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpFechaNac.Name = "dpFechaNac";
            this.dpFechaNac.Size = new System.Drawing.Size(344, 35);
            this.dpFechaNac.SkinColor = System.Drawing.Color.AliceBlue;
            this.dpFechaNac.TabIndex = 38;
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
            this.cbGenero.Location = new System.Drawing.Point(23, 463);
            this.cbGenero.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Padding = new System.Windows.Forms.Padding(1);
            this.cbGenero.Size = new System.Drawing.Size(344, 30);
            this.cbGenero.TabIndex = 37;
            this.cbGenero.Texts = "";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDomicilio.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtDomicilio.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtDomicilio.BorderRadius = 0;
            this.txtDomicilio.BorderSize = 2;
            this.txtDomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDomicilio.Location = new System.Drawing.Point(23, 405);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDomicilio.PasswordChar = false;
            this.txtDomicilio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDomicilio.PlaceholderText = "";
            this.txtDomicilio.Size = new System.Drawing.Size(344, 33);
            this.txtDomicilio.TabIndex = 20;
            this.txtDomicilio.Texts = "";
            this.txtDomicilio.UnderlinedStyle = false;
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
            this.txtApellidoM.Location = new System.Drawing.Point(23, 287);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Multiline = false;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoM.PasswordChar = false;
            this.txtApellidoM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoM.PlaceholderText = "";
            this.txtApellidoM.Size = new System.Drawing.Size(344, 33);
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
            this.txtApellidoP.Location = new System.Drawing.Point(23, 228);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Multiline = false;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoP.PasswordChar = false;
            this.txtApellidoP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoP.PlaceholderText = "";
            this.txtApellidoP.Size = new System.Drawing.Size(344, 33);
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
            this.txtNombre.Location = new System.Drawing.Point(23, 169);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(344, 33);
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
            this.txtContrasena.Location = new System.Drawing.Point(23, 110);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Multiline = false;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContrasena.PasswordChar = false;
            this.txtContrasena.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContrasena.PlaceholderText = "";
            this.txtContrasena.Size = new System.Drawing.Size(344, 33);
            this.txtContrasena.TabIndex = 15;
            this.txtContrasena.Texts = "";
            this.txtContrasena.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(23, 88);
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
            this.txtUsuario.Location = new System.Drawing.Point(23, 51);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(344, 33);
            this.txtUsuario.TabIndex = 13;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Domicilio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Genero";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 741);
            this.MinimizeBox = false;
            this.Name = "AgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEmpleado";
            this.TopMost = true;
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
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpUsuario;
        private RJCodeAdvance.RJControls.RJTextBox txtUsuario;
        private System.Windows.Forms.Label label12;
        private RJCodeAdvance.RJControls.RJTextBox txtNombre;
        private RJCodeAdvance.RJControls.RJTextBox txtContrasena;
        private RJCodeAdvance.RJControls.RJTextBox txtDomicilio;
        private RJCodeAdvance.RJControls.RJTextBox txtApellidoM;
        private RJCodeAdvance.RJControls.RJTextBox txtApellidoP;
        private RJCodeAdvance.RJControls.RJComboBox cbGenero;
        private RJCodeAdvance.RJControls.RJDatePicker dpFechaNac;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}