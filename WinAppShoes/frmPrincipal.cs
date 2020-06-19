using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessEntities.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppShoes.Parametros;
using WinAppShoes.WebApiConsumer.Article;
using WinAppShoes.WebApiConsumer.Store;

namespace WinAppShoes
{
    public partial class frmPrincipal : Form
    {
        ArticleApiConsumer articleApiConsumer;
        StoreApiConsumer storeApiConsumer;

        TipoComandoEnum tipo = TipoComandoEnum.Ninguno;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            loadArticles();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            perfilamientoUsuario();

            articleApiConsumer = new ArticleApiConsumer();
            storeApiConsumer = new StoreApiConsumer();

            dgArticles.AutoGenerateColumns = false;

            fillComboFindStore();

            btnNewSave.Text = Recursos.Rscresx.mensajeEtiquetaNuevo;

            loadArticles();
        }

        private void perfilamientoUsuario()
        {
            btnNewSave.Visible = ParametrosSistema.UsuarioLogueado.IdRol == (int)RolEnum.Admin;
        }

        private void fillComboFindStore()
        {
            List<BEStore> lista = null;
            BERespuesta res = storeApiConsumer.GetStores();

            if (!res.success)
            {
                MessageBox.Show(string.Format(Recursos.Rscresx.mensajeEtiquetaOcurrioUnError, string.Empty),
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lista = JsonConvert.DeserializeObject<List<BEStore>>(res.stores.ToString());
            if (lista != null)
                lista.Insert(0, new BEStore { id = 0, name = Recursos.Rscresx.mensajeEtiquetaTodas });

            cmbFindStore.DataSource = lista;
            cmbFindStore.SelectedIndexChanged += (s, evt) =>
            {
                loadArticles();
            };
        }

        private void fillComboStore()
        {
            List<BEStore> lista = null;
            BERespuesta res = storeApiConsumer.GetStores();

            if (!res.success)
            {
                MessageBox.Show(string.Format("Ocurrio un error:"), Recursos.Rscresx.mensajeEtiquetaAviso,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lista = JsonConvert.DeserializeObject<List<BEStore>>(res.stores.ToString());
            if (lista != null)
                lista.Insert(0, new BEStore { id = 0, name = Recursos.Rscresx.mensajeEtiquetaSeleccioneUnaOpcion });

            cmbStore.DataSource = lista;
        }

        private void loadArticles()
        {
            List<BEArticle> lista = null;

            BEStore store = cmbFindStore.SelectedItem as BEStore;
            short? idStore = null;
            if (store != null && store.id > 0)
                idStore = store.id;

            BERespuesta res = articleApiConsumer.GetArticles(idStore);
            if (!res.success)
            {
                MessageBox.Show(string.Format(Recursos.Rscresx.mensajeEtiquetaOcurrioUnError, string.Empty),
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lista = JsonConvert.DeserializeObject<List<BEArticle>>(res.articles.ToString());

            dgArticles.DataSource = lista;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (tipo == TipoComandoEnum.Ninguno)
            {
                this.Close();
            }
            else if (tipo == TipoComandoEnum.Nuevo)
            {
                btnClose.Text = Recursos.Rscresx.mensajeEtiquetaCerrar;
                btnNewSave.Text = Recursos.Rscresx.mensajeEtiquetaNuevo;

                cleanControls();
                enabledControls(false);

                tipo = TipoComandoEnum.Ninguno;
            }
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            if (tipo == TipoComandoEnum.Ninguno)
                newArticle();
            else if (tipo == TipoComandoEnum.Nuevo)
                saveArticle();
        }

        private void saveArticle()
        {
            if (ValidateData())
            {
                BEStore store = cmbStore.SelectedItem as BEStore;

                string name = txtName.Text;
                string description = txtDescription.Text;
                int totalInVault = int.Parse(txtTotalInVault.Text);
                int totalInShelf = int.Parse(txtTotalInShelf.Text);
                short storeId = store.id;
                decimal price = decimal.Parse(txtPrice.Text);

                BERespuesta res = articleApiConsumer.AddArticle(name, description, price, totalInShelf, totalInVault,
                    storeId);

                if (res.success)
                {
                    MessageBox.Show("Se ha guardado el articulo de manera satisfactoria. Presione OK", Recursos.Rscresx.mensajeEtiquetaAviso,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cleanControls();
                    enabledControls(false);

                    btnNewSave.Text = Recursos.Rscresx.mensajeEtiquetaNuevo;
                    btnClose.Text = Recursos.Rscresx.mensajeEtiquetaCerrar;

                    tipo = TipoComandoEnum.Ninguno;

                    loadArticles();
                }
                else
                {
                    MessageBox.Show(Recursos.Rscresx.mensajeEtiquetaErrorArticuloGuardar, Recursos.Rscresx.mensajeEtiquetaAviso,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cleanControls()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtTotalInShelf.Text = string.Empty;
            txtTotalInVault.Text = string.Empty;

            if (cmbStore.Items.Count > 0)
                cmbStore.SelectedIndex = 0;
        }

        private bool ValidateData()
        {
            bool res = true;
            decimal price = 0;
            int totalInShelf = 0;

            decimal.TryParse(txtPrice.Text, out price);
            BEStore store = cmbStore.SelectedItem as BEStore;
            int.TryParse(txtTotalInShelf.Text, out totalInShelf);

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Es necesario suministrar el nombre del articulo.",
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtName.Focus();

                res = false;
            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Es necesario suministrar la descripción del articulo.",
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDescription.Focus();
                res = false;
            }
            else if (price <= 0)
            {
                MessageBox.Show("Es necesario suministrar el precio del articulo.",
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPrice.Focus();
                res = false;
            }
            else if (totalInShelf <= 0)
            {
                MessageBox.Show("Es necesario suministrar el total en boveda del articulo.",
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtTotalInShelf.Focus();
                res = false;
            }
            else if (store == null || store.id <= 0)
            {
                MessageBox.Show("Es necesario seleccionar la tienda a la que pertenece el articulo.",
                    Recursos.Rscresx.mensajeEtiquetaAviso, MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbStore.Focus();
                res = false;
            }

            return res;
        }

        private void newArticle()
        {
            btnNewSave.Text = Recursos.Rscresx.mensajeEtiquetaGuardar;
            btnClose.Text = Recursos.Rscresx.mensajeEtiquetaCancelarNuevo;
            tipo = TipoComandoEnum.Nuevo;

            enabledControls(true);
            fillComboStore();

            txtName.Focus();
        }

        private void enabledControls(bool enabled)
        {
            txtDescription.Enabled = enabled;
            txtName.Enabled = enabled;
            txtPrice.Enabled = enabled;
            txtTotalInShelf.Enabled = enabled;
            txtTotalInVault.Enabled = enabled;

            cmbStore.Enabled = enabled;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                cmbStore.Focus();
        }

        private void cmbStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                txtDescription.Focus();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                txtPrice.Focus();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                txtTotalInVault.Focus();
        }

        private void txtTotalInVault_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                txtTotalInShelf.Focus();
        }

        private void txtTotalInShelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
                btnNewSave.Focus();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms != null && Application.OpenForms.Count > 0)
            //{
            //    FormCollection forms = Application.OpenForms;
            //    do
            //    {
            //        Form item = forms[0];
            //        item.Close();

            //        if (forms.Count == 0)
            //            break;
            //    } while (1 != 0);
            //}
        }
    }
}
