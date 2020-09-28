namespace AgendaContactos
{
    partial class frmAddContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAgregarMod = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.GroupSexo = new System.Windows.Forms.GroupBox();
            this.rdoOtros = new System.Windows.Forms.RadioButton();
            this.rdoFem = new System.Windows.Forms.RadioButton();
            this.rdoMas = new System.Windows.Forms.RadioButton();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ErrorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.GroupSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAgregarMod);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.GroupSexo);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar o Modificar Contacto";
            // 
            // txtAgregarMod
            // 
            this.txtAgregarMod.Location = new System.Drawing.Point(152, 306);
            this.txtAgregarMod.Name = "txtAgregarMod";
            this.txtAgregarMod.Size = new System.Drawing.Size(160, 36);
            this.txtAgregarMod.TabIndex = 8;
            this.txtAgregarMod.Text = "Agregar / Modificar";
            this.txtAgregarMod.UseVisualStyleBackColor = true;
            this.txtAgregarMod.Click += new System.EventHandler(this.txtAgregarMod_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(17, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 23);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 246);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Emai:";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(17, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 15);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(292, 100);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 23);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(288, 81);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(86, 15);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono Movil";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(293, 216);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(170, 23);
            this.txtPais.TabIndex = 7;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(289, 196);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(31, 15);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "Pais:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Location = new System.Drawing.Point(17, 216);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(198, 23);
            this.txtCiudad.TabIndex = 6;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(14, 196);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(47, 15);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(293, 164);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 23);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(289, 144);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // GroupSexo
            // 
            this.GroupSexo.Controls.Add(this.rdoOtros);
            this.GroupSexo.Controls.Add(this.rdoFem);
            this.GroupSexo.Controls.Add(this.rdoMas);
            this.GroupSexo.Location = new System.Drawing.Point(17, 132);
            this.GroupSexo.Name = "GroupSexo";
            this.GroupSexo.Size = new System.Drawing.Size(239, 55);
            this.GroupSexo.TabIndex = 4;
            this.GroupSexo.TabStop = false;
            this.GroupSexo.Text = "Sexo";
            // 
            // rdoOtros
            // 
            this.rdoOtros.AutoSize = true;
            this.rdoOtros.Location = new System.Drawing.Point(185, 23);
            this.rdoOtros.Name = "rdoOtros";
            this.rdoOtros.Size = new System.Drawing.Size(54, 19);
            this.rdoOtros.TabIndex = 2;
            this.rdoOtros.TabStop = true;
            this.rdoOtros.Text = "Otros";
            this.rdoOtros.UseVisualStyleBackColor = true;
            // 
            // rdoFem
            // 
            this.rdoFem.AutoSize = true;
            this.rdoFem.Location = new System.Drawing.Point(100, 22);
            this.rdoFem.Name = "rdoFem";
            this.rdoFem.Size = new System.Drawing.Size(78, 19);
            this.rdoFem.TabIndex = 1;
            this.rdoFem.TabStop = true;
            this.rdoFem.Text = "Femenino";
            this.rdoFem.UseVisualStyleBackColor = true;
            // 
            // rdoMas
            // 
            this.rdoMas.AutoSize = true;
            this.rdoMas.Checked = true;
            this.rdoMas.Location = new System.Drawing.Point(8, 23);
            this.rdoMas.Name = "rdoMas";
            this.rdoMas.Size = new System.Drawing.Size(80, 19);
            this.rdoMas.TabIndex = 0;
            this.rdoMas.TabStop = true;
            this.rdoMas.Text = "Masculino";
            this.rdoMas.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Location = new System.Drawing.Point(17, 100);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(198, 23);
            this.txtApellidos.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(14, 81);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(62, 15);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos: ";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(87, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(486, 191);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ErrorPro
            // 
            this.ErrorPro.ContainerControl = this;
            // 
            // frmAddContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(504, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar /  Modificar Contacto";
            this.Load += new System.EventHandler(this.frmAddContacto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupSexo.ResumeLayout(false);
            this.GroupSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupSexo;
        private System.Windows.Forms.RadioButton rdoOtros;
        private System.Windows.Forms.RadioButton rdoFem;
        private System.Windows.Forms.RadioButton rdoMas;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button txtAgregarMod;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ErrorProvider ErrorPro;
    }
}