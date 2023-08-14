using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using intermodaTest2.CAPADATOS;
namespace intermodaTest2.CAPAPRESENTACION
{
    public partial class productoDetalle : Form
    {
        public productoDetalle()
        {
            InitializeComponent();
            crearFormatoModal();
            ListarUnidadMedida();
            listarTipo();
            tCodigo.Focus();
        }
        public bool hizoClicEnAceptar = true;
        public void crearFormatoModal()
        {
            //Dar formato a ventana modal
            Text = "Producto Detalle";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            darEstilo();
        }

        public void darEstiloBotones()
        {

        }
        public void darEstilo()
        {
            //Comboboxes            
            cTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;

            //Botones
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Coral;
            button1.ForeColor = Color.White;
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
            //button1.Image = Image.FromFile("path/to/image.png");
            //button1.ImageAlign = ContentAlignment.MiddleLeft;
            //button1.Padding = new Padding(10);
        }
        private void productoDetalle_Load(object sender, EventArgs e)
        {
            tNombre.Focus();
        }

        public void listarTipo() //Refill combobox tipo de producto
        {
            //productoDetalle pd = new productoDetalle();
            clsProductos objetoProducto = new clsProductos();
            cTipo.DataSource = objetoProducto.ListarTiposProductos();
            cTipo.DisplayMember = "Nombre";
            cTipo.ValueMember = "Id";
        }

        public void ListarUnidadMedida() //Listar combobox sobre unidad de medida
        {
            //productoDetalle pd = new productoDetalle();
            clsProductos objetoProducto = new clsProductos();
            cUnidadMedida.DataSource = objetoProducto.ListarUnidadMedida();
            cUnidadMedida.DisplayMember = "Nombre";
            cUnidadMedida.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tCodigo.Text) || !string.IsNullOrWhiteSpace(tNombre.Text))
            {
                hizoClicEnAceptar = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hizoClicEnAceptar = false;
            this.Close();
        }
    }
}
