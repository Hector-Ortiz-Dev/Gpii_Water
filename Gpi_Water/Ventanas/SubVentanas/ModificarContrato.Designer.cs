namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class ModificarContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarContrato));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpServicio = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new RJCodeAdvance.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnModificar = new RJCodeAdvance.RJControls.RJButton();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpServicio.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(427, 0);
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
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modicar contrato";
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
            this.panel1.Size = new System.Drawing.Size(477, 44);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.gpServicio);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 602);
            this.panel2.TabIndex = 5;
            // 
            // gpServicio
            // 
            this.gpServicio.Controls.Add(this.cbCategoria);
            this.gpServicio.Controls.Add(this.label2);
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
            this.gpServicio.Location = new System.Drawing.Point(71, 18);
            this.gpServicio.Name = "gpServicio";
            this.gpServicio.Size = new System.Drawing.Size(328, 512);
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
            this.cbCategoria.Location = new System.Drawing.Point(7, 468);
            this.cbCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategoria.Size = new System.Drawing.Size(276, 30);
            this.cbCategoria.TabIndex = 41;
            this.cbCategoria.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Categoria";
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
            this.txtMedidor.Location = new System.Drawing.Point(7, 410);
            this.txtMedidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedidor.Multiline = false;
            this.txtMedidor.Name = "txtMedidor";
            this.txtMedidor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMedidor.PasswordChar = false;
            this.txtMedidor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedidor.PlaceholderText = "";
            this.txtMedidor.Size = new System.Drawing.Size(276, 33);
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
            this.txtCodPos.Location = new System.Drawing.Point(6, 351);
            this.txtCodPos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPos.Multiline = false;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodPos.PasswordChar = false;
            this.txtCodPos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodPos.PlaceholderText = "";
            this.txtCodPos.Size = new System.Drawing.Size(277, 33);
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
            this.txtNumero.Location = new System.Drawing.Point(5, 292);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.Size = new System.Drawing.Size(278, 33);
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
            this.txtCalle.Location = new System.Drawing.Point(7, 233);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCalle.PasswordChar = false;
            this.txtCalle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalle.PlaceholderText = "";
            this.txtCalle.Size = new System.Drawing.Size(276, 33);
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
            this.txtColonia.Location = new System.Drawing.Point(7, 174);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Multiline = false;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColonia.PasswordChar = false;
            this.txtColonia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColonia.PlaceholderText = "";
            this.txtColonia.Size = new System.Drawing.Size(276, 33);
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
            this.cbMunicipio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMunicipio.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbMunicipio.Location = new System.Drawing.Point(6, 115);
            this.cbMunicipio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Padding = new System.Windows.Forms.Padding(1);
            this.cbMunicipio.Size = new System.Drawing.Size(277, 30);
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
            this.cbTipo.Location = new System.Drawing.Point(6, 56);
            this.cbTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipo.Size = new System.Drawing.Size(277, 30);
            this.cbTipo.TabIndex = 34;
            this.cbTipo.Texts = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(5, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 18);
            this.label20.TabIndex = 33;
            this.label20.Text = "Número exterior";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(5, 329);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 18);
            this.label19.TabIndex = 32;
            this.label19.Text = "Código Postal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(6, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 18);
            this.label18.TabIndex = 31;
            this.label18.Text = "Calle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Colonia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(6, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Numero de medidor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Municipio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tipo de servicio";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnModificar.Location = new System.Drawing.Point(161, 536);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(10);
            this.btnModificar.Size = new System.Drawing.Size(131, 54);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // ModificarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 741);
            this.MinimizeBox = false;
            this.Name = "ModificarContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Contrato";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarContrato_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpServicio.ResumeLayout(false);
            this.gpServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnModificar;
        private System.Windows.Forms.GroupBox gpServicio;
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
        private RJCodeAdvance.RJControls.RJComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}