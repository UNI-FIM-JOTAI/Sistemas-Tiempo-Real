﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace InterfazGrafica
{
    public partial class Terminal : Form
    {
        #region DECLARACION DE VARIABLES

        private string data = "";
        int flag_cmd;
        int estado_conexion = 0;

        string msg;

        #endregion

        public Terminal()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
            BtnEnviar.Enabled = false;
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            if (estado_conexion == 0)
            {
                if (!PuertoSerial.IsOpen)
                {
                    PuertoSerial.PortName = PuertoList.Text;
                }

                PuertoSerial.Close();
                PuertoSerial.Open();

                if (!PuertoSerial.IsOpen)
                {
                    MessageBox.Show("No hay un puerto abierto.", "Error de conexión.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Puerto " + PuertoList.Text + " conectado con exito.", "Exito en la conexión.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado_conexion = 1;
                    LConexion.Text = "Desconectar";
                    BtnEnviar.Enabled = true;
                }
            }
            else
            {
                PuertoSerial.Close();
                if (PuertoSerial.IsOpen)
                {
                    MessageBox.Show("No se ha podido desconectar.", "Error en desconexion.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Puerto " + PuertoList.Text + " desconectado con exito.", "Exito en la desconexión.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado_conexion = 0;
                    LConexion.Text = "Conectar";
                    BtnEnviar.Enabled = false;
                }

            }
        }

        private void PuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data += PuertoSerial.ReadExisting();
            data = data.ToString();
            if (data.EndsWith("*"))
            {
                data = data.Remove(data.Length - 1);
                this.Invoke(new EventHandler(ProcesarComando));
            }
        }

        private void ProcesarComando(object s, EventArgs e)
        {
            this.RTBx_Terminal.AppendText("<- " + data + "\n");
            data = "";
            flag_cmd = 1;
        }

        private void EnviarComando(string Enviardato)
        {
            int tam_s = 0;
            string temp_char;
            tam_s = Enviardato.Length;
            if (tam_s != 0)
            {
                this.RTBx_Terminal.AppendText("-> ");
                for (int i = 1; i < tam_s; i++)
                {
                    temp_char = Enviardato.Remove(i);
                    temp_char = temp_char.Remove(0, i - 1);
                    PuertoSerial.Write(temp_char);
                    this.RTBx_Terminal.AppendText(temp_char);

                    Thread.Sleep(50);

                }
                temp_char = Enviardato.Remove(0, tam_s - 1);
                PuertoSerial.Write(temp_char);
                this.RTBx_Terminal.AppendText(temp_char);
                this.RTBx_Terminal.AppendText("\n");
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            RTBx_Terminal.Text = "";
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            msg = Convert.ToString(TxBxComando.Text);
            msg = msg + "*";
            EnviarComando(msg);
        }

    }
}
