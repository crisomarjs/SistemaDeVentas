using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.ViewModels;
using SVRepository.Entities;
using SVServices.Implementation;
using SVServices.Interfaces;

namespace SVPresentation.Formularios
{
    public partial class frmUsuario : Form
    {
        private readonly IRolService _rolService;
        private readonly IUsuarioService _usuarioService;
        private readonly ICorreoService _correoService;
        public frmUsuario(IUsuarioService usuarioService, IRolService rolService, ICorreoService correoService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _correoService = correoService;
            _rolService = rolService;
        }

        public void MostrarTab(string tabName)
        {
            var TabMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };

            foreach (var tab in TabMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }

        private async Task MostrarUsuarios(string buscar = "")
        {
            var listaUsuario = await _usuarioService.Lista(buscar);
            var listaVM = listaUsuario.Select(item => new UsuarioVM
            {
                IdUsuario = item.IdUsuario,
                IdRol = item.RefRol.IdRol,
                Rol = item.RefRol.Nombre,
                NombreCompleto = item.NombreCompleto,
                Correo = item.Correo,
                NombreUsuario = item.NombreUsuario,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvUsuarios.DataSource = listaVM;
            dgvUsuarios.Columns["IdUsuario"].Visible = false;
            dgvUsuarios.Columns["IdRol"].Visible = false;
            dgvUsuarios.Columns["Activo"].Visible = false;
        }

        private async void frmUsuario_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvUsuarios.ImplementarConfiguracion("Editar");
            await MostrarUsuarios();
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            OpcionCombo[] itemsHabilitados = new OpcionCombo[] {
                new OpcionCombo{Texto="Si", Valor=1},
                new OpcionCombo{Texto="No", Valor=0},
            };

            var listaRol = await _rolService.Lista();
            var items = listaRol.Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdRol }).ToArray();
            cbbRolNuevo.InsertarItems(items);
            cbbRolEditar.InsertarItems(items);
            cbbHabilitado.InsertarItems(itemsHabilitados);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarUsuarios(txbBuscar.Text);
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            cbbRolNuevo.SelectedIndex = 0;
            txbNombreCompletoNuevo.Text = string.Empty;
            txbCorreoNuevo.Text = string.Empty;
            txbNombreUsuarioNuevo.Text = string.Empty;
            MostrarTab(tabNuevo.Name);
            cbbRolNuevo.Select();
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbNombreCompletoNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Nombre Completo");
                return;
            }

            if (txbCorreoNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Correo");
                return;
            }

            if (txbNombreUsuarioNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Nombre del Usuario");
                return;
            }

            var claveGenerada = Util.GenerateCode();
            var claveSha256 = Util.ConvertToSha256(claveGenerada);

            var objeto = new Usuario
            {
                RefRol = new Rol { IdRol = ((OpcionCombo)cbbRolNuevo.SelectedItem!).Valor },
                NombreCompleto = txbNombreCompletoNuevo.Text.Trim(),
                Correo = txbCorreoNuevo.Text.Trim(),
                NombreUsuario = txbNombreUsuarioNuevo.Text.Trim(),
                Clave = claveSha256
            };

            var resp = await _usuarioService.Crear(objeto);

            if (resp != "")
            {
                MessageBox.Show(resp);
            }
            else
            {
                var mensaje = $"Bienvenido<br>Su contraseña temporal es: {claveGenerada}</br>";
                await _correoService.Enviar(objeto.Correo, "Cuenta Creada", mensaje);

                await MostrarUsuarios();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var usuarioSeleccionado = (UsuarioVM)dgvUsuarios.CurrentRow.DataBoundItem;
                cbbRolEditar.EstablecerValor(usuarioSeleccionado.IdRol);
                txbNombreCompletoEditar.Text = usuarioSeleccionado.NombreCompleto;
                txbCorreoEditar.Text = usuarioSeleccionado.Correo;
                txbNombreUsuarioEditar.Text = usuarioSeleccionado.NombreUsuario;
                cbbHabilitado.EstablecerValor(usuarioSeleccionado.Activo);

                MostrarTab(tabEditar.Name);
                cbbRolEditar.Select();
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txbNombreCompletoEditar.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Nombre Completo");
                return;
            }

            if (txbCorreoEditar.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Correo");
                return;
            }

            if (txbNombreUsuarioEditar.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Nombre del Usuario");
                return;
            }

            var usuarioSeleccionado = (UsuarioVM)dgvUsuarios.CurrentRow.DataBoundItem;

            var objeto = new Usuario
            {
                IdUsuario = usuarioSeleccionado.IdUsuario,
                RefRol = new Rol { IdRol = ((OpcionCombo)cbbRolEditar.SelectedItem!).Valor },
                NombreCompleto = txbNombreCompletoEditar.Text.Trim(),
                Correo = txbCorreoEditar.Text.Trim(),
                NombreUsuario = txbNombreUsuarioEditar.Text.Trim(),
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
            };

            var resp = await _usuarioService.Editar(objeto);

            if (resp != "")
            {
                MessageBox.Show(resp);
            }
            else
            {
                await MostrarUsuarios();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
