using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCheque
{
    public partial class frmCheque : Form
    {
        public frmCheque()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if(this.txtCantidad.TextLength== 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad");
                this.txtCantidad.Focus();
                return;

            }
            //act para el estudiante: validar que txtCantidad tenga valores númericos con tryParse
            //validar que el nombre esté ingresado de manera obligatoria
            int num= Int32.Parse(this.txtCantidad.Text);
            string res = Utilidades.getCentenas(num);
            this.txtResultado.Text = res;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
