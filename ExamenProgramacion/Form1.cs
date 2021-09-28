using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgramacion
{
    public partial class Form1 : Form
    {
        private ActivoModel activoModel;
        public Form1()
        {
            activoModel = new ActivoModel();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmActualizarActivo frmActActivo = new FrmActualizarActivo();
            frmActActivo.ShowDialog();

            rtbActiveView.Text = activoModel.GetActiveAsJason();
        }
    }
}
