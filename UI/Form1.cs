using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TareaBusiness TareaBusiness = new TareaBusiness();
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                TareaEntity nuevaTarea = new TareaEntity
                {
                    Descripcion = txtDescripcion.Text,
                    FechaTarea = dtpFecha.Value
                };
                TareaBusiness.crearNuevaTarea(nuevaTarea);
                actualizarDgv();
                MessageBox.Show("Se creo la tarea");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizarDgv()
        {
            try
            {
                dgvTareas.DataSource = null;
                dgvTareas.DataSource = TareaBusiness.GetAll();
            }
            catch
            {
                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                TareaBusiness.modificarTarea(Convert.ToInt32(txtIdModificar.Text), txtNuevaDescripcion.Text, dtpNuevaFecha.Value);
                actualizarDgv();
                MessageBox.Show("Se modificó la tarea");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TareaBusiness.eliminarTarea(Convert.ToInt32(txtIdModificar.Text));
                actualizarDgv();
                MessageBox.Show("Se eliminó la tarea");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
