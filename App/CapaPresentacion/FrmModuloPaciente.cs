using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmModuloPaciente : Form
    {
        public FrmModuloPaciente()
        {
            InitializeComponent();
        }

        //Mostrar mensaje de ok
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema Clinico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Mostrar mensaje Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Clinico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void Limpiar()
        { 
            this.txtCodigoPaciente.Text= string.Empty;
            this.txtNombrePaciente.Text= string.Empty;
            this.txtApellidoPaciente.Text = string.Empty;
            this.txtDireccionPaciente.Text = string.Empty;
            this.txtTelefonoPaciente.Text = string.Empty;
            this.txtFechaNacimientoPaciente.Text = string.Empty;
            this.cbxEECC.SelectedIndex = -1;
            this.cbxGenero.SelectedIndex = -1;
        }

        private void FrmModuloPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
