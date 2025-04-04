using Busquedas.Clases;

namespace Busquedas
{
    public partial class Form1 : Form
    {
        CD_Datos cd_Datos = new CD_Datos();
        private string? idDato = null;
        private bool EsEditar = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            LimpiarCampos();
        }
        private void MostrarDatos()
        {
            dgvDatos.DataSource = cd_Datos.MostrarDatos(txtBuscar.Text);
            dgvDatos.Columns[0].Visible = false;
            txtClave.Enabled = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                string cedula = txtClave.Text;
                string nombreComp = txtNombreCompleto.Text;
                if (EsEditar == false)
                {
                    try
                    {
                        cd_Datos.InsertarDato(cedula, nombreComp);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarCampos();
                        MostrarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
                if (EsEditar == true)
                {
                    try
                    {
                        if (cedula == null || cedula == "")
                        {
                            MessageBox.Show("No se puede editar el registro");
                            return;
                        }
                        cd_Datos.EditarDato(cedula, nombreComp);
                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCampos();
                        MostrarDatos();
                        EsEditar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos!");
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtClave.Text = dgvDatos.CurrentRow.Cells["Clave"].Value.ToString();
                txtNombreCompleto.Text = dgvDatos.CurrentRow.Cells["Nombre Completo"].Value.ToString();
                txtClave.Enabled = false;
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idDato = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();

                    cd_Datos.EliminarDato(Convert.ToInt32(idDato));
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarDatos();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private bool EsValido()
        {
            bool clave = txtClave.Text != "";
            bool nombreC = txtNombreCompleto.Text != "";

            if (clave && nombreC)
                return true;
            else
                return false;
        }
        private void LimpiarCampos()
        {
            txtClave.Clear();
            txtNombreCompleto.Clear();
            txtBuscar.Clear();

        }
    }
}
