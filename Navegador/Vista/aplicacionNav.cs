using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorVista
{
    public partial class aplicacionNav : Form
    {
        public aplicacionNav()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
// NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3,textBox4 , textBox5, textBox6};
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_contrato");
        }
    }
}
