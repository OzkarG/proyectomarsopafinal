using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CsFormsFlashcards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //papas con queso chedard
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar frm = new Agregar();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e) //boton de empezar
        {
            panel1.Visible = true;
            label2.Visible = true;

            texto testo = new texto();
            Imagen iami = new Imagen();
            testo.obtenerdatos();
            iami.obtenerdatos();

            //MessageBox.Show(iami.CargarImagen());

            label3.Text = testo.mostrarpregunta();
            label4.Text = testo.mostrarrespeusta();

            try
            {
                pictureBox1.Image = Image.FromFile(iami.CargarImagen());
            }
            catch (Exception z)
            { 
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label2.Visible = false;

            label4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label2.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label4.Visible = false;


            texto testo = new texto();
            Imagen iami = new Imagen();
            testo.obtenerdatos();
            iami.obtenerdatos();

            label3.Text = testo.mostrarpregunta();
            label4.Text = testo.mostrarrespeusta();

            try
            {
                pictureBox1.Image = Image.FromFile(iami.CargarImagen());
            }
            catch (Exception zz)
            {
            }

        }
    }
}
