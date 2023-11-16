using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TPLab_Parcial2_Luna_2023
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusHora.Text = DateTime.Now.ToLongTimeString();
            statusFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoEmpleados fEmpleados = new frmListadoEmpleados();
            fEmpleados.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ClsEmpleados Empleado = new ClsEmpleados();
            Empleado.ConectarBase();
        }
    }
}
