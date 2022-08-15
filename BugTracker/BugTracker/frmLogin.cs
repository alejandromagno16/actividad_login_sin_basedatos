using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contraseña");
                return;
            }

            if (ValidarCredenciales(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Ingreso al sistema exitoso");
                this.Close();
            }
            else
            {
                txtUser.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Ingrese usuario o contraseña validos");
            }

        }

        private bool ValidarCredenciales(string text1, string text2)
        {
            return true;
        }
    }
}
