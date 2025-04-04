namespace Busquedas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            groupBox2 = new GroupBox();
            txtClave = new TextBox();
            txtNombreCompleto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvDatos = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(365, 41);
            label1.TabIndex = 0;
            label1.Text = "Algoritmos de búsqueda";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDatos);
            groupBox1.Location = new Point(17, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 466);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(658, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Inserta la cédula a buscar...";
            txtBuscar.Size = new Size(256, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(920, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 28);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNombreCompleto);
            groupBox2.Controls.Add(txtClave);
            groupBox2.Location = new Point(668, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 465);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(16, 75);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(268, 27);
            txtClave.TabIndex = 0;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(16, 176);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(268, 27);
            txtNombreCompleto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Cédula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 143);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre Completo";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Green;
            btnAgregar.Location = new Point(10, 287);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(280, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.OrangeRed;
            btnActualizar.Location = new Point(10, 348);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(280, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(10, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(280, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDatos.BackgroundColor = SystemColors.Control;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(10, 41);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(609, 421);
            dgvDatos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(994, 726);
            Controls.Add(groupBox2);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private GroupBox groupBox2;
        private TextBox txtNombreCompleto;
        private TextBox txtClave;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private DataGridView dgvDatos;
    }
}
