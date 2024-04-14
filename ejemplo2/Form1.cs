using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            elementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBOFavorito.Items.Add("rojo");
            CBOFavorito.Items.Add("verde");
            CBOFavorito.Items.Add("azul");
        }

        private void BTNVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre= txtNombre.Text;
            DateTime fecha = FechaNAcimiento.Value;
            //operador ternario
            string chocolate = CKBChocolate.Checked == true ? "Le gusta el chocolate" : "no le gusta el chocolate";
            string Tipo;
            if(RBTWizzard.Checked == true) {
                Tipo = "Wizzard";
            }
            else if (RBTMugle.Checked == true)
            {
                Tipo = "Muggle";
            }
            else { Tipo = "SQUIBS"; }

            string ColorFavorito= CBOFavorito.SelectedItem.ToString();

            string numberFavorite = NumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + Tipo + " , Su color es " + ColorFavorito + "numero favorito es : " + numberFavorite;
            MessageBox.Show("Nommbre: " + nombre + " Fecha nacimiento: " + fecha + " "+mensaje);


        }
    }
}
