namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class AgregarTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTarifa));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpTarifa = new System.Windows.Forms.GroupBox();
            this.txtCuota = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnio = new RJCodeAdvance.RJControls.RJComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbZona = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtExcedente = new RJCodeAdvance.RJControls.RJTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIntermedio = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtBasico = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbMes = new RJCodeAdvance.RJControls.RJComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpTarifa.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(365, 0);
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
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar tarifa";
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
            this.panel1.Size = new System.Drawing.Size(415, 44);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.gpTarifa);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 554);
            this.panel2.TabIndex = 5;
            // 
            // gpTarifa
            // 
            this.gpTarifa.Controls.Add(this.txtCuota);
            this.gpTarifa.Controls.Add(this.label2);
            this.gpTarifa.Controls.Add(this.cbAnio);
            this.gpTarifa.Controls.Add(this.label14);
            this.gpTarifa.Controls.Add(this.cbZona);
            this.gpTarifa.Controls.Add(this.txtExcedente);
            this.gpTarifa.Controls.Add(this.label18);
            this.gpTarifa.Controls.Add(this.txtIntermedio);
            this.gpTarifa.Controls.Add(this.txtBasico);
            this.gpTarifa.Controls.Add(this.cbMes);
            this.gpTarifa.Controls.Add(this.label20);
            this.gpTarifa.Controls.Add(this.label19);
            this.gpTarifa.Controls.Add(this.label17);
            this.gpTarifa.Controls.Add(this.label13);
            this.gpTarifa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpTarifa.Location = new System.Drawing.Point(58, 25);
            this.gpTarifa.Name = "gpTarifa";
            this.gpTarifa.Size = new System.Drawing.Size(299, 457);
            this.gpTarifa.TabIndex = 25;
            this.gpTarifa.TabStop = false;
            this.gpTarifa.Text = "Datos de tarifa";
            // 
            // txtCuota
            // 
            this.txtCuota.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCuota.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtCuota.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtCuota.BorderRadius = 0;
            this.txtCuota.BorderSize = 2;
            this.txtCuota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCuota.Location = new System.Drawing.Point(7, 413);
            this.txtCuota.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuota.Multiline = false;
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCuota.PasswordChar = false;
            this.txtCuota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCuota.PlaceholderText = "";
            this.txtCuota.Size = new System.Drawing.Size(246, 33);
            this.txtCuota.TabIndex = 45;
            this.txtCuota.Texts = "";
            this.txtCuota.UnderlinedStyle = false;
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuota_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cuota";
            // 
            // cbAnio
            // 
            this.cbAnio.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbAnio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAnio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbAnio.BorderSize = 1;
            this.cbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAnio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAnio.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbAnio.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbAnio.Items.AddRange(new object[] {
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
            this.cbAnio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbAnio.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbAnio.Location = new System.Drawing.Point(5, 120);
            this.cbAnio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Padding = new System.Windows.Forms.Padding(1);
            this.cbAnio.Size = new System.Drawing.Size(246, 30);
            this.cbAnio.TabIndex = 35;
            this.cbAnio.Texts = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(5, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Año";
            // 
            // cbZona
            // 
            this.cbZona.AutoCompleteCustomSource.AddRange(new string[] {
            "Dómestico",
            "Comercial",
            "Industrial"});
            this.cbZona.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbZona.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbZona.BorderSize = 1;
            this.cbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbZona.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbZona.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbZona.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbZona.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbZona.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbZona.ListTextColor = System.Drawing.Color.DarkBlue;
            this.cbZona.Location = new System.Drawing.Point(6, 58);
            this.cbZona.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbZona.Name = "cbZona";
            this.cbZona.Padding = new System.Windows.Forms.Padding(1);
            this.cbZona.Size = new System.Drawing.Size(246, 30);
            this.cbZona.TabIndex = 43;
            this.cbZona.Texts = "";
            // 
            // txtExcedente
            // 
            this.txtExcedente.BackColor = System.Drawing.Color.AliceBlue;
            this.txtExcedente.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtExcedente.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtExcedente.BorderRadius = 0;
            this.txtExcedente.BorderSize = 2;
            this.txtExcedente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExcedente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExcedente.Location = new System.Drawing.Point(7, 354);
            this.txtExcedente.Margin = new System.Windows.Forms.Padding(4);
            this.txtExcedente.Multiline = false;
            this.txtExcedente.Name = "txtExcedente";
            this.txtExcedente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtExcedente.PasswordChar = false;
            this.txtExcedente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtExcedente.PlaceholderText = "";
            this.txtExcedente.Size = new System.Drawing.Size(246, 33);
            this.txtExcedente.TabIndex = 39;
            this.txtExcedente.Texts = "";
            this.txtExcedente.UnderlinedStyle = false;
            this.txtExcedente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExcedente_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(5, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 18);
            this.label18.TabIndex = 31;
            this.label18.Text = "Zona";
            // 
            // txtIntermedio
            // 
            this.txtIntermedio.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIntermedio.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtIntermedio.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtIntermedio.BorderRadius = 0;
            this.txtIntermedio.BorderSize = 2;
            this.txtIntermedio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIntermedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIntermedio.Location = new System.Drawing.Point(6, 295);
            this.txtIntermedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntermedio.Multiline = false;
            this.txtIntermedio.Name = "txtIntermedio";
            this.txtIntermedio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIntermedio.PasswordChar = false;
            this.txtIntermedio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIntermedio.PlaceholderText = "";
            this.txtIntermedio.Size = new System.Drawing.Size(246, 33);
            this.txtIntermedio.TabIndex = 38;
            this.txtIntermedio.Texts = "";
            this.txtIntermedio.UnderlinedStyle = false;
            this.txtIntermedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntermedio_KeyPress);
            // 
            // txtBasico
            // 
            this.txtBasico.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBasico.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtBasico.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtBasico.BorderRadius = 0;
            this.txtBasico.BorderSize = 2;
            this.txtBasico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBasico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBasico.Location = new System.Drawing.Point(5, 236);
            this.txtBasico.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasico.Multiline = false;
            this.txtBasico.Name = "txtBasico";
            this.txtBasico.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBasico.PasswordChar = false;
            this.txtBasico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBasico.PlaceholderText = "";
            this.txtBasico.Size = new System.Drawing.Size(246, 33);
            this.txtBasico.TabIndex = 37;
            this.txtBasico.Texts = "";
            this.txtBasico.UnderlinedStyle = false;
            this.txtBasico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasico_KeyPress);
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
            this.cbMes.Location = new System.Drawing.Point(5, 175);
            this.cbMes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMes.Name = "cbMes";
            this.cbMes.Padding = new System.Windows.Forms.Padding(1);
            this.cbMes.Size = new System.Drawing.Size(246, 30);
            this.cbMes.TabIndex = 34;
            this.cbMes.Texts = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(5, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 18);
            this.label20.TabIndex = 33;
            this.label20.Text = "Rango 1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(5, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 18);
            this.label19.TabIndex = 32;
            this.label19.Text = "Rango 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(6, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Rango 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(5, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Mes";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnAgregar.Location = new System.Drawing.Point(141, 488);
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
            // AgregarTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 741);
            this.MinimizeBox = false;
            this.Name = "AgregarTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarTarifa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarTarifa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpTarifa.ResumeLayout(false);
            this.gpTarifa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private System.Windows.Forms.GroupBox gpTarifa;
        private RJCodeAdvance.RJControls.RJComboBox cbMes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private RJCodeAdvance.RJControls.RJComboBox cbAnio;
        private RJCodeAdvance.RJControls.RJTextBox txtExcedente;
        private RJCodeAdvance.RJControls.RJTextBox txtIntermedio;
        private RJCodeAdvance.RJControls.RJTextBox txtBasico;
        private RJCodeAdvance.RJControls.RJComboBox cbZona;
        private RJCodeAdvance.RJControls.RJTextBox txtCuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}