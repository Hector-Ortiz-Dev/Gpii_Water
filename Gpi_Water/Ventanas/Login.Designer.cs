
namespace Gpi_Water
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkRecordar = new System.Windows.Forms.CheckBox();
            this.btnRevelar = new RJCodeAdvance.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new RJCodeAdvance.RJControls.RJButton();
            this.cbTipo = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtContra = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Gpi_Water.Properties.Resources.GPII_Water;
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.checkRecordar);
            this.panel1.Controls.Add(this.btnRevelar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 646);
            this.panel1.TabIndex = 1;
            // 
            // checkRecordar
            // 
            this.checkRecordar.AutoSize = true;
            this.checkRecordar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkRecordar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkRecordar.Location = new System.Drawing.Point(155, 498);
            this.checkRecordar.Name = "checkRecordar";
            this.checkRecordar.Size = new System.Drawing.Size(189, 23);
            this.checkRecordar.TabIndex = 12;
            this.checkRecordar.Text = "Recordar contraseña";
            this.checkRecordar.UseVisualStyleBackColor = true;
            this.checkRecordar.CheckedChanged += new System.EventHandler(this.checkRecordar_CheckedChanged);
            // 
            // btnRevelar
            // 
            this.btnRevelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnRevelar.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnRevelar.BorderColor = System.Drawing.Color.Blue;
            this.btnRevelar.BorderRadius = 10;
            this.btnRevelar.BorderSize = 0;
            this.btnRevelar.FlatAppearance.BorderSize = 0;
            this.btnRevelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRevelar.ForeColor = System.Drawing.Color.White;
            this.btnRevelar.Location = new System.Drawing.Point(155, 599);
            this.btnRevelar.Name = "btnRevelar";
            this.btnRevelar.Size = new System.Drawing.Size(181, 25);
            this.btnRevelar.TabIndex = 11;
            this.btnRevelar.Text = "Revelar contraseña";
            this.btnRevelar.TextColor = System.Drawing.Color.White;
            this.btnRevelar.UseVisualStyleBackColor = false;
            this.btnRevelar.Visible = false;
            this.btnRevelar.Click += new System.EventHandler(this.btnRevelar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(129, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(92, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(92, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnIngresar.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnIngresar.BorderColor = System.Drawing.Color.Blue;
            this.btnIngresar.BorderRadius = 12;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(155, 534);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(181, 54);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "CLIENTE",
            "EMPLEADO",
            "ADMINISTRADOR"});
            this.cbTipo.BackColor = System.Drawing.Color.Lavender;
            this.cbTipo.BorderColor = System.Drawing.Color.DarkBlue;
            this.cbTipo.BorderSize = 2;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.ForeColor = System.Drawing.Color.Black;
            this.cbTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbTipo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "EMPLEADO",
            "CLIENTE"});
            this.cbTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTipo.ListTextColor = System.Drawing.Color.Black;
            this.cbTipo.Location = new System.Drawing.Point(129, 456);
            this.cbTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Padding = new System.Windows.Forms.Padding(2);
            this.cbTipo.Size = new System.Drawing.Size(243, 30);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.Texts = "";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.Lavender;
            this.txtContra.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtContra.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtContra.BorderRadius = 15;
            this.txtContra.BorderSize = 3;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContra.Location = new System.Drawing.Point(92, 384);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Multiline = false;
            this.txtContra.Name = "txtContra";
            this.txtContra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContra.PasswordChar = true;
            this.txtContra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContra.PlaceholderText = "";
            this.txtContra.Size = new System.Drawing.Size(310, 31);
            this.txtContra.TabIndex = 5;
            this.txtContra.Texts = "";
            this.txtContra.UnderlinedStyle = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Lavender;
            this.txtUsuario.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.BorderSize = 3;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(92, 320);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(310, 31);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 42);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 20;
            this.btnMin.Location = new System.Drawing.Point(406, -1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(45, 25);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(451, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 25);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gpii Water Solutions";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(496, 646);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 685);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 685);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GpiWater - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMin;
        private RJCodeAdvance.RJControls.RJTextBox txtContra;
        private RJCodeAdvance.RJControls.RJTextBox txtUsuario;
        private RJCodeAdvance.RJControls.RJComboBox cbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton btnIngresar;
        private System.Windows.Forms.CheckBox checkRecordar;
        private RJCodeAdvance.RJControls.RJButton btnRevelar;
    }
}

