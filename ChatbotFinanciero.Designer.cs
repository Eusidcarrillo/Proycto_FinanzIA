namespace FinanzIA
{
    partial class ChatbotFinanciero
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtmensajeBot = new System.Windows.Forms.TextBox();
            this.picBot = new FontAwesome.Sharp.IconPictureBox();
            this.lbChatBot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnviar.Location = new System.Drawing.Point(411, 276);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(118, 34);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // txtmensajeBot
            // 
            this.txtmensajeBot.Location = new System.Drawing.Point(12, 281);
            this.txtmensajeBot.Name = "txtmensajeBot";
            this.txtmensajeBot.Size = new System.Drawing.Size(379, 26);
            this.txtmensajeBot.TabIndex = 8;
            // 
            // picBot
            // 
            this.picBot.BackColor = System.Drawing.Color.Transparent;
            this.picBot.ForeColor = System.Drawing.Color.Gainsboro;
            this.picBot.IconChar = FontAwesome.Sharp.IconChar.Robot;
            this.picBot.IconColor = System.Drawing.Color.Gainsboro;
            this.picBot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picBot.IconSize = 139;
            this.picBot.Location = new System.Drawing.Point(221, 71);
            this.picBot.Name = "picBot";
            this.picBot.Size = new System.Drawing.Size(139, 139);
            this.picBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBot.TabIndex = 9;
            this.picBot.TabStop = false;
            // 
            // lbChatBot
            // 
            this.lbChatBot.AutoSize = true;
            this.lbChatBot.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChatBot.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbChatBot.Location = new System.Drawing.Point(236, 18);
            this.lbChatBot.Name = "lbChatBot";
            this.lbChatBot.Size = new System.Drawing.Size(105, 29);
            this.lbChatBot.TabIndex = 10;
            this.lbChatBot.Text = "Chat Bot";
            // 
            // ChatbotFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.lbChatBot);
            this.Controls.Add(this.picBot);
            this.Controls.Add(this.txtmensajeBot);
            this.Controls.Add(this.btnEnviar);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatbotFinanciero";
            this.Text = "Chatbot Financiero";
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtmensajeBot;
        private FontAwesome.Sharp.IconPictureBox picBot;
        private System.Windows.Forms.Label lbChatBot;
    }
}