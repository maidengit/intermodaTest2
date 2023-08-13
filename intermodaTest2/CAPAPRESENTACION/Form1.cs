using intermodaTest2.CAPADATOS;
using intermodaTest2.CAPAPRESENTACION;
namespace intermodaTest2
{
    public partial class Form1 : Form
    {
        clsProductos p = new clsProductos();
        bool estaEditando = false;
        int idProducto;
        int estado;
        public Form1()
        {
            InitializeComponent();
            darFormatoDataGridView();
        }
        
        public void darFormatoDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            //dataGridView1.Columns["id"].SortMode = DataGridViewColumnSortMode.NotSortable; //no permite ordenar por ID
            dataGridView1.MultiSelect = false; //No seleccionar mas de 1 celda a la vez
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false; //Desaparece la barra izquierda con punterp
            dataGridView1.AllowUserToResizeRows = false; //Evita que se redimensionen las filasdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Esto hará que las columnas se ajusten automáticamente para llenar el ancho disponible.
            
            //##Ahora un poco de estetica segun una IA
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.Azure;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.Font = new Font("Arial", 10, FontStyle.Regular);

            //Mejoramos el encabezado segun IA
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listarProductos(); //Rellenar Datagridview
        }

        public void listarProductos()
        {
            clsProductos objetoProducto = new clsProductos();
            dataGridView1.DataSource = objetoProducto.listarProductos();
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            productoDetalle pd = new productoDetalle();
            clsProductos objetoProducto = new clsProductos();
            estado = 0;
            if (pd.checkboxEstado.Checked) estado = 1;
            //ListarUnidadMedida();
            pd.ShowDialog();
            if (pd.hizoClicEnAceptar)
            {
                objetoProducto.insertarProducto(
                    pd.tCodigo.Text,
                    pd.tNombre.Text,
                    Convert.ToInt32(pd.cTipo.SelectedValue),
                    Convert.ToInt32(pd.cUnidadMedida.SelectedValue),
                    Convert.ToInt32(estado)
                );
            }

            //MessageBox.Show("Listo");
            listarProductos(); // Actualizar el datagridview
        }

        private void btRenovar_Click(object sender, EventArgs e)
        {
            productoDetalle pd = new productoDetalle();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (pd.checkboxEstado.Checked) estado = 1;
                if (!pd.checkboxEstado.Checked) estado = 0;
                p.renovarProducto(idProducto);
                listarProductos();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    p.eliminarProducto(idProducto);
                    listarProductos();
                }
            }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //Boton editar

            productoDetalle pd = new productoDetalle();
            estaEditando = true;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //Rellenar campos
                pd.tCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                pd.tNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                pd.cTipo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pd.cUnidadMedida.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value) == 1)
                {
                    pd.checkboxEstado.Checked = true;
                }
                else
                {
                    pd.checkboxEstado.Checked = false;
                }

                //UPDATE
                clsProductos objetoProducto = new clsProductos();
                estado = 0;
                if (pd.checkboxEstado.Checked) estado = 1;
                pd.ShowDialog();


                idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    objetoProducto.editarProducto(
                        Convert.ToInt32(idProducto),
                        pd.tCodigo.Text,
                        pd.tNombre.Text,
                        Convert.ToInt32(pd.cTipo.SelectedValue),
                        Convert.ToInt32(pd.cUnidadMedida.SelectedValue),
                        Convert.ToInt32(estado)
                    );
                 }
            }
        }
    }