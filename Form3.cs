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
using System.Collections;

namespace PetroQuiz
{
    public partial class Form3 : Form
    {
        private ArrayList equipos = new ArrayList();
        private string linea = "";
        private string value;
        private int check = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            equipos.Clear();
            for (int i = 0; i < 7; i++)
            {
                if (InputBox("Edit Score", "Type the Team and its respective score:", ref value) == DialogResult.OK)
                {
                    try
                    {
                        check = int.Parse(value.Split(' ').Last());
                        equipos.Add(value.Split(' ').First().ToUpper()+" "+value.Split(' ').Last());                     
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("The score must be numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i -= 1;
                    }
                }               
            }
            txtLista.Clear();
            LLenarLeaderboard();
            Actualizar();
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

        private void LLenarLeaderboard()
        {
            StreamWriter writer1 = new StreamWriter(Environment.CurrentDirectory + "/Recursos/Score/Score.txt");
            writer1.Write("");
            writer1.Close();
            foreach (string linea in equipos)
            {
                StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "/Recursos/Score/Score.txt", true);
                writer.WriteLine(linea);
                writer.Close();
            }
        }

        private void Actualizar()
        {
            equipos.Clear();
            StreamReader file2 = new StreamReader(Environment.CurrentDirectory + "/Recursos/Score/Score.txt");
            while ((linea = file2.ReadLine()) != null)
            {
                equipos.Add(linea);
            }
            file2.Close();
            foreach (string eq in equipos)
            {
                txtLista.AppendText("\n" + eq.Split(' ').First() + "      " + eq.Split(' ').Last() + "\n");
            }
        }
    }
}
