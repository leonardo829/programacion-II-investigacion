using programacionBE;
using programacionFE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programacionFE
{
    public partial class listado : Form
    {
        NuevoUsuario Mynuevo_usuario = new NuevoUsuario();

        public Usuarios Usuarios = new Usuarios();
        public listado()
        {
            InitializeComponent();
            dataGridView1.DataSource = Usuarios.ListaDT;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {





            decimal verificacion;



            if (txtDni.Text == "")
            {

                errorProvider1.SetError(txtDni, "error ingrese un valor");
                txtDni.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError (txtDni, "");
                if (!Decimal.TryParse(txtDni.Text, out verificacion))
                {
                    errorProvider1.SetError(txtDni, "ingrese numeros");
                    return;
                }
                else
                {
                    NuevoUsuario usuario = new NuevoUsuario();
                    errorProvider1.SetError(txtDni, "");
                    usuario.Aceptar(txtNombre.Text,
                    txtApellido.Text,
                    txtDni.Text,
                    listBox1.Text);

                    Usuarios.InsertUsuario(usuario);
                    dataGridView1.DataSource = Usuarios.ListaDT;


                }
               
            }

            



        }

        
   
    }

}
