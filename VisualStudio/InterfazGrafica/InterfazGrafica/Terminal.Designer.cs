﻿namespace InterfazGrafica
{
    partial class Terminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.LConexion = new System.Windows.Forms.Label();
            this.LimiparTerminal = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.PictureBox();
            this.GBx_Comando = new System.Windows.Forms.GroupBox();
            this.TxBxComando = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.RTBx_Terminal = new System.Windows.Forms.RichTextBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.BtnConexion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            this.GBx_Comando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConexion)).BeginInit();
            this.SuspendLayout();
            // 
            // LConexion
            // 
            this.LConexion.AutoSize = true;
            this.LConexion.BackColor = System.Drawing.Color.Transparent;
            this.LConexion.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LConexion.Location = new System.Drawing.Point(23, 10);
            this.LConexion.Name = "LConexion";
            this.LConexion.Size = new System.Drawing.Size(64, 14);
            this.LConexion.TabIndex = 40;
            this.LConexion.Text = "Conectar";
            this.LConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LimiparTerminal
            // 
            this.LimiparTerminal.AutoSize = true;
            this.LimiparTerminal.BackColor = System.Drawing.Color.Transparent;
            this.LimiparTerminal.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiparTerminal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LimiparTerminal.Location = new System.Drawing.Point(113, 81);
            this.LimiparTerminal.Name = "LimiparTerminal";
            this.LimiparTerminal.Size = new System.Drawing.Size(108, 14);
            this.LimiparTerminal.TabIndex = 39;
            this.LimiparTerminal.Text = "Limpiar Terminal";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Location = new System.Drawing.Point(135, 26);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(62, 52);
            this.BtnLimpiar.TabIndex = 38;
            this.BtnLimpiar.TabStop = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // GBx_Comando
            // 
            this.GBx_Comando.BackColor = System.Drawing.Color.Transparent;
            this.GBx_Comando.Controls.Add(this.TxBxComando);
            this.GBx_Comando.Controls.Add(this.BtnEnviar);
            this.GBx_Comando.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Comando.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBx_Comando.Location = new System.Drawing.Point(17, 128);
            this.GBx_Comando.Name = "GBx_Comando";
            this.GBx_Comando.Size = new System.Drawing.Size(207, 89);
            this.GBx_Comando.TabIndex = 37;
            this.GBx_Comando.TabStop = false;
            this.GBx_Comando.Text = "Comando";
            // 
            // TxBxComando
            // 
            this.TxBxComando.Font = new System.Drawing.Font("SuperFrench", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TxBxComando.Location = new System.Drawing.Point(14, 24);
            this.TxBxComando.Name = "TxBxComando";
            this.TxBxComando.Size = new System.Drawing.Size(181, 21);
            this.TxBxComando.TabIndex = 1;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEnviar.Location = new System.Drawing.Point(64, 54);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 0;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(18, 86);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(73, 21);
            this.PuertoList.TabIndex = 35;
            // 
            // RTBx_Terminal
            // 
            this.RTBx_Terminal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RTBx_Terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBx_Terminal.ForeColor = System.Drawing.SystemColors.Window;
            this.RTBx_Terminal.Location = new System.Drawing.Point(260, -1);
            this.RTBx_Terminal.Name = "RTBx_Terminal";
            this.RTBx_Terminal.Size = new System.Drawing.Size(276, 342);
            this.RTBx_Terminal.TabIndex = 41;
            this.RTBx_Terminal.Text = "";
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackColor = System.Drawing.Color.Transparent;
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(24, 27);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(61, 56);
            this.BtnConexion.TabIndex = 42;
            this.BtnConexion.TabStop = false;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 340);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.RTBx_Terminal);
            this.Controls.Add(this.LConexion);
            this.Controls.Add(this.LimiparTerminal);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.GBx_Comando);
            this.Controls.Add(this.PuertoList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terminal";
            this.Text = "Terminal";
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            this.GBx_Comando.ResumeLayout(false);
            this.GBx_Comando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LConexion;
        private System.Windows.Forms.Label LimiparTerminal;
        private System.Windows.Forms.PictureBox BtnLimpiar;
        private System.Windows.Forms.GroupBox GBx_Comando;
        private System.Windows.Forms.TextBox TxBxComando;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.Windows.Forms.RichTextBox RTBx_Terminal;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.PictureBox BtnConexion;
    }
}