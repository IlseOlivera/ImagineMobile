using Proyecto_BD.Models;
using Proyecto_BD.Vistas;
using System.Data;

namespace Proyecto_BD.Components
{
    public partial class Ver_ventas : UserControl
    {
        private List<Venta> ventas = new List<Venta>();

        private void generarHeadesGrid()
        {
            DataGridViewTextBoxColumn[] columns = {
            new DataGridViewTextBoxColumn(){Name = "Id_venta", HeaderText="No de venta", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "Fecha_venta", HeaderText="Fecha de venta", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "Hora_Venta", HeaderText="Hora de venta", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "Total_Venta", HeaderText="Total Venta", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "modelo", HeaderText="Modelo del producto", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "precio", HeaderText="Precio", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "color", HeaderText="Color", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "material", HeaderText="Material", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "tamaño", HeaderText="Tamaño", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "especificacion", HeaderText="Caracteristicas especificas", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "comunicacion", HeaderText="Metodos de comunicacion", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "accesorios", HeaderText="Accesorios", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "tecnologias", HeaderText="Tecnologias", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "compatibilidad", HeaderText="Compatibilidad", ReadOnly = true},
            };
            dataGrid_vista_datos.Columns.AddRange(columns);
        }
        private void insertarFilas(Productos producto, Venta venta)
        {
            dataGrid_vista_datos.Rows.Add(
                venta.Id_venta,
                venta.Fecha_venta.ToString("dd/MM/yyyy"),
                venta.Hora_Venta.ToString(),
                venta.Total_Venta,
                producto.modelo,
                producto.precio,
                producto.campos_Extra.color ?? "No hay informacion",
                producto.campos_Extra.material ?? "No hay informacion",
                producto.campos_Extra.tamaño ?? "No hay informacion",
                producto.campos_Extra.especificacion?.caracteristica ?? "No hay informacion",
                producto.campos_Extra.comunicacion?.caracteristica ?? "No hay informacion",
                producto.campos_Extra.accesorios?.caracteristica ?? "No hay informacion",
                producto.campos_Extra.tecnologias?.caracteristica ?? "No hay informacion",
                producto.campos_Extra.compatibilidad?.caracteristica ?? "No hay informacion"
                );
        }
        private TableLayoutPanel Generar_vista(Venta venta)
        {
            TableLayoutPanel panel = new TableLayoutPanel()
            {
                Size = new Size(843, 55),
                MinimumSize = new Size(843, 55),
                ColumnCount = 3,
                RowCount = 1,
                Margin = new Padding(0, 0, 0, 10),
                Anchor = AnchorStyles.None
            };
            Label No_venta = new Label()
            {
                Dock = DockStyle.Fill,
                Text = venta.Id_venta,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label fecha_venta = new Label()
            {
                Dock = DockStyle.Fill,
                Text = $"{venta.Fecha_venta.ToString("dd/MM/yyyy")} {venta.Hora_Venta}",
                TextAlign = ContentAlignment.MiddleCenter
            };
            Button detalles = new Button() { Text = "Ver detalles" };
            detalles.Click += btn_ver_detalles_Click;
            panel.Controls.Add(No_venta, 0, 0);
            panel.Controls.Add(fecha_venta, 1, 0);
            panel.Controls.Add(detalles, 2, 0);
            return panel;
        }

        public Ver_ventas()
        {
            InitializeComponent();
            ventas = DBContext.Return_ventasAll();
            foreach (Venta venta in ventas)
                panel_flow_muestra.Controls.Add(Generar_vista(venta));
        }

        private void btn_generar_venta_Click(object sender, EventArgs e)
        {
            Vista_agregar_venta vista = new Vista_agregar_venta();
            vista.ShowDialog(); 
            dataGrid_vista_datos.Rows.Clear();
            dataGrid_vista_datos.Columns.Clear();
            panel_flow_muestra.Controls.Clear();
            ventas = DBContext.Return_ventasAll();
            foreach (Venta venta in ventas)
                panel_flow_muestra.Controls.Add(Generar_vista(venta));
        }
        private void btn_ver_detalles_Click(object sender, EventArgs e)
        {
            dataGrid_vista_datos.Rows.Clear();
            dataGrid_vista_datos.Columns.Clear();
            TableLayoutPanel panel = (TableLayoutPanel)((Button)sender).Parent;
            string id = panel.Controls[0].Text;
            generarHeadesGrid();
            Venta venta = ventas.Where(v => v.Id_venta == id).First();
            List<Productos> filtro = DBContext.Return_producto_from_venta(id);
            foreach (Productos v in filtro)
                insertarFilas(v, venta);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            dataGrid_vista_datos.Rows.Clear();
            dataGrid_vista_datos.Columns.Clear();
        }
    }
}
