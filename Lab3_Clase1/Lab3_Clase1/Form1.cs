using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Clase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hallo " + txtNombre.Text + "!");
            MessageBox.Show("Hallo " + txtNombre.Lines[0] + "!");

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.DialogResult resultado;
            resultado = MessageBox.Show("¿En serio querés cerrar la ventana?", "MOMENTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resultado == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

       

    }
}
