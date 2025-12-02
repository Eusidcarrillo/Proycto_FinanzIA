namespace FinanzIA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lnkOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.lbCorreoElectronico = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.txtcorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkOlvideContraseña
            // 
            this.lnkOlvideContraseña.AutoSize = true;
            this.lnkOlvideContraseña.ForeColor = System.Drawing.Color.Gainsboro;
            this.lnkOlvideContraseña.Location = new System.Drawing.Point(50, 392);
            this.lnkOlvideContraseña.Name = "lnkOlvideContraseña";
            this.lnkOlvideContraseña.Size = new System.Drawing.Size(183, 18);
            this.lnkOlvideContraseña.TabIndex = 1;
            this.lnkOlvideContraseña.TabStop = true;
            this.lnkOlvideContraseña.Text = "¿Olvidste tu contraseña?";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Green;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.Location = new System.Drawing.Point(70, 308);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIniciarSesion.Size = new System.Drawing.Size(143, 45);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // lbCorreoElectronico
            // 
            this.lbCorreoElectronico.AutoSize = true;
            this.lbCorreoElectronico.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCorreoElectronico.Location = new System.Drawing.Point(15, 147);
            this.lbCorreoElectronico.Name = "lbCorreoElectronico";
            this.lbCorreoElectronico.Size = new System.Drawing.Size(136, 18);
            this.lbCorreoElectronico.TabIndex = 5;
            this.lbCorreoElectronico.Text = "Correo electronico";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbContraseña.Location = new System.Drawing.Point(15, 217);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(88, 18);
            this.lbContraseña.TabIndex = 6;
            this.lbContraseña.Text = "Contraseña";
            // 
            // txtcorreoElectronico
            // 
            this.txtcorreoElectronico.Location = new System.Drawing.Point(15, 180);
            this.txtcorreoElectronico.Name = "txtcorreoElectronico";
            this.txtcorreoElectronico.Size = new System.Drawing.Size(257, 26);
            this.txtcorreoElectronico.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(15, 251);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(257, 26);
            this.txtContraseña.TabIndex = 8;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(18, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(246, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(284, 447);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtcorreoElectronico);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbCorreoElectronico);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lnkOlvideContraseña);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion Finanzia";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkOlvideContraseña;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private System.Windows.Forms.Label lbCorreoElectronico;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txtcorreoElectronico;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox picLogo;
    }
}