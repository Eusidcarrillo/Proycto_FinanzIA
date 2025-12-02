namespace FinanzIA
{
    partial class GestionIngresosGastos
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
            this.lbTipoMovimiento = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbTablaMovimientosRecientes = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbMonto = new System.Windows.Forms.Label();
            this.cbxTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngresoGasto = new System.Windows.Forms.DateTimePicker();
            this.dgvTablaMovimientosRecientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaMovimientosRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTipoMovimiento
            // 
            this.lbTipoMovimiento.AutoSize = true;
            this.lbTipoMovimiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTipoMovimiento.Location = new System.Drawing.Point(27, 9);
            this.lbTipoMovimiento.Name = "lbTipoMovimiento";
            this.lbTipoMovimiento.Size = new System.Drawing.Size(150, 18);
            this.lbTipoMovimiento.TabIndex = 0;
            this.lbTipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCategoria.Location = new System.Drawing.Point(27, 112);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(75, 18);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFecha.Location = new System.Drawing.Point(27, 157);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(50, 18);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDescripcion.Location = new System.Drawing.Point(27, 207);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(89, 18);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbTablaMovimientosRecientes
            // 
            this.lbTablaMovimientosRecientes.AutoSize = true;
            this.lbTablaMovimientosRecientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTablaMovimientosRecientes.Location = new System.Drawing.Point(27, 293);
            this.lbTablaMovimientosRecientes.Name = "lbTablaMovimientosRecientes";
            this.lbTablaMovimientosRecientes.Size = new System.Drawing.Size(237, 18);
            this.lbTablaMovimientosRecientes.TabIndex = 5;
            this.lbTablaMovimientosRecientes.Text = "Tabla de Movimientos Recientes";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(82, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(232, 256);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(374, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Location = new System.Drawing.Point(30, 83);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(398, 26);
            this.txtMonto.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(30, 224);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(398, 26);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbMonto.Location = new System.Drawing.Point(27, 65);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(54, 18);
            this.lbMonto.TabIndex = 1;
            this.lbMonto.Text = "Monto";
            this.lbMonto.Click += new System.EventHandler(this.lbMonto_Click);
            // 
            // cbxTipoMovimiento
            // 
            this.cbxTipoMovimiento.FormattingEnabled = true;
            this.cbxTipoMovimiento.Location = new System.Drawing.Point(30, 36);
            this.cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            this.cbxTipoMovimiento.Size = new System.Drawing.Size(398, 26);
            this.cbxTipoMovimiento.TabIndex = 12;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(30, 128);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(398, 26);
            this.cbxCategoria.TabIndex = 13;
            // 
            // dtpFechaIngresoGasto
            // 
            this.dtpFechaIngresoGasto.Location = new System.Drawing.Point(30, 174);
            this.dtpFechaIngresoGasto.Name = "dtpFechaIngresoGasto";
            this.dtpFechaIngresoGasto.Size = new System.Drawing.Size(296, 26);
            this.dtpFechaIngresoGasto.TabIndex = 14;
            // 
            // dgvTablaMovimientosRecientes
            // 
            this.dgvTablaMovimientosRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaMovimientosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaMovimientosRecientes.Location = new System.Drawing.Point(30, 314);
            this.dgvTablaMovimientosRecientes.Name = "dgvTablaMovimientosRecientes";
            this.dgvTablaMovimientosRecientes.Size = new System.Drawing.Size(503, 9);
            this.dgvTablaMovimientosRecientes.TabIndex = 15;
            // 
            // GestionIngresosGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.dgvTablaMovimientosRecientes);
            this.Controls.Add(this.dtpFechaIngresoGasto);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxTipoMovimiento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbTablaMovimientosRecientes);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.lbTipoMovimiento);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionIngresosGastos";
            this.Text = "Gestion de Ingresos y Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaMovimientosRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoMovimiento;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbTablaMovimientosRecientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.ComboBox cbxTipoMovimiento;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoGasto;
        private System.Windows.Forms.DataGridView dgvTablaMovimientosRecientes;
    }
}