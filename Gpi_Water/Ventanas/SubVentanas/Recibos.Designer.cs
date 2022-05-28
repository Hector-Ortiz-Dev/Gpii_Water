namespace Gpi_Water.Ventanas.SubVentanas
{
    partial class Recibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibos));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new RJCodeAdvance.RJControls.RJTextBox();
            this.dgRecibos = new System.Windows.Forms.DataGridView();
            this.btnPagar = new RJCodeAdvance.RJControls.RJButton();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meses_adeudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.por_pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecibos)).BeginInit();
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
            this.btnCerrar.Location = new System.Drawing.Point(934, 0);
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
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recibos";
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
            this.panel1.Size = new System.Drawing.Size(984, 44);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.dgRecibos);
            this.panel2.Controls.Add(this.btnPagar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 567);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(270, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.Location = new System.Drawing.Point(270, 501);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.Size = new System.Drawing.Size(250, 37);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Texts = "";
            this.txtCantidad.UnderlinedStyle = false;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dgRecibos
            // 
            this.dgRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRecibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgRecibos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgRecibos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRecibos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRecibos.ColumnHeadersHeight = 40;
            this.dgRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.año,
            this.mes,
            this.medidor,
            this.total_pago,
            this.pagado,
            this.pendiente_pago,
            this.subtotal1,
            this.subtotal2,
            this.iva,
            this.meses_adeudo,
            this.subtotal3,
            this.por_pagar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRecibos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRecibos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgRecibos.EnableHeadersVisualStyles = false;
            this.dgRecibos.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgRecibos.Location = new System.Drawing.Point(0, 0);
            this.dgRecibos.Name = "dgRecibos";
            this.dgRecibos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRecibos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRecibos.RowTemplate.Height = 25;
            this.dgRecibos.Size = new System.Drawing.Size(984, 459);
            this.dgRecibos.TabIndex = 3;
            this.dgRecibos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRecibos_CellClick);
            // 
            // btnPagar
            // 
            this.btnPagar.AutoSize = true;
            this.btnPagar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPagar.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btnPagar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPagar.BorderRadius = 20;
            this.btnPagar.BorderSize = 0;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPagar.Location = new System.Drawing.Point(569, 484);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Padding = new System.Windows.Forms.Padding(10);
            this.btnPagar.Size = new System.Drawing.Size(171, 54);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextColor = System.Drawing.Color.AliceBlue;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Folio";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // medidor
            // 
            this.medidor.DataPropertyName = "medidor";
            this.medidor.HeaderText = "Medidor";
            this.medidor.Name = "medidor";
            this.medidor.ReadOnly = true;
            // 
            // total_pago
            // 
            this.total_pago.DataPropertyName = "total_pago";
            this.total_pago.HeaderText = "Total del mes";
            this.total_pago.Name = "total_pago";
            this.total_pago.ReadOnly = true;
            // 
            // pagado
            // 
            this.pagado.DataPropertyName = "pagado";
            this.pagado.HeaderText = "Cantidad pagada";
            this.pagado.Name = "pagado";
            this.pagado.ReadOnly = true;
            // 
            // pendiente_pago
            // 
            this.pendiente_pago.DataPropertyName = "pendiente_pago";
            this.pendiente_pago.HeaderText = "pendiente_pago";
            this.pendiente_pago.Name = "pendiente_pago";
            this.pendiente_pago.ReadOnly = true;
            this.pendiente_pago.Visible = false;
            // 
            // subtotal1
            // 
            this.subtotal1.DataPropertyName = "subtotal1";
            this.subtotal1.HeaderText = "subtotal1";
            this.subtotal1.Name = "subtotal1";
            this.subtotal1.ReadOnly = true;
            this.subtotal1.Visible = false;
            // 
            // subtotal2
            // 
            this.subtotal2.DataPropertyName = "subtotal2";
            this.subtotal2.HeaderText = "subtotal2";
            this.subtotal2.Name = "subtotal2";
            this.subtotal2.ReadOnly = true;
            this.subtotal2.Visible = false;
            // 
            // iva
            // 
            this.iva.DataPropertyName = "iva";
            this.iva.HeaderText = "iva";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Visible = false;
            // 
            // meses_adeudo
            // 
            this.meses_adeudo.DataPropertyName = "meses_adeudo";
            this.meses_adeudo.HeaderText = "meses_adeudo";
            this.meses_adeudo.Name = "meses_adeudo";
            this.meses_adeudo.ReadOnly = true;
            this.meses_adeudo.Visible = false;
            // 
            // subtotal3
            // 
            this.subtotal3.DataPropertyName = "subtotal3";
            this.subtotal3.HeaderText = "subtotal3";
            this.subtotal3.Name = "subtotal3";
            this.subtotal3.ReadOnly = true;
            this.subtotal3.Visible = false;
            // 
            // por_pagar
            // 
            this.por_pagar.DataPropertyName = "por_pagar";
            this.por_pagar.HeaderText = "Por pagar";
            this.por_pagar.Name = "por_pagar";
            this.por_pagar.ReadOnly = true;
            // 
            // Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimizeBox = false;
            this.Name = "Recibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Recibos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btnPagar;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.DataGridView dgRecibos;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn meses_adeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal3;
        private System.Windows.Forms.DataGridViewTextBoxColumn por_pagar;
    }
}