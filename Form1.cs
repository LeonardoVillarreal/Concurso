using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetroQuiz
{
    public partial class Form1 : Form
    {
        private string ruta1 = "";
        private string ruta2 = "";
        public Concurso nuevoConcurso;
        public Form3 lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            nuevoConcurso = new Concurso(lblEq1.Text, lblEq2.Text,ruta1, ruta2);
            nuevoConcurso.Visible = true;
            nuevoConcurso.Enabled = true;
        }

        private void btnCargarEq1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + "/Recursos/Equipos";
            openFileDialog1.Title = "Select a team";

            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                if (openFileDialog1.SafeFileName.Split('.').First()!=lblEq2.Text)
                {
                    lblEq1.Text = openFileDialog1.SafeFileName.Split('.').First();
                    ruta1 = openFileDialog1.FileName;
                    imagenEq1.ImageLocation = ruta1;
                    
                }
                else
                {
                    MessageBox.Show("You must pick different teams", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            
        }

        private void btnCargarEq2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + "/Recursos/Equipos";
            openFileDialog1.Title = "Select a team";
           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.SafeFileName.Split('.').First()!=lblEq1.Text)
                {
                    lblEq2.Text = openFileDialog1.SafeFileName.Split('.').First();
                    ruta2 = openFileDialog1.FileName;
                    imagenEq2.ImageLocation = ruta2;
                }
                else
                {
                    MessageBox.Show("You must pick different teams", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            lista = new Form3();
            lista.Visible = true;
            lista.Enabled = true;
        }
    }
}
