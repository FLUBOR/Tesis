using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//using ComunicacionArduino.Properties;


namespace Prueba_prototipo
{
    public partial class Form1 : Form
    {
        Form2 conexionPuerto;
        Carga carga = new Carga();
 

        private delegate void DelegadoAcceso(string accion);
        private string strBufferIn;
        private string strBufferOut;
        public Form1()
        {
            InitializeComponent();
            conexionPuerto = new Form2();
            strBufferIn = "";
            strBufferOut = "";
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            //--------------------
            txtBuffer.Text = strBufferIn;
            //--------------------
        }

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso VarDelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(VarDelegadoAcceso, arg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionPuerto.ShowDialog();

            try
            {
                SpPuertos.PortName = Form2.puertoSeleccionado.puertoSelec;
                SpPuertos.BaudRate = 9600;
                SpPuertos.DataBits = 8;
                SpPuertos.Parity = Parity.None;
                SpPuertos.StopBits = StopBits.One;
                SpPuertos.Handshake = Handshake.None;
                SpPuertos.DtrEnable = true;
                SpPuertos.Open();
                SpPuertos.DataReceived += serialPort1_DataReceived;
                carga.ShowDialog();
                //MessageBox.Show("Conectado");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = SpPuertos.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);

        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            txtBuffer.Text = line;
        }

        private void RdModoManual_CheckedChanged(object sender, EventArgs e)
        {
            if (RdOptionAutomatico.Checked)
            {
                txtValorMax.Visible = true;
                txtValorMin.Visible = true;
                lblValorMax.Visible = true;
                lblValorMin.Visible = true;
                BtnEnviarDatosRA.Visible = true;
                BtnRiegoManual.Visible = false;
            }
            else
            {
                txtValorMax.Visible = false;
                txtValorMin.Visible = false;
                lblValorMax.Visible = false;
                lblValorMin.Visible = false;
                BtnEnviarDatosRA.Visible = false;
                BtnRiegoManual.Visible = true;
                BtnRiegoManual.Text = "Encender";
                BtnRiegoManual.BackColor = Color.Green;
            }
        }

        private void BtnRiegoManual_Click(object sender, EventArgs e)
        {
            //(0-Apagado - 1-Encendido - 2-Automatico) - var max - var min

            if(BtnRiegoManual.Text == "Encender")
            {
                SpPuertos.Write("1,0,0");
                BtnRiegoManual.BackColor = Color.Red;
                BtnRiegoManual.Text = "Apagar";
            }
            else
            {
                SpPuertos.Write("0,0,0");
                BtnRiegoManual.BackColor = Color.Green;
                BtnRiegoManual.Text = "Encender";
            }
        }

        private void txtBuffer_TextChanged(object sender, EventArgs e)
        {
            //De aqui agarramos lo que recibimos y lo ponemos en el listview
            string[] Datos = txtBuffer.Text.Split(',');  //separamos lo que mandamos por medio de comas
            try
            {
                ListViewItem lista = new ListViewItem(DateTime.Now.ToString());
                lista.SubItems.Add(Datos[1]);
                lista.SubItems.Add(Datos[2]);
                lista.SubItems.Add(Datos[3]);

                int diferencial = Int32.Parse(Datos[0]);
                if (diferencial == 0)
                    LvDatos1.Items.Add(lista);
                else if (diferencial == 1)
                    LvDatos2.Items.Add(lista);
            }
            catch (Exception)
            {
                //MessageBox.Show(exc.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void BtnEnviarDatosRA_Click(object sender, EventArgs e)
        {
            try
            {
                SpPuertos.DiscardOutBuffer();
                strBufferOut = "2,";
                strBufferOut += txtValorMax.Text;
                strBufferOut += ",";
                strBufferOut += txtValorMin.Text;
                SpPuertos.Write(strBufferOut);
                MessageBox.Show("El riego automatico esta encendido", "Riego automatico activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RdOptionAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            SpPuertos.Write("0,0,0");
        }
    }
}
