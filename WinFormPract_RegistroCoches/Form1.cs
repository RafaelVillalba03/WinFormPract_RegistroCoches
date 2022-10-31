using System.Data;
using System.Diagnostics.Contracts;

namespace WinFormPract_RegistroCoches
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        #region enumerado
        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        #region eventos
        private void Inicio_Load(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();
        }

        /// <summary>
        /// Evento KeyPress para controlar que no se puedan escribir caracteres en el campo txt de coste.
        /// </summary>
        /// 
        private void txtCoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && Convert.ToInt32(e.KeyChar)!=0x007F)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento del bot�n a�adir.
        /// </summary>

      
        private void btnA�adir_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento del bot�n eliminar.
        /// </summary>

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea eliminar el registro?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Coche c = ObtenerInformacion();
                correcto = Repositorio.EliminarCoche(c);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }

        }

        /// <summary>
        /// Evento del bot�n Modificar.
        /// </summary>

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento click del bot�n guardar.
        /// </summary>

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la informaci�n
                Coche c = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repositorio.CrearCoche(c);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repositorio.ModificarCoche(c);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Nombre y Tel�fono son obligatorios.");
            }

        }

        /// <summary>
        /// Evento click del bot�n Cancelar.
        /// </summary>

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea salir de la edici�n?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (grdRegistro.SelectedRows.Count == 1)
                {
                    // Recargamos su informaci�n en el formulario
                    CargarInfoFilaSeleccionadaFormulario(grdRegistro.SelectedRows[0]);
                }
            }
        }

        /// <summary>
        /// Evento click de la celda.
        /// Cuando se hace click en una celda se selecciona la fila entera.
        /// </summary>

        private void grdRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdRegistro.Rows[e.RowIndex].Selected = true;
        }

        /// <summary>
        /// Evento para cuando una fila cambia de estado en el grid.
        /// </summary>

        private void grdRegistro_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operaci�n que no sea que ha cambiado la selecci�n de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region metodos

        public void ModoPantallaLectura()
        {
            txtMarca.Text = "";
            dtFecha.Value = DateTime.Now;
            txtCoste.Text = "";
            txtId.Text = "";

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnA�adir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            txtMarca.Enabled = false;
            dtFecha.Enabled = false;
            txtId.Enabled = false;
            txtCoste.Enabled = false;

            grdRegistro.Enabled = true;
        }

        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerCoches();
            grdRegistro.DataSource = ds.Tables[0];

            // Tama�os columnas
            grdRegistro.Columns["id"].Width = 40;
            grdRegistro.Columns["Marca"].Width = 150;
            grdRegistro.Columns["Fabricacion"].Width = 150;
            grdRegistro.Columns["Coste"].Width = 120;

            // Renombrado columnas
            grdRegistro.Columns["Fabricacion"].HeaderText = "Fecha de Fabricaci�n";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (grdRegistro.Rows.Count > 0)
            {
                grdRegistro.Rows[0].Selected = true;
            }
        }

        public void ModoPantallaEdicion()
        {
            // Limpiamos s�lo si es modo creaci�n, si es modo edici�n dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                txtMarca.Text = "";
                dtFecha.Value = DateTime.Now;
                txtCoste.Text = "";
                txtId.Text = "";

            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtMarca.Enabled = true;
            dtFecha.Enabled = true;
            txtCoste.Enabled = true;
            txtId.Enabled = false;

            btnA�adir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            grdRegistro.Enabled = false;
        }

        public Coche ObtenerInformacion()
        {
            Coche c = new Coche();

            c.marca = txtMarca.Text;
            c.coste = txtCoste.Text;
            c.fechaFabricacion = dtFecha.Value;

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                c.Id = Convert.ToInt32(txtId.Text);
            }

            return c;
        }

        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtMarca.Text) || String.IsNullOrEmpty(txtCoste.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["id"].Value.ToString();
            txtMarca.Text = filaSeleccionada.Cells["Marca"].Value.ToString();
            dtFecha.Value = (DateTime)filaSeleccionada.Cells["Fabricacion"].Value;
            txtCoste.Text = filaSeleccionada.Cells["Coste"].Value.ToString();
        }


        #endregion

        
    }
}