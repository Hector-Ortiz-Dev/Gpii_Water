
namespace Gpi_Water
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.picUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnRecibos = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnZonas = new FontAwesome.Sharp.IconButton();
            this.btnTarifas = new FontAwesome.Sharp.IconButton();
            this.btnConsumos = new FontAwesome.Sharp.IconButton();
            this.btnContratos = new FontAwesome.Sharp.IconButton();
            this.btnBaneos = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogol = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.picLogoMain = new System.Windows.Forms.PictureBox();
            this.dmSubmenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.btnRepTarifas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepConsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panelLogol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).BeginInit();
            this.dmSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnRecibos);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnZonas);
            this.panelMenu.Controls.Add(this.btnTarifas);
            this.panelMenu.Controls.Add(this.btnConsumos);
            this.panelMenu.Controls.Add(this.btnContratos);
            this.panelMenu.Controls.Add(this.btnBaneos);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogol);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 698);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 60);
            this.panel1.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(62, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Usuario12345";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(62, 13);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(101, 15);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "TIPO DE USUARIO";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.MidnightBlue;
            this.picUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.picUser.ForeColor = System.Drawing.Color.GhostWhite;
            this.picUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.picUser.IconColor = System.Drawing.Color.GhostWhite;
            this.picUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.picUser.IconSize = 60;
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(60, 60);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 667);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(213, 53);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Tag = "Cerrar sesion";
            this.btnLogout.Text = "Cerrar sesion";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRecibos
            // 
            this.btnRecibos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecibos.FlatAppearance.BorderSize = 0;
            this.btnRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecibos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecibos.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnRecibos.IconColor = System.Drawing.Color.White;
            this.btnRecibos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecibos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibos.Location = new System.Drawing.Point(0, 554);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRecibos.Size = new System.Drawing.Size(213, 53);
            this.btnRecibos.TabIndex = 3;
            this.btnRecibos.Tag = "Recibos";
            this.btnRecibos.Text = "Recibos";
            this.btnRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 501);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(213, 53);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Tag = "Reportes";
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnZonas
            // 
            this.btnZonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZonas.FlatAppearance.BorderSize = 0;
            this.btnZonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZonas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZonas.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btnZonas.IconColor = System.Drawing.Color.White;
            this.btnZonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZonas.Location = new System.Drawing.Point(0, 448);
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnZonas.Size = new System.Drawing.Size(213, 53);
            this.btnZonas.TabIndex = 12;
            this.btnZonas.Tag = "Empleados";
            this.btnZonas.Text = "Zonas";
            this.btnZonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZonas.UseVisualStyleBackColor = true;
            this.btnZonas.Click += new System.EventHandler(this.btnZonas_Click);
            // 
            // btnTarifas
            // 
            this.btnTarifas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarifas.FlatAppearance.BorderSize = 0;
            this.btnTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTarifas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTarifas.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            this.btnTarifas.IconColor = System.Drawing.Color.White;
            this.btnTarifas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTarifas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarifas.Location = new System.Drawing.Point(0, 395);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTarifas.Size = new System.Drawing.Size(213, 53);
            this.btnTarifas.TabIndex = 6;
            this.btnTarifas.Tag = "Tarifas";
            this.btnTarifas.Text = "Tarifas";
            this.btnTarifas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarifas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTarifas.UseVisualStyleBackColor = true;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnConsumos
            // 
            this.btnConsumos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumos.FlatAppearance.BorderSize = 0;
            this.btnConsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsumos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsumos.IconChar = FontAwesome.Sharp.IconChar.Faucet;
            this.btnConsumos.IconColor = System.Drawing.Color.White;
            this.btnConsumos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumos.Location = new System.Drawing.Point(0, 342);
            this.btnConsumos.Name = "btnConsumos";
            this.btnConsumos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsumos.Size = new System.Drawing.Size(213, 53);
            this.btnConsumos.TabIndex = 7;
            this.btnConsumos.Tag = "Consumos";
            this.btnConsumos.Text = "Lecturas";
            this.btnConsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumos.UseVisualStyleBackColor = true;
            this.btnConsumos.Click += new System.EventHandler(this.btnConsumos_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContratos.FlatAppearance.BorderSize = 0;
            this.btnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContratos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContratos.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnContratos.IconColor = System.Drawing.Color.White;
            this.btnContratos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratos.Location = new System.Drawing.Point(0, 289);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContratos.Size = new System.Drawing.Size(213, 53);
            this.btnContratos.TabIndex = 5;
            this.btnContratos.Tag = "Contratos";
            this.btnContratos.Text = "Contratos";
            this.btnContratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnBaneos
            // 
            this.btnBaneos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaneos.FlatAppearance.BorderSize = 0;
            this.btnBaneos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaneos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBaneos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBaneos.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnBaneos.IconColor = System.Drawing.Color.White;
            this.btnBaneos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaneos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaneos.Location = new System.Drawing.Point(0, 236);
            this.btnBaneos.Name = "btnBaneos";
            this.btnBaneos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaneos.Size = new System.Drawing.Size(213, 53);
            this.btnBaneos.TabIndex = 8;
            this.btnBaneos.Tag = "Baneos";
            this.btnBaneos.Text = "Baneos";
            this.btnBaneos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaneos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaneos.UseVisualStyleBackColor = true;
            this.btnBaneos.Click += new System.EventHandler(this.btnBaneos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 183);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(213, 53);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Tag = "Clientes";
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 130);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(213, 53);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Tag = "Empleados";
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 77);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(213, 53);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "HOME";
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogol
            // 
            this.panelLogol.BackColor = System.Drawing.Color.Lavender;
            this.panelLogol.Controls.Add(this.btnMenu);
            this.panelLogol.Controls.Add(this.pictureBox1);
            this.panelLogol.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogol.Location = new System.Drawing.Point(0, 0);
            this.panelLogol.Name = "panelLogol";
            this.panelLogol.Size = new System.Drawing.Size(213, 77);
            this.panelLogol.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Lavender;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.SlateBlue;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 50;
            this.btnMenu.Location = new System.Drawing.Point(125, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(88, 77);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.btnMin);
            this.panelTitulo.Controls.Add(this.btnMax);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(230, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(943, 77);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitulo.Location = new System.Drawing.Point(0, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(552, 67);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gpii Water Solutions";
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
            this.btnMin.Location = new System.Drawing.Point(812, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(45, 25);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 20;
            this.btnMax.Location = new System.Drawing.Point(857, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 25);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(901, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMain.Controls.Add(this.picLogoMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 77);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(943, 621);
            this.panelMain.TabIndex = 2;
            // 
            // picLogoMain
            // 
            this.picLogoMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogoMain.Image = global::Gpi_Water.Properties.Resources.GPII_Water;
            this.picLogoMain.Location = new System.Drawing.Point(0, 0);
            this.picLogoMain.Name = "picLogoMain";
            this.picLogoMain.Size = new System.Drawing.Size(943, 621);
            this.picLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMain.TabIndex = 0;
            this.picLogoMain.TabStop = false;
            // 
            // dmSubmenu
            // 
            this.dmSubmenu.IsMainMenu = false;
            this.dmSubmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRepTarifas,
            this.btnRepConsumos,
            this.btnRepGeneral,
            this.btnConHistorico});
            this.dmSubmenu.MenuItemHeight = 25;
            this.dmSubmenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dmSubmenu.Name = "dmSubmenu";
            this.dmSubmenu.PrimaryColor = System.Drawing.Color.Empty;
            this.dmSubmenu.Size = new System.Drawing.Size(192, 92);
            this.dmSubmenu.Text = "Menu de reportes";
            // 
            // btnRepTarifas
            // 
            this.btnRepTarifas.Name = "btnRepTarifas";
            this.btnRepTarifas.Size = new System.Drawing.Size(191, 22);
            this.btnRepTarifas.Text = "Reporte de Tarifas";
            this.btnRepTarifas.Click += new System.EventHandler(this.btnRepTarifas_Click);
            // 
            // btnRepConsumos
            // 
            this.btnRepConsumos.Name = "btnRepConsumos";
            this.btnRepConsumos.Size = new System.Drawing.Size(191, 22);
            this.btnRepConsumos.Text = "Reporte de Consumos";
            this.btnRepConsumos.Click += new System.EventHandler(this.btnRepConsumos_Click);
            // 
            // btnRepGeneral
            // 
            this.btnRepGeneral.Name = "btnRepGeneral";
            this.btnRepGeneral.Size = new System.Drawing.Size(191, 22);
            this.btnRepGeneral.Text = "Reporte General";
            this.btnRepGeneral.Click += new System.EventHandler(this.btnRepGeneral_Click);
            // 
            // btnConHistorico
            // 
            this.btnConHistorico.Name = "btnConHistorico";
            this.btnConHistorico.Size = new System.Drawing.Size(191, 22);
            this.btnConHistorico.Text = "Consumo Historico";
            this.btnConHistorico.Click += new System.EventHandler(this.btnConHistorico_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1173, 698);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panelLogol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).EndInit();
            this.dmSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnBaneos;
        private FontAwesome.Sharp.IconButton btnConsumos;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnTarifas;
        private FontAwesome.Sharp.IconButton btnContratos;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnRecibos;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private System.Windows.Forms.PictureBox picLogoMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private FontAwesome.Sharp.IconPictureBox picUser;
        private RJCodeAdvance.RJControls.RJDropdownMenu dmSubmenu;
        private System.Windows.Forms.ToolStripMenuItem btnRepTarifas;
        private System.Windows.Forms.ToolStripMenuItem btnRepConsumos;
        private System.Windows.Forms.ToolStripMenuItem btnRepGeneral;
        private System.Windows.Forms.ToolStripMenuItem btnConHistorico;
        private FontAwesome.Sharp.IconButton btnZonas;
    }
}