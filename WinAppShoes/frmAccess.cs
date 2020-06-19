using BusinessEntities.ViewModel;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppShoes
{
    public partial class frmAccess : Form
    {
        public bool LogueoCorrecto = false;

        public frmAccess()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtUsername.Text))
            {
                Login();
            }
            else
            {
                MessageBox.Show("Es necesario suministrar el nombre de usuario y/o contraseña.", Recursos.Rscresx.mensajeEtiquetaAviso,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login()
        {
            BLLUser bll = new BLLUser();

            BEUser user = bll.ValidateUser(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Nombre de usuario y/o Contraseña incorrectas", Recursos.Rscresx.mensajeEtiquetaAviso,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Focus();
            }
            else
            {
                LogueoCorrecto = true;
                Parametros.ParametrosSistema.UsuarioLogueado = user;
                this.Hide();

                frmPrincipal form = new frmPrincipal();

                form.ShowDialog();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                btnAccess.Focus();
        }

        private void frmAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
