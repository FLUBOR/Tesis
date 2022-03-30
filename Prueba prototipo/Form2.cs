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

namespace Prueba_prototipo
{
    public partial class Form2 : Form
    {
        public class puertoSeleccionado
        {
            static public string puertoSelec;
        }
        public SerialPort serialPort1;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                puertoSeleccionado.puertoSelec = cmbpuerto.Text;
                serialPort1 = new SerialPort();
                serialPort1.PortName = cmbpuerto.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DtrEnable = true;

                serialPort1.Open();
                //btnconectar.Text = "DESCONECTAR";
                MessageBox.Show("Ahora estas conectado", "Conexion exisota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialPort1.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] puertosDisponibles = SerialPort.GetPortNames();

            cmbpuerto.Items.Clear();

            foreach (string puerto_simple in puertosDisponibles)
            {
                cmbpuerto.Items.Add(puerto_simple);
            }
            if (cmbpuerto.Items.Count > 0)
            {
                cmbpuerto.SelectedIndex = 0;
                //MessageBox.Show("Seleccionar puerto de trabajo", "Puertos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnconectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ningun puerto detectado", "Puertos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbpuerto.Items.Clear();
                cmbpuerto.Text = "                     ";
                //strBufferIn = "";
                //strBufferOut = "";
                btnconectar.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
