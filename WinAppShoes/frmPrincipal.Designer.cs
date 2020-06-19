namespace WinAppShoes
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlArticle = new System.Windows.Forms.Panel();
            this.cmbFindStore = new System.Windows.Forms.ComboBox();
            this.lblFiltroStore = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.dgArticles = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBoveda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalInVault = new System.Windows.Forms.Label();
            this.txtTotalInVault = new System.Windows.Forms.TextBox();
            this.lblTotalInShelf = new System.Windows.Forms.Label();
            this.txtTotalInShelf = new System.Windows.Forms.TextBox();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.lblEncabezadoAltaArticulo = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(9, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(141, 137);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlArticle
            // 
            this.pnlArticle.Controls.Add(this.cmbFindStore);
            this.pnlArticle.Controls.Add(this.lblFiltroStore);
            this.pnlArticle.Controls.Add(this.lblEncabezado);
            this.pnlArticle.Controls.Add(this.dgArticles);
            this.pnlArticle.Controls.Add(this.btnActualizar);
            this.pnlArticle.Location = new System.Drawing.Point(9, 196);
            this.pnlArticle.Name = "pnlArticle";
            this.pnlArticle.Size = new System.Drawing.Size(906, 333);
            this.pnlArticle.TabIndex = 15;
            // 
            // cmbFindStore
            // 
            this.cmbFindStore.DisplayMember = "name";
            this.cmbFindStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindStore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFindStore.FormattingEnabled = true;
            this.cmbFindStore.Location = new System.Drawing.Point(142, 10);
            this.cmbFindStore.Name = "cmbFindStore";
            this.cmbFindStore.Size = new System.Drawing.Size(186, 24);
            this.cmbFindStore.TabIndex = 1;
            this.cmbFindStore.ValueMember = "id";
            // 
            // lblFiltroStore
            // 
            this.lblFiltroStore.AutoSize = true;
            this.lblFiltroStore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroStore.Location = new System.Drawing.Point(12, 13);
            this.lblFiltroStore.Name = "lblFiltroStore";
            this.lblFiltroStore.Size = new System.Drawing.Size(130, 16);
            this.lblFiltroStore.TabIndex = 0;
            this.lblFiltroStore.Text = "Tienda a consultar:";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(411, 12);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(170, 22);
            this.lblEncabezado.TabIndex = 3;
            this.lblEncabezado.Text = "Lista de Articulos";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgArticles
            // 
            this.dgArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.TotalEstante,
            this.TotalBoveda,
            this.Tienda});
            this.dgArticles.Location = new System.Drawing.Point(5, 45);
            this.dgArticles.Name = "dgArticles";
            this.dgArticles.Size = new System.Drawing.Size(891, 284);
            this.dgArticles.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "name";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "description";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "###,##0.0";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // TotalEstante
            // 
            this.TotalEstante.DataPropertyName = "total_in_shelf";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalEstante.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalEstante.HeaderText = "Total en estante";
            this.TotalEstante.Name = "TotalEstante";
            this.TotalEstante.ReadOnly = true;
            // 
            // TotalBoveda
            // 
            this.TotalBoveda.DataPropertyName = "total_in_vault";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalBoveda.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalBoveda.HeaderText = "Total en boveda";
            this.TotalBoveda.Name = "TotalBoveda";
            this.TotalBoveda.ReadOnly = true;
            // 
            // Tienda
            // 
            this.Tienda.DataPropertyName = "store_name";
            this.Tienda.HeaderText = "Tienda";
            this.Tienda.Name = "Tienda";
            this.Tienda.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(334, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(39, 36);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "A";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(171, 107);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Precio:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(258, 104);
            this.txtPrice.MaxLength = 150;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(98, 22);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(171, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Descripción:";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(258, 73);
            this.txtDescription.MaxLength = 150;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(646, 22);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(171, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(258, 42);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 22);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(390, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 30);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTotalInVault
            // 
            this.lblTotalInVault.AutoSize = true;
            this.lblTotalInVault.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInVault.Location = new System.Drawing.Point(423, 107);
            this.lblTotalInVault.Name = "lblTotalInVault";
            this.lblTotalInVault.Size = new System.Drawing.Size(114, 16);
            this.lblTotalInVault.TabIndex = 9;
            this.lblTotalInVault.Text = "Total en boveda:";
            // 
            // txtTotalInVault
            // 
            this.txtTotalInVault.Enabled = false;
            this.txtTotalInVault.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInVault.Location = new System.Drawing.Point(543, 104);
            this.txtTotalInVault.MaxLength = 150;
            this.txtTotalInVault.Name = "txtTotalInVault";
            this.txtTotalInVault.Size = new System.Drawing.Size(91, 22);
            this.txtTotalInVault.TabIndex = 10;
            this.txtTotalInVault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalInVault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalInVault_KeyPress);
            // 
            // lblTotalInShelf
            // 
            this.lblTotalInShelf.AutoSize = true;
            this.lblTotalInShelf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInShelf.Location = new System.Drawing.Point(694, 107);
            this.lblTotalInShelf.Name = "lblTotalInShelf";
            this.lblTotalInShelf.Size = new System.Drawing.Size(113, 16);
            this.lblTotalInShelf.TabIndex = 11;
            this.lblTotalInShelf.Text = "Total en estante:";
            // 
            // txtTotalInShelf
            // 
            this.txtTotalInShelf.Enabled = false;
            this.txtTotalInShelf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInShelf.Location = new System.Drawing.Point(813, 104);
            this.txtTotalInShelf.MaxLength = 150;
            this.txtTotalInShelf.Name = "txtTotalInShelf";
            this.txtTotalInShelf.Size = new System.Drawing.Size(91, 22);
            this.txtTotalInShelf.TabIndex = 12;
            this.txtTotalInShelf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalInShelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalInShelf_KeyPress);
            // 
            // btnNewSave
            // 
            this.btnNewSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSave.Location = new System.Drawing.Point(174, 148);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(176, 30);
            this.btnNewSave.TabIndex = 13;
            this.btnNewSave.Text = "Guardar";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // lblEncabezadoAltaArticulo
            // 
            this.lblEncabezadoAltaArticulo.AutoSize = true;
            this.lblEncabezadoAltaArticulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezadoAltaArticulo.Location = new System.Drawing.Point(164, 9);
            this.lblEncabezadoAltaArticulo.Name = "lblEncabezadoAltaArticulo";
            this.lblEncabezadoAltaArticulo.Size = new System.Drawing.Size(149, 22);
            this.lblEncabezadoAltaArticulo.TabIndex = 0;
            this.lblEncabezadoAltaArticulo.Text = "Alta de Articulo";
            this.lblEncabezadoAltaArticulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.Location = new System.Drawing.Point(629, 45);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(56, 16);
            this.lblTienda.TabIndex = 3;
            this.lblTienda.Text = "Tienda:";
            // 
            // cmbStore
            // 
            this.cmbStore.DisplayMember = "name";
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.Enabled = false;
            this.cmbStore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(691, 40);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(213, 24);
            this.cmbStore.TabIndex = 4;
            this.cmbStore.ValueMember = "id";
            this.cmbStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStore_KeyPress);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 536);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.lblTienda);
            this.Controls.Add(this.lblEncabezadoAltaArticulo);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalInShelf);
            this.Controls.Add(this.pnlArticle);
            this.Controls.Add(this.txtTotalInShelf);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTotalInVault);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTotalInVault);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Super Zapatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlArticle.ResumeLayout(false);
            this.pnlArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlArticle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgArticles;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ComboBox cmbFindStore;
        private System.Windows.Forms.Label lblFiltroStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBoveda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienda;
        private System.Windows.Forms.Label lblTotalInShelf;
        private System.Windows.Forms.TextBox txtTotalInShelf;
        private System.Windows.Forms.Label lblTotalInVault;
        private System.Windows.Forms.TextBox txtTotalInVault;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.Label lblEncabezadoAltaArticulo;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.ComboBox cmbStore;
    }
}

