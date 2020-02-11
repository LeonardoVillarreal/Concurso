using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Media;
using System.Collections;
using System.IO;

namespace PetroQuiz
{
    public partial class Concurso : Form
    {
        private int tiempo = 30;
        public int scoreEq1 = 0;
        public int scoreEq2 = 0;
        private int contadorRonda = 0;
        private string value;
        private string eq1 = "";
        private string eq2 = "";
        private ArrayList preguntas = new ArrayList();
        private string lineaPreg = "";
        private ArrayList respuestas = new ArrayList();
        private string lineaResp = "";
        private int rdm = 0;
        private Random ind = new Random();
        private ArrayList equipos = new ArrayList();
        private string lineaScore = "";
        private ArrayList bonus = new ArrayList();
        private string lineaBonus = "";
        private ArrayList bonusResp = new ArrayList();
        private string lineaBonusResp = "";
        private Boolean bon = false;


        public Concurso()
        {
            InitializeComponent();
        }

        public Concurso(string eqA, string eqB, string imag1, string imag2)
        {
            InitializeComponent();
            eq1 = eqA;
            eq2 = eqB;
            imagenEq1.ImageLocation = imag1;
            imagenEq2.ImageLocation = imag2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            tiempo -= 1;
            lblTiempo.Text = "00:" + tiempo.ToString();
            if (tiempo < 10)
            {
                lblTiempo.Text = "00:0" + tiempo.ToString();
            }
            if (lblTiempo.Text == "00:00")
            {
                timer1.Stop();
                if (bon)
                {
                    MessageBox.Show("Time ran out!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnswer.Visible = true;
                }
                else
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = Environment.CurrentDirectory + "/Recursos/Alerta.wav";
                    player.Play();
                    MessageBox.Show("Time ran out!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAnswer.Visible = true;
                }
                
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            rdm = ind.Next(preguntas.Count);
            contadorRonda++;
            btnEmpezar.Text = "Round "+contadorRonda.ToString();

            timer1.Stop();
            tiempo = 30;
            lblTiempo.Text = "00:" + tiempo.ToString();
            txtPreguntas.Text = preguntas[rdm].ToString();
            preguntas.RemoveAt(rdm);

            txtAnswer.Visible = false;
            txtAnswer.Text = respuestas[rdm].ToString();
            respuestas.RemoveAt(rdm);

            bon = false;

            ocultarBotones(btnCorrectoEq1, btnIncorrectoEq1);
            ocultarBotones(btnCorrectoEq2, btnIncorrectoEq2);
            btnEmpezar.Visible = true;
        }

        private void btnEq1_Click(object sender, EventArgs e)
        {
            mostrarBotones(btnCorrectoEq1, btnIncorrectoEq1);
        }

        private void btnEq2_Click(object sender, EventArgs e)
        {
            mostrarBotones(btnCorrectoEq2, btnIncorrectoEq2);
        }

        private void btnCorrectoEq1_Click(object sender, EventArgs e)
        {
            scoreEq1 = scoreEq1 + 10;
            mostrarScore(lblPuntosEq1, scoreEq1);
            tiempo = 30;
            timer1.Stop();
            lblTiempo.Text = "00:" + tiempo.ToString();
            btnEmpezar.Visible = false;
            Bonus(bon);
        }

        private void btnIncorrectoEq1_Click(object sender, EventArgs e)
        {
            if (bon)
            {
                tiempo = 30;
                timer1.Stop();
                lblTiempo.Text = "00:" + tiempo.ToString();
                ocultarBotones(btnCorrectoEq1, btnIncorrectoEq1);
            }
            else
            {
                scoreEq1 = scoreEq1 - 5;
                mostrarScore(lblPuntosEq1, scoreEq1);
                tiempo = 30;
                timer1.Stop();
                lblTiempo.Text = "00:" + tiempo.ToString();
                ocultarBotones(btnCorrectoEq1, btnIncorrectoEq1);
            }
            
        }

        private void btnCorrectoEq2_Click(object sender, EventArgs e)
        {
            scoreEq2 = scoreEq2 + 10;
            mostrarScore(lblPuntosEq2, scoreEq2);
            tiempo = 30;
            timer1.Stop();
            lblTiempo.Text = "00:" + tiempo.ToString();
            btnEmpezar.Visible = false;
            Bonus(bon);
        }

        private void btnIncorrectoEq2_Click(object sender, EventArgs e)
        {
            if (bon)
            {
                tiempo = 30;
                timer1.Stop();
                lblTiempo.Text = "00:" + tiempo.ToString();
                ocultarBotones(btnCorrectoEq1, btnIncorrectoEq1);
            }
            else
            {
                scoreEq2 = scoreEq2 - 5;
                mostrarScore(lblPuntosEq2, scoreEq2);
                tiempo = 30;
                timer1.Stop();
                lblTiempo.Text = "00:" + tiempo.ToString();
                ocultarBotones(btnCorrectoEq2, btnIncorrectoEq2);
            }
            
        }

        private void mostrarScore(Label equipo, int puntaje)
        {
            equipo.Text = puntaje.ToString();
        }

        private void mostrarBotones(Button btnC, Button btnI)
        {
            //btnEmpezar.Visible = true;
            btnC.Visible = true;
            btnI.Visible = true;
        }

        private void ocultarBotones(Button btnC, Button btnI)
        {
            btnEmpezar.Visible = false;
            btnC.Visible = false;
            btnI.Visible = false;
        }

        private void btnEditarEq1_Click(object sender, EventArgs e)
        {
            
            if (InputBox("Edit Score","Type the correct score:", ref value) == DialogResult.OK)
            {
                try
                {
                    scoreEq1 = int.Parse(value);
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show("Please type numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            mostrarScore(lblPuntosEq1, scoreEq1);
        }

        private void btnEditarEq2_Click(object sender, EventArgs e)
        {
            if (InputBox("Edit Score", "Type the correct score:", ref value) == DialogResult.OK)
            {
                try
                {
                    scoreEq2 = int.Parse(value);

                }
                catch (Exception err)
                {
                    MessageBox.Show("Please type numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            mostrarScore(lblPuntosEq2, scoreEq2);
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void Concurso_Load(object sender, EventArgs e)
        {
            btnEq1.Text = eq1;
            btnEq2.Text = eq2;
            lblNombreEq1.Text = eq1;
            lblNombreEq2.Text = eq2;

            StreamReader file = new StreamReader(Environment.CurrentDirectory + "/Recursos/Preguntas/tossUp.txt");
            while ((lineaPreg = file.ReadLine()) != null)
            {
                preguntas.Add(lineaPreg);
            }
            file.Close();

            StreamReader file1 = new StreamReader(Environment.CurrentDirectory + "/Recursos/Preguntas/ansTossUp.txt");
            while ((lineaResp = file1.ReadLine()) != null)
            {
                respuestas.Add(lineaResp);
            }
            file1.Close();

            StreamReader file2 = new StreamReader(Environment.CurrentDirectory + "/Recursos/Score/Score.txt");
            while ((lineaScore = file2.ReadLine()) != null)
            {
                equipos.Add(lineaScore);
            }
            file2.Close();

            StreamReader file3 = new StreamReader(Environment.CurrentDirectory + "/Recursos/Preguntas/Bonus.txt");
            while ((lineaBonus = file3.ReadLine()) != null)
            {
                bonus.Add(lineaBonus);
            }
            file3.Close();

            StreamReader file4 = new StreamReader(Environment.CurrentDirectory + "/Recursos/Preguntas/ansBonus.txt");
            while ((lineaBonusResp = file4.ReadLine()) != null)
            {
                bonusResp.Add(lineaBonusResp);
            }
            file4.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Reemplazar(lblNombreEq1.Text, equipos, lblPuntosEq1.Text);
            Reemplazar(lblNombreEq2.Text, equipos, lblPuntosEq2.Text);

            StreamWriter writer1 = new StreamWriter(Environment.CurrentDirectory + "/Recursos/Score/Score.txt");
            writer1.Write("");
            writer1.Close();
            foreach (string linea in equipos)
            {
                StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "/Recursos/Score/Score.txt", true);
                writer.WriteLine(linea);
                writer.Close();
            }
            this.Close();
        }

        private void Reemplazar(string nombre, ArrayList list, string puntos)
        {
            foreach (string n in list)
            {
                if (nombre == n.Split(' ').First())
                {
                    int sumar = 0;
                    sumar = int.Parse(n.Split(' ').Last());
                    sumar += int.Parse(puntos);
                    list.Remove(n); 
                    list.Add(nombre + " " + sumar.ToString());
                    
                    break;
                }
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            txtAnswer.Visible = true;
        }

        private void Bonus(Boolean check)
        {
            if (check == false)
            {
                DialogResult confBonus;
                confBonus = MessageBox.Show("Do you want a BONUS question?", "Bonus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confBonus == DialogResult.Yes)
                {
                    bon = true;
                    rdm = ind.Next(bonus.Count);

                    txtPreguntas.Text = bonus[rdm].ToString();
                    bonus.RemoveAt(rdm);

                    txtAnswer.Visible = false;
                    txtAnswer.Text = bonusResp[rdm].ToString();
                    bonusResp.RemoveAt(rdm);

                    tiempo = 15;
                    lblTiempo.Text = "00:" + tiempo.ToString();
                    btnEmpezar.Text = "Bonus";
                    btnEmpezar.Visible = true;
                }
            }
            
        }
    }
}
