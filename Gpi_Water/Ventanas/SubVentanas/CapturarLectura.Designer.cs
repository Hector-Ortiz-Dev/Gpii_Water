namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class CapturarLectura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturarLectura));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpTarifa = new System.Windows.Forms.GroupBox();
            this.lblnumRef = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumo = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnio = new RJCodeAdvance.RJControls.RJComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMes = new RJCodeAdvance.RJControls.RJComboBox();
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
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capturar lectura";
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
            this.panel2.Size = new System.Drawing.Size(415, 374);
            this.panel2.TabIndex = 5;
            // 
            // gpTarifa
            // 
            this.gpTarifa.Controls.Add(this.lblnumRef);
            this.gpTarifa.Controls.Add(this.label3);
            this.gpTarifa.Controls.Add(this.txtConsumo);
            this.gpTarifa.Controls.Add(this.label2);
            this.gpTarifa.Controls.Add(this.cbAnio);
            this.gpTarifa.Controls.Add(this.label14);
            this.gpTarifa.Controls.Add(this.cbMes);
            this.gpTarifa.Controls.Add(this.label13);
            this.gpTarifa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpTarifa.Location = new System.Drawing.Point(58, 25);
            this.gpTarifa.Name = "gpTarifa";
            this.gpTarifa.Size = new System.Drawing.Size(299, 277);
            this.gpTarifa.TabIndex = 25;
            this.gpTarifa.TabStop = false;
            this.gpTarifa.Text = "Datos de lectura";
            // 
            // lblnumRef
            // 
            this.lblnumRef.AutoSize = true;
            this.lblnumRef.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnumRef.Location = new System.Drawing.Point(26, 65);
            this.lblnumRef.Name = "lblnumRef";
            this.lblnumRef.Size = new System.Drawing.Size(76, 23);
            this.lblnumRef.TabIndex = 47;
            this.lblnumRef.Text = "615424";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Numero de referencia";
            // 
            // txtConsumo
            // 
            this.txtConsumo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtConsumo.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtConsumo.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtConsumo.BorderRadius = 0;
            this.txtConsumo.BorderSize = 2;
            this.txtConsumo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsumo.Location = new System.Drawing.Point(7, 117);
            this.txtConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsumo.Multiline = false;
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConsumo.PasswordChar = false;
            this.txtConsumo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConsumo.PlaceholderText = "";
            this.txtConsumo.Size = new System.Drawing.Size(246, 33);
            this.txtConsumo.TabIndex = 45;
            this.txtConsumo.Texts = "";
            this.txtConsumo.UnderlinedStyle = false;
            this.txtConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Lectura de medidor";
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
            this.cbAnio.Location = new System.Drawing.Point(7, 175);
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
            this.label14.Location = new System.Drawing.Point(7, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Año";
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
            this.cbMes.Location = new System.Drawing.Point(7, 230);
            this.cbMes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMes.Name = "cbMes";
            this.cbMes.Padding = new System.Windows.Forms.Padding(1);
            this.cbMes.Size = new System.Drawing.Size(246, 30);
            this.cbMes.TabIndex = 34;
            this.cbMes.Texts = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(7, 208);
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
            this.btnAgregar.Location = new System.Drawing.Point(140, 308);
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
            // CapturarLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 741);
            this.MinimizeBox = false;
            this.Name = "CapturarLectura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Lectura";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarConsumo_Load);
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private RJCodeAdvance.RJControls.RJComboBox cbAnio;
        private RJCodeAdvance.RJControls.RJTextBox txtConsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Label lblnumRef;
        private System.Windows.Forms.Label label3;
    }
}