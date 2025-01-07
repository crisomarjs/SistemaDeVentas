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
using SVServices.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SVPresentation.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly IMedidaService _medidaService;
        private readonly ICategoriaService _categoriaService;
        public frmCategoria(IMedidaService medidaService, ICategoriaService categoriaService)
        {
            InitializeComponent();
            _medidaService = medidaService;
            _categoriaService = categoriaService;
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

        private async Task MostrarCategorias(string buscar = "")
        {
            var listaCategorias = await _categoriaService.Lista(buscar);
            var listaVM = listaCategorias.Select(item => new CategoriaViewModel
            {
                IdCategoria = item.IdCategoria,
                Nombre = item.Nombre,
                IdMedida = item.RefMedida.IdMedida,
                Medida = item.RefMedida.Nombre,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvCategorias.DataSource = listaVM;
            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["IdMedida"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvCategorias.ImplementarConfiguracion("Editar");
            await MostrarCategorias();
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            OpcionCombo[] itemsHabilitados = new OpcionCombo[] {
                new OpcionCombo{Texto="Si", Valor=1},
                new OpcionCombo{Texto="No", Valor=0},
            };

            var listaMedidas = await _medidaService.Lista();
            var items = listaMedidas.Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdMedida }).ToArray();
            cbbMedidaNuevo.InsertarItems(items);
            cbbMedidaEditar.InsertarItems(items);
            cbbHabilitado.InsertarItems(itemsHabilitados);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarCategorias(txbBuscar.Text);
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            txbNombreNuevo.Text = "";
            cbbMedidaNuevo.SelectedIndex = 0;
            txbNombreNuevo.Select();

            MostrarTab(tabNuevo.Name);
        }
        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Nombre");
                return;
            }

            var item = (OpcionCombo)cbbMedidaNuevo.SelectedItem!;
            var objeto = new Categoria
            {
                Nombre = txbNombreNuevo.Text.Trim(),
                RefMedida = new Medida { IdMedida = item.Valor }
            };

            var respuesta = await _categoriaService.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategorias();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var categoriaSeleccionada = (CategoriaViewModel)dgvCategorias.CurrentRow.DataBoundItem;
                txbNombreEditar.Text = categoriaSeleccionada.Nombre.ToString();

                cbbMedidaEditar.EstablecerValor(categoriaSeleccionada.IdMedida);
                cbbHabilitado.EstablecerValor(categoriaSeleccionada.Activo);

                MostrarTab(tabEditar.Name);
                txbNombreEditar.Select();
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private  async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txbNombreEditar.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el Nombre");
                return;
            }

            var categoriaSeleccionada = (CategoriaViewModel)dgvCategorias.CurrentRow.DataBoundItem;
            var objeto = new Categoria
            {
                IdCategoria = categoriaSeleccionada.IdCategoria,
                Nombre = txbNombreEditar.Text.Trim(),
                RefMedida = new Medida { IdMedida = ((OpcionCombo)cbbMedidaEditar.SelectedItem!).Valor },
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor,
            };

            var respuesta = await _categoriaService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategorias();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
