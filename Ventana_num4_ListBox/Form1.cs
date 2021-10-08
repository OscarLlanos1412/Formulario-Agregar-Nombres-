using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_num4_ListBox
{
    public partial class Form1 : Form
    {
        List<string> nombres = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtbox_nombre.Text;

            nombres.Add(nombre);
            list_nombres.DataSource = null;//Se actualiza la lista donde se muestra los nombres
            list_nombres.DataSource = nombres;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            nombres.Remove(txtbox_nombre.Text);

            list_nombres.DataSource = null;
            list_nombres.DataSource = nombres;

        }

        private void btn_edi_nom_Click(object sender, EventArgs e)
        {
            var indice = nombres.IndexOf(textbox_cambio.Text);
            nombres.RemoveAt(indice);
            nombres.Insert(indice, txtbox_nombre.Text);

            list_nombres.DataSource = null;
            list_nombres.DataSource = nombres;
        }
    }
}
