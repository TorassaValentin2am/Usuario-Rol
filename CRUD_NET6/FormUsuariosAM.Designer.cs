namespace CRUD
{
    partial class FormUsuariosAM
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtNombre = new TextBox();
            lblDestino = new Label();
            txtEmail = new TextBox();
            lblNombre = new Label();
            lblAgregaroModificar = new Label();
            txtUsername = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            dgvRolesDisponibles = new DataGridView();
            label4 = new Label();
            dgvRolesAsignados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRolesDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRolesAsignados).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(171, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 26);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(34, 218);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(83, 26);
            btnAceptar.TabIndex = 36;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 34;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(17, 166);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(54, 15);
            lblDestino.TabIndex = 33;
            lblDestino.Text = "Apellido:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 32;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 124);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre:";
            // 
            // lblAgregaroModificar
            // 
            lblAgregaroModificar.AutoSize = true;
            lblAgregaroModificar.Location = new Point(47, 9);
            lblAgregaroModificar.Name = "lblAgregaroModificar";
            lblAgregaroModificar.Size = new Size(161, 15);
            lblAgregaroModificar.TabIndex = 28;
            lblAgregaroModificar.Text = "Agregar o Modificar Usuarios";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(90, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(118, 23);
            txtUsername.TabIndex = 38;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(90, 168);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(118, 23);
            txtApellido.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 40;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 41;
            label2.Text = "Email:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(385, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 51;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(681, 217);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(668, 21);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 46;
            label3.Text = "Roles Disponibles:";
            // 
            // dgvRolesDisponibles
            // 
            dgvRolesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolesDisponibles.Location = new Point(590, 39);
            dgvRolesDisponibles.Name = "dgvRolesDisponibles";
            dgvRolesDisponibles.RowTemplate.Height = 25;
            dgvRolesDisponibles.Size = new Size(244, 172);
            dgvRolesDisponibles.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 21);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 53;
            label4.Text = "Roles Asignados:";
            // 
            // dgvRolesAsignados
            // 
            dgvRolesAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolesAsignados.Location = new Point(286, 39);
            dgvRolesAsignados.Name = "dgvRolesAsignados";
            dgvRolesAsignados.RowTemplate.Height = 25;
            dgvRolesAsignados.Size = new Size(244, 172);
            dgvRolesAsignados.TabIndex = 52;
            // 
            // FormUsuariosAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 272);
            Controls.Add(label4);
            Controls.Add(dgvRolesAsignados);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(dgvRolesDisponibles);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtUsername);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(lblDestino);
            Controls.Add(txtEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblAgregaroModificar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsuariosAM";
            Text = "FormTicketsAM";
            Load += FormUsuariosAM_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRolesDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRolesAsignados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblDestino;
        private TextBox txtEmail;
        private Label lblNombre;
        private Label lblAgregaroModificar;
        private TextBox txtUsername;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Button btnGuardarySALIT;
        private Button btnEliminar;
        private Button btnAgregar;
        private CheckBox cbHabilitada;
        private Label label5;
        private Label label3;
        private ComboBox cmbRoles;
        private DataGridView dgvRolesDisponibles;
        private Label label4;
        private DataGridView dgvRolesAsignados;
    }
}