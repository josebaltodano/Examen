using Domian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamendeProgramcion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo activo = new ActivoFijo()
            {
                Nombre = txtNombre.Text,
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text,
               

            };
        }
    }
    }

