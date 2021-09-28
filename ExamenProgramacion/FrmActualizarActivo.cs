using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoMain;
using DoMain.Enums;
using Infraestructure;

namespace ExamenProgramacion
{
    public partial class FrmActualizarActivo : Form
    {
        public ActivoModel aModel { get; set; }
        public ActivoFijo AFijo { get; set; }
        public FrmActualizarActivo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          //  cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo)).Cast<object>().ToArray());
            string nombre = textBox1.Text;
            string codigo = textBox2.Text;
            string descripcion = textBox3.Text;
            decimal valor = (int)numericUpDown1.Value;
            DateTime fechaadquisicion = dateTimePicker1.Value;
            TipoActivoFijo tipo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex;

            ActivoFijo af = new ActivoFijo();
            af.NombreActivo = nombre;
          //  af.CodigoActivo = int.Parse(textBox2.Text);
            af.Descripcion = descripcion;
            af.ValorActivo = valor;
            af.FechaAdquisicion = fechaadquisicion;
            af.TipoAFijo = tipo;

            aModel.Add();
            Dispose();
        }

    }
}
