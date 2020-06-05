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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                button2.Visible = true;
                pictureBox1.Visible = true;
            }
            else 
            {
                button2.Visible = false;
                pictureBox1.Visible = false;
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        string lugar = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg)|*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                //textBox1.Text = open.FileName;
                lugar = open.FileName;              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                string ruta = @"C:\Users\oscar\Desktop\Imagen\";
                string rutaynombre = ruta + textBox1.Text + ".jpg";
                FlashCardsArchivosImagen img = new FlashCardsArchivosImagen(lugar, rutaynombre);

                FlashCardsArchivos grd = new FlashCardsArchivos();
                grd.Guardartexto(@"C:\Users\oscar\Desktop\Puntaje\", textBox1.Text, textBox2.Text);

            }
            else
            {
                FlashCardsArchivos grd = new FlashCardsArchivos();
                grd.Guardartexto(@"C:\Users\oscar\Desktop\Puntaje\", textBox1.Text, textBox2.Text);

            }
         
 
        }
    }
}
