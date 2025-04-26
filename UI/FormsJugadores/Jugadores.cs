using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2doParcial_Aranza.UI.FormsJugadores
{
    public partial class Jugadores : Form
    {
        private readonly JugadorService _jugadorService;
        public Jugadores()
        {
            InitializeComponent();
            _jugadorService = new JugadorService(new DatabaseManager()); // Aquí inicializas el servicio
        }
        private void Jugadores_Load(object sender, EventArgs e)
        {

        }

        private void btnVerJugador_Click(object sender, EventArgs e)
        {
            try
            {
                string IdJugador = txtID.Text.Trim();


                if (string.IsNullOrEmpty(IdJugador))
                {
                    MessageBox.Show("Ingrese el ID del jugador a buscar.", "ID Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!int.TryParse(IdJugador, out int id))
                {
                    MessageBox.Show("El ID debe ser un número entero válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var jugador = _jugadorService.ObtenerPorId(id);

                if (jugador == null)
                {
                    MessageBox.Show("No se encontró un jugador con ese ID.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Limpiar y mostrar
                datosJugadores.Columns.Clear();
                datosJugadores.Rows.Clear();

                datosJugadores.Columns.Add("Id", "ID");
                datosJugadores.Columns.Add("Nombre", "Nombre");
                datosJugadores.Columns.Add("Nivel", "Nivel");
                datosJugadores.Columns.Add("FechaCreacion", "Fecha de Creación");

                datosJugadores.Rows.Add(
                    jugador.Id,
                    jugador.Nombre,
                    jugador.Nivel,
                    jugador.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss")
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el jugador:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string nivelTexto = txtNivel.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(nivelTexto))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nivelTexto, out int nivel))
            {
                MessageBox.Show("El nivel debe ser un número entero.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoJugador = new Jugador
            {
                Nombre = nombre,
                Nivel = nivel
            };
            try
            {
                _jugadorService.Crear(nuevoJugador);
                MessageBox.Show("¡Jugador creado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                txtNivel.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al crear el jugador:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerJugadores_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Llama al método del servicio que obtiene todos los jugadores
                var jugadores = _jugadorService.ObtenerTodos();

                // Limpia columnas y filas anteriores
                datosJugadores.Columns.Clear();
                datosJugadores.Rows.Clear();

                // Agrega columnas
                datosJugadores.Columns.Add("Id", "ID");
                datosJugadores.Columns.Add("Nombre", "Nombre");
                datosJugadores.Columns.Add("Nivel", "Nivel");
                datosJugadores.Columns.Add("FechaCreacion", "Fecha de Creación");


                foreach (var jugador in jugadores)
                {
                    datosJugadores.Rows.Add(
                        jugador.Id,
                        jugador.Nombre,
                        jugador.Nivel,
                        jugador.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los jugadores:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                string IdJugador = txtID.Text.Trim();


                if (string.IsNullOrEmpty(IdJugador))
                {
                    MessageBox.Show("Para eliminar un Jugador primero ingresa el id del jugador, buscalo y de estar seguro ya puedes eliminarlo.", "ID Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!int.TryParse(IdJugador, out int id))
                {
                    MessageBox.Show("El ID debe ser un número entero válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _jugadorService.Eliminar(id);

                MessageBox.Show("Jugador eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtID.Clear();
                datosJugadores.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el jugador:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string nivelTexto = txtNivel.Text.Trim();
            string idJugador = txtID.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(nivelTexto) || string.IsNullOrEmpty(idJugador))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nivelTexto, out int nivel))
            {
                MessageBox.Show("El nivel debe ser un número entero.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idJugador, out int id))
            {
                MessageBox.Show("El Id debe ser un número entero.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoJugador = new Jugador
            {
                Nombre = nombre,
                Nivel = nivel,
                Id = id
            };
            try
            {
                _jugadorService.Actualizar(nuevoJugador);
                MessageBox.Show("¡Jugador actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                txtNivel.Clear();
                txtID.Clear();
                datosJugadores.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al actualizar el jugador:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
